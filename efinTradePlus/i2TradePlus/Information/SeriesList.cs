using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Information
{
	// Token: 0x02000052 RID: 82
	public class SeriesList
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0003C7E0 File Offset: 0x0003ABE0
		public Dictionary<int, SeriesList.SeriesInformation> Items
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0003C80C File Offset: 0x0003AC0C
		public Dictionary<string, int> ItemsKeySymbol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.itemsKeySymbol;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003C838 File Offset: 0x0003AC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddItem(SeriesList.SeriesInformation info)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.items.ContainsKey(info.OrderBookId))
				{
					this.items.Add(info.OrderBookId, info);
					this.itemsKeySymbol.Add(info.Symbol, info.OrderBookId);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x1700006D RID: 109
		public SeriesList.SeriesInformation this[string seriesName]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				SeriesList.SeriesInformation result;
				try
				{
					if (this.itemsKeySymbol.ContainsKey(seriesName))
					{
						result = this[this.itemsKeySymbol[seriesName]];
					}
					else
					{
						result = new SeriesList.SeriesInformation
						{
							OrderBookId = 0
						};
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return result;
			}
		}

		// Token: 0x1700006E RID: 110
		public SeriesList.SeriesInformation this[int orderBookId]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				SeriesList.SeriesInformation result;
				try
				{
					if (this.items.ContainsKey(orderBookId))
					{
						result = this.items[orderBookId];
					}
					else
					{
						result = new SeriesList.SeriesInformation
						{
							OrderBookId = 0
						};
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return result;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003C9A4 File Offset: 0x0003ADA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.items.Clear();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003C9C4 File Offset: 0x0003ADC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ResetData();
			this.items.Clear();
			this.items = null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0003C9F0 File Offset: 0x0003ADF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SeriesList() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.items = new Dictionary<int, SeriesList.SeriesInformation>();
			this.itemsKeySymbol = new Dictionary<string, int>();
			
		}

		// Token: 0x0400020E RID: 526
		public const int GROUP_CALL = 1;

		// Token: 0x0400020F RID: 527
		public const int GROUP_PUT = 2;

		// Token: 0x04000210 RID: 528
		public const int GROUP_FUTURE = 4;

		// Token: 0x04000211 RID: 529
		public const int GROUP_MSTOCK = 5;

		// Token: 0x04000212 RID: 530
		private Dictionary<int, SeriesList.SeriesInformation> items;

		// Token: 0x04000213 RID: 531
		private Dictionary<string, int> itemsKeySymbol;

		// Token: 0x02000053 RID: 83
		public class SeriesInformation
		{
			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x0003CA24 File Offset: 0x0003AE24
			// (set) Token: 0x060003A8 RID: 936 RVA: 0x0003CA50 File Offset: 0x0003AE50
			public int OrderBookId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.orderBookId;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.orderBookId = value;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x0003CA68 File Offset: 0x0003AE68
			// (set) Token: 0x060003AA RID: 938 RVA: 0x0003CA94 File Offset: 0x0003AE94
			public int UnderOrderBookId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.underOrderBookId;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.underOrderBookId = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060003AB RID: 939 RVA: 0x0003CAAC File Offset: 0x0003AEAC
			// (set) Token: 0x060003AC RID: 940 RVA: 0x0003CAD8 File Offset: 0x0003AED8
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

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003AD RID: 941 RVA: 0x0003CAF0 File Offset: 0x0003AEF0
			// (set) Token: 0x060003AE RID: 942 RVA: 0x0003CB1C File Offset: 0x0003AF1C
			public string SeriesType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.seriesType;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.seriesType = value;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060003AF RID: 943 RVA: 0x0003CB34 File Offset: 0x0003AF34
			// (set) Token: 0x060003B0 RID: 944 RVA: 0x0003CB60 File Offset: 0x0003AF60
			public decimal ContractSize
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.contractSize;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.contractSize = value;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x0003CB78 File Offset: 0x0003AF78
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x0003CBA4 File Offset: 0x0003AFA4
			public int NumOfDec
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.numOfDec;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.numOfDec = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x0003CBBC File Offset: 0x0003AFBC
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x0003CBE8 File Offset: 0x0003AFE8
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

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x0003CC00 File Offset: 0x0003B000
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x0003CC2C File Offset: 0x0003B02C
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

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x0003CC44 File Offset: 0x0003B044
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x0003CC70 File Offset: 0x0003B070
			public int MarketCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.marketCode;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.marketCode = value;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x0003CC88 File Offset: 0x0003B088
			// (set) Token: 0x060003BA RID: 954 RVA: 0x0003CCB4 File Offset: 0x0003B0B4
			public int Group
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.group;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.group = value;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060003BB RID: 955 RVA: 0x0003CCCC File Offset: 0x0003B0CC
			// (set) Token: 0x060003BC RID: 956 RVA: 0x0003CCF8 File Offset: 0x0003B0F8
			public decimal PrevFixPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.prevfixPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.prevfixPrice = value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003BD RID: 957 RVA: 0x0003CD10 File Offset: 0x0003B110
			// (set) Token: 0x060003BE RID: 958 RVA: 0x0003CD3C File Offset: 0x0003B13C
			public decimal FixPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.fixPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.fixPrice = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003BF RID: 959 RVA: 0x0003CD54 File Offset: 0x0003B154
			// (set) Token: 0x060003C0 RID: 960 RVA: 0x0003CD80 File Offset: 0x0003B180
			public string ExpireDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.expireDate;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.expireDate = value;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x0003CD98 File Offset: 0x0003B198
			// (set) Token: 0x060003C2 RID: 962 RVA: 0x0003CDC4 File Offset: 0x0003B1C4
			public decimal BidPrice1
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

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0003CDDC File Offset: 0x0003B1DC
			// (set) Token: 0x060003C4 RID: 964 RVA: 0x0003CE08 File Offset: 0x0003B208
			public decimal OfferPrice1
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

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x0003CE20 File Offset: 0x0003B220
			// (set) Token: 0x060003C6 RID: 966 RVA: 0x0003CE4C File Offset: 0x0003B24C
			public int OpenInt
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.openInt;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.openInt = value;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060003C7 RID: 967 RVA: 0x0003CE64 File Offset: 0x0003B264
			// (set) Token: 0x060003C8 RID: 968 RVA: 0x0003CE90 File Offset: 0x0003B290
			public decimal TickSize
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.tickSize;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.tickSize = value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x0003CEA8 File Offset: 0x0003B2A8
			// (set) Token: 0x060003CA RID: 970 RVA: 0x0003CED4 File Offset: 0x0003B2D4
			public decimal StrikPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.strikPrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.strikPrice = value;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060003CB RID: 971 RVA: 0x0003CEEC File Offset: 0x0003B2EC
			// (set) Token: 0x060003CC RID: 972 RVA: 0x0003CF18 File Offset: 0x0003B318
			public decimal LastSalePrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.lastSalePrice;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.lastSalePrice = value;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060003CD RID: 973 RVA: 0x0003CF30 File Offset: 0x0003B330
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
					if (this.lastSalePrice > 0m && this.prevfixPrice > 0m)
					{
						result = this.lastSalePrice - this.prevfixPrice;
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060003CE RID: 974 RVA: 0x0003CFA8 File Offset: 0x0003B3A8
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
					if (this.lastSalePrice > 0m && this.prevfixPrice > 0m)
					{
						result = Math.Round((this.lastSalePrice - this.prevfixPrice) / this.prevfixPrice * 100m, 4);
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060003CF RID: 975 RVA: 0x0003D03C File Offset: 0x0003B43C
			// (set) Token: 0x060003D0 RID: 976 RVA: 0x0003D068 File Offset: 0x0003B468
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

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x0003D080 File Offset: 0x0003B480
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x0003D0AC File Offset: 0x0003B4AC
			public long BidVol1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol1;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.bidVol1 = value;
					}
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x0003D0DC File Offset: 0x0003B4DC
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x0003D108 File Offset: 0x0003B508
			public long BidVol2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol2;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.bidVol2 = value;
					}
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x0003D138 File Offset: 0x0003B538
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x0003D164 File Offset: 0x0003B564
			public long BidVol3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol3;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.bidVol3 = value;
					}
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x0003D194 File Offset: 0x0003B594
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x0003D1C0 File Offset: 0x0003B5C0
			public long BidVol4
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol4;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.bidVol4 = value;
					}
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x0003D1F0 File Offset: 0x0003B5F0
			// (set) Token: 0x060003DA RID: 986 RVA: 0x0003D21C File Offset: 0x0003B61C
			public long BidVol5
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol5;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.bidVol5 = value;
					}
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060003DB RID: 987 RVA: 0x0003D24C File Offset: 0x0003B64C
			// (set) Token: 0x060003DC RID: 988 RVA: 0x0003D278 File Offset: 0x0003B678
			public long OffVol1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol1;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.offVol1 = value;
					}
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060003DD RID: 989 RVA: 0x0003D2A8 File Offset: 0x0003B6A8
			// (set) Token: 0x060003DE RID: 990 RVA: 0x0003D2D4 File Offset: 0x0003B6D4
			public long OffVol2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol2;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.offVol2 = value;
					}
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060003DF RID: 991 RVA: 0x0003D304 File Offset: 0x0003B704
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x0003D330 File Offset: 0x0003B730
			public long OffVol3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol3;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.offVol3 = value;
					}
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x0003D360 File Offset: 0x0003B760
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x0003D38C File Offset: 0x0003B78C
			public long OffVol4
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol4;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.offVol4 = value;
					}
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x0003D3BC File Offset: 0x0003B7BC
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x0003D3E8 File Offset: 0x0003B7E8
			public long OffVol5
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol5;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					if (value != -1L)
					{
						this.offVol5 = value;
					}
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x0003D418 File Offset: 0x0003B818
			public long SumBidVol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.bidVol1 + this.bidVol2 + this.bidVol3 + this.bidVol4 + this.bidVol5;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x0003D460 File Offset: 0x0003B860
			public long SumOffVol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.offVol1 + this.offVol2 + this.offVol3 + this.offVol4 + this.offVol5;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x0003D4A8 File Offset: 0x0003B8A8
			public bool IsCanTrade
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.group == 1 || this.group == 2 || this.group == 4;
				}
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0003D4F4 File Offset: 0x0003B8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SeriesInformation() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.symbol = string.Empty;
				this.seriesType = string.Empty;
				this.contractSize = 0m;
				this.numOfDec = 0;
				this.ceiling = 0m;
				this.floor = 0m;
				this.marketCode = 0;
				this.group = 0;
				this.prevfixPrice = 0m;
				this.fixPrice = 0m;
				this.expireDate = null;
				this.marketId = string.Empty;
				
			}

			// Token: 0x04000214 RID: 532
			private int orderBookId;

			// Token: 0x04000215 RID: 533
			private int underOrderBookId;

			// Token: 0x04000216 RID: 534
			private string symbol;

			// Token: 0x04000217 RID: 535
			private string seriesType;

			// Token: 0x04000218 RID: 536
			private decimal contractSize;

			// Token: 0x04000219 RID: 537
			private int numOfDec;

			// Token: 0x0400021A RID: 538
			private decimal ceiling;

			// Token: 0x0400021B RID: 539
			private decimal floor;

			// Token: 0x0400021C RID: 540
			private int marketCode;

			// Token: 0x0400021D RID: 541
			private int group;

			// Token: 0x0400021E RID: 542
			private decimal prevfixPrice;

			// Token: 0x0400021F RID: 543
			private decimal fixPrice;

			// Token: 0x04000220 RID: 544
			private string expireDate;

			// Token: 0x04000221 RID: 545
			private decimal bidPrice1;

			// Token: 0x04000222 RID: 546
			private decimal offerPrice1;

			// Token: 0x04000223 RID: 547
			private int openInt;

			// Token: 0x04000224 RID: 548
			private decimal tickSize;

			// Token: 0x04000225 RID: 549
			private decimal strikPrice;

			// Token: 0x04000226 RID: 550
			private decimal lastSalePrice;

			// Token: 0x04000227 RID: 551
			private string marketId;

			// Token: 0x04000228 RID: 552
			private long bidVol1;

			// Token: 0x04000229 RID: 553
			private long bidVol2;

			// Token: 0x0400022A RID: 554
			private long bidVol3;

			// Token: 0x0400022B RID: 555
			private long bidVol4;

			// Token: 0x0400022C RID: 556
			private long bidVol5;

			// Token: 0x0400022D RID: 557
			private long offVol1;

			// Token: 0x0400022E RID: 558
			private long offVol2;

			// Token: 0x0400022F RID: 559
			private long offVol3;

			// Token: 0x04000230 RID: 560
			private long offVol4;

			// Token: 0x04000231 RID: 561
			private long offVol5;
		}
	}
}
