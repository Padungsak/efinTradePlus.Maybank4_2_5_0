using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Information
{
	// Token: 0x020000D4 RID: 212
	public class StockList
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000BE40C File Offset: 0x000BC80C
		public Dictionary<int, StockList.StockInformation> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.items;
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000BE438 File Offset: 0x000BC838
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddItem(StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.items.ContainsKey(stockInfo.Number))
				{
					this.items.Add(stockInfo.Number, stockInfo);
				}
				if (!this.itemsName.ContainsKey(stockInfo.Symbol))
				{
					this.itemsName.Add(stockInfo.Symbol, stockInfo.Number);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x17000143 RID: 323
		public StockList.StockInformation this[int stockNumber]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				StockList.StockInformation result;
				if (this.items.ContainsKey(stockNumber))
				{
					result = this.items[stockNumber];
				}
				else
				{
					result = new StockList.StockInformation
					{
						Number = -1,
						Symbol = "#NONE"
					};
				}
				return result;
			}
		}

		// Token: 0x17000144 RID: 324
		public StockList.StockInformation this[string stockSymbol]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				StockList.StockInformation result;
				if (this.itemsName.ContainsKey(stockSymbol))
				{
					result = this.items[this.itemsName[stockSymbol]];
				}
				else
				{
					result = new StockList.StockInformation
					{
						Number = -1,
						Symbol = "#NONE"
					};
				}
				return result;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000BE5A8 File Offset: 0x000BC9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.items != null)
			{
				this.items.Clear();
			}
			if (this.itemsName != null)
			{
				this.itemsName.Clear();
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000BE5FC File Offset: 0x000BC9FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ResetData();
			this.items = null;
			this.itemsName = null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000BE624 File Offset: 0x000BCA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StockList()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.items = new Dictionary<int, StockList.StockInformation>();
			this.itemsName = new Dictionary<string, int>();
			base..ctor();
		}

		// Token: 0x0400069A RID: 1690
		private Dictionary<int, StockList.StockInformation> items;

		// Token: 0x0400069B RID: 1691
		private Dictionary<string, int> itemsName;

		// Token: 0x020000D5 RID: 213
		public class StockInformation
		{
			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060009DA RID: 2522 RVA: 0x000BE658 File Offset: 0x000BCA58
			// (set) Token: 0x060009DB RID: 2523 RVA: 0x000BE684 File Offset: 0x000BCA84
			public int Number
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.number;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.number = value;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060009DC RID: 2524 RVA: 0x000BE69C File Offset: 0x000BCA9C
			// (set) Token: 0x060009DD RID: 2525 RVA: 0x000BE6C8 File Offset: 0x000BCAC8
			public string Symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.symbol;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.symbol = value;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060009DE RID: 2526 RVA: 0x000BE6E0 File Offset: 0x000BCAE0
			// (set) Token: 0x060009DF RID: 2527 RVA: 0x000BE70C File Offset: 0x000BCB0C
			public int BoardLot
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.boardLot;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.boardLot = value;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000BE724 File Offset: 0x000BCB24
			// (set) Token: 0x060009E1 RID: 2529 RVA: 0x000BE750 File Offset: 0x000BCB50
			public decimal Ceiling
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.ceiling;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.ceiling = value;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000BE768 File Offset: 0x000BCB68
			// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000BE794 File Offset: 0x000BCB94
			public decimal Floor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.floor;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.floor = value;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000BE7AC File Offset: 0x000BCBAC
			// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000BE7D8 File Offset: 0x000BCBD8
			public string DisplayFlag
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.displayFlag;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.displayFlag = value;
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000BE7F0 File Offset: 0x000BCBF0
			// (set) Token: 0x060009E7 RID: 2535 RVA: 0x000BE81C File Offset: 0x000BCC1C
			public string MarketId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.marketId;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.marketId = value;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000BE834 File Offset: 0x000BCC34
			// (set) Token: 0x060009E9 RID: 2537 RVA: 0x000BE860 File Offset: 0x000BCC60
			public decimal PriorPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.priorPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.priorPrice = value;
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060009EA RID: 2538 RVA: 0x000BE878 File Offset: 0x000BCC78
			// (set) Token: 0x060009EB RID: 2539 RVA: 0x000BE8A4 File Offset: 0x000BCCA4
			public int SectorNumber
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.sectorNumber;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.sectorNumber = value;
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x000BE8BC File Offset: 0x000BCCBC
			// (set) Token: 0x060009ED RID: 2541 RVA: 0x000BE8E8 File Offset: 0x000BCCE8
			public string SecurityType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.securityType;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.securityType = value;
					this.SetStockBoard();
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x000BE908 File Offset: 0x000BCD08
			// (set) Token: 0x060009EF RID: 2543 RVA: 0x000BE934 File Offset: 0x000BCD34
			public bool IsOddLot
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.isOddLot;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.isOddLot = value;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000BE94C File Offset: 0x000BCD4C
			// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000BE978 File Offset: 0x000BCD78
			public decimal LastSalePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.lastPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.lastPrice = value;
					if (value > this.highPrice)
					{
						this.highPrice = value;
					}
					if (this.lowPrice == 0m || value < this.lowPrice)
					{
						this.lowPrice = value;
					}
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000BE9F4 File Offset: 0x000BCDF4
			// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000BEA20 File Offset: 0x000BCE20
			public decimal HighPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.highPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.highPrice = value;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000BEA38 File Offset: 0x000BCE38
			// (set) Token: 0x060009F5 RID: 2549 RVA: 0x000BEA64 File Offset: 0x000BCE64
			public decimal LowPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.lowPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.lowPrice = value;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000BEA7C File Offset: 0x000BCE7C
			public decimal ChangePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					decimal result;
					if (this.lastPrice > 0m && this.priorPrice > 0m)
					{
						result = this.lastPrice - this.priorPrice;
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000BEAF4 File Offset: 0x000BCEF4
			public decimal ChangePricePct
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					decimal result;
					if (this.lastPrice > 0m && this.priorPrice > 0m)
					{
						result = Math.Round((this.lastPrice - this.priorPrice) / this.priorPrice * 100m, 4);
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000BEB88 File Offset: 0x000BCF88
			// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000BEBB4 File Offset: 0x000BCFB4
			public string BidPrice1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidPrice1;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.bidPrice1 = value;
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060009FA RID: 2554 RVA: 0x000BEBCC File Offset: 0x000BCFCC
			// (set) Token: 0x060009FB RID: 2555 RVA: 0x000BEBF8 File Offset: 0x000BCFF8
			public string OfferPrice1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offerPrice1;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.offerPrice1 = value;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060009FC RID: 2556 RVA: 0x000BEC10 File Offset: 0x000BD010
			public string StockBoard
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.stockBoard;
				}
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x000BEC3C File Offset: 0x000BD03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void SetStockBoard()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				string text = this.securityType;
				switch (text)
				{
				case "S":
				case "U":
				case "M":
				case "D":
				case "C":
				case "P":
				case "W":
				case "J":
				case "G":
				case "R":
				case "I":
				case "X":
				case "V":
				case "O":
					this.stockBoard = "M";
					return;
				}
				this.stockBoard = "F";
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060009FE RID: 2558 RVA: 0x000BEDA4 File Offset: 0x000BD1A4
			// (set) Token: 0x060009FF RID: 2559 RVA: 0x000BEDD0 File Offset: 0x000BD1D0
			public bool IsCheckSpread
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.isCheckSpread;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.isCheckSpread = value;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000BEDE8 File Offset: 0x000BD1E8
			// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000BEE14 File Offset: 0x000BD214
			public long TotBidVol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.totBidVol;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.totBidVol = value;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000BEE2C File Offset: 0x000BD22C
			// (set) Token: 0x06000A03 RID: 2563 RVA: 0x000BEE58 File Offset: 0x000BD258
			public long TotOfferVol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.totOfferVol;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.totOfferVol = value;
				}
			}

			// Token: 0x06000A04 RID: 2564 RVA: 0x000BEE70 File Offset: 0x000BD270
			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockInformation()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.number = 0;
				this.symbol = string.Empty;
				this.boardLot = 0;
				this.ceiling = 0m;
				this.floor = 0m;
				this.displayFlag = string.Empty;
				this.marketId = string.Empty;
				this.priorPrice = 0m;
				this.sectorNumber = 0;
				this.securityType = string.Empty;
				this.isOddLot = false;
				this.lastPrice = 0m;
				this.highPrice = 0m;
				this.lowPrice = 0m;
				this.bidPrice1 = string.Empty;
				this.offerPrice1 = string.Empty;
				this.stockBoard = string.Empty;
				this.isCheckSpread = true;
				base..ctor();
			}

			// Token: 0x0400069C RID: 1692
			private int number;

			// Token: 0x0400069D RID: 1693
			private string symbol;

			// Token: 0x0400069E RID: 1694
			private int boardLot;

			// Token: 0x0400069F RID: 1695
			private decimal ceiling;

			// Token: 0x040006A0 RID: 1696
			private decimal floor;

			// Token: 0x040006A1 RID: 1697
			private string displayFlag;

			// Token: 0x040006A2 RID: 1698
			private string marketId;

			// Token: 0x040006A3 RID: 1699
			private decimal priorPrice;

			// Token: 0x040006A4 RID: 1700
			private int sectorNumber;

			// Token: 0x040006A5 RID: 1701
			private string securityType;

			// Token: 0x040006A6 RID: 1702
			private bool isOddLot;

			// Token: 0x040006A7 RID: 1703
			private decimal lastPrice;

			// Token: 0x040006A8 RID: 1704
			private decimal highPrice;

			// Token: 0x040006A9 RID: 1705
			private decimal lowPrice;

			// Token: 0x040006AA RID: 1706
			private string bidPrice1;

			// Token: 0x040006AB RID: 1707
			private string offerPrice1;

			// Token: 0x040006AC RID: 1708
			private string stockBoard;

			// Token: 0x040006AD RID: 1709
			private bool isCheckSpread;

			// Token: 0x040006AE RID: 1710
			private long totBidVol;

			// Token: 0x040006AF RID: 1711
			private long totOfferVol;
		}
	}
}
