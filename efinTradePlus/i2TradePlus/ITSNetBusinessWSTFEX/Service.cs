using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200022F RID: 559
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), WebServiceBinding(Name = "ServiceSoap", Namespace = "http://tempuri.org/")]
	public class Service : SoapHttpClientProtocol
	{
		// Token: 0x06001473 RID: 5235 RVA: 0x00116E24 File Offset: 0x00115224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Service() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.Url = Settings.Default.i2TradePlus_ITSNetBusinessWSTFEX_Service;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00116E94 File Offset: 0x00115294
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00116EC0 File Offset: 0x001152C0
		public new string Url
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Url;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00116F20 File Offset: 0x00115320
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x00116F4C File Offset: 0x0011534C
		public new bool UseDefaultCredentials
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.UseDefaultCredentials;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}

		// Token: 0x140000CD RID: 205
		// (add) Token: 0x06001478 RID: 5240 RVA: 0x00116F6C File Offset: 0x0011536C
		// (remove) Token: 0x06001479 RID: 5241 RVA: 0x00116F94 File Offset: 0x00115394
		public LoadSETindexCompletedEventHandler _LoadSETindexCompleted;
		public event LoadSETindexCompletedEventHandler LoadSETindexCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._LoadSETindexCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._LoadSETindexCompleted -= value;
            }
		}

		// Token: 0x140000CE RID: 206
		// (add) Token: 0x0600147A RID: 5242 RVA: 0x00116FBC File Offset: 0x001153BC
		// (remove) Token: 0x0600147B RID: 5243 RVA: 0x00116FE4 File Offset: 0x001153E4
		public LoadMktStatusCompletedEventHandler _LoadMktStatusCompleted;
		public event LoadMktStatusCompletedEventHandler LoadMktStatusCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._LoadMktStatusCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._LoadMktStatusCompleted -= value;
            }
		}

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x0600147C RID: 5244 RVA: 0x0011700C File Offset: 0x0011540C
		// (remove) Token: 0x0600147D RID: 5245 RVA: 0x00117034 File Offset: 0x00115434
		public TFEXInformationCompletedEventHandler _TFEXInformationCompleted;
		public event TFEXInformationCompletedEventHandler TFEXInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._TFEXInformationCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
			    this._TFEXInformationCompleted -= value;
            }
		}
        ///////////////////
		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x0600147E RID: 5246 RVA: 0x0011705C File Offset: 0x0011545C
		// (remove) Token: 0x0600147F RID: 5247 RVA: 0x00117084 File Offset: 0x00115484
		public LoadTFEXInformationCompletedEventHandler _LoadTFEXInformationCompleted;
		public event LoadTFEXInformationCompletedEventHandler LoadTFEXInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._LoadTFEXInformationCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._LoadTFEXInformationCompleted -= value;
            }
		}

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x06001480 RID: 5248 RVA: 0x001170AC File Offset: 0x001154AC
		// (remove) Token: 0x06001481 RID: 5249 RVA: 0x001170D4 File Offset: 0x001154D4
		public SeriesStateCompletedEventHandler _SeriesStateCompleted;
		public event SeriesStateCompletedEventHandler SeriesStateCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
					this._SeriesStateCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._SeriesStateCompleted -= value;
            }
		}

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x06001482 RID: 5250 RVA: 0x001170FC File Offset: 0x001154FC
		// (remove) Token: 0x06001483 RID: 5251 RVA: 0x00117124 File Offset: 0x00115524
		public GetTotalMarketValueInfoCompletedEventHandler _GetTotalMarketValueInfoCompleted;
		public event GetTotalMarketValueInfoCompletedEventHandler GetTotalMarketValueInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._GetTotalMarketValueInfoCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._GetTotalMarketValueInfoCompleted -= value;
            }
		}

		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x06001484 RID: 5252 RVA: 0x0011714C File Offset: 0x0011554C
		// (remove) Token: 0x06001485 RID: 5253 RVA: 0x00117174 File Offset: 0x00115574
		public SeriesByPricePageCompletedEventHandler _SeriesByPricePageCompleted;
		public event SeriesByPricePageCompletedEventHandler SeriesByPricePageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._SeriesByPricePageCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._SeriesByPricePageCompleted -= value;
            }
		}

		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06001486 RID: 5254 RVA: 0x0011719C File Offset: 0x0011559C
		// (remove) Token: 0x06001487 RID: 5255 RVA: 0x001171C4 File Offset: 0x001155C4
		public TopBBOTFEXCompletedEventHandler _TopBBOTFEXCompleted;
		public event TopBBOTFEXCompletedEventHandler TopBBOTFEXCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._TopBBOTFEXCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._TopBBOTFEXCompleted -= value;
            }
		}

		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06001488 RID: 5256 RVA: 0x001171EC File Offset: 0x001155EC
		// (remove) Token: 0x06001489 RID: 5257 RVA: 0x00117214 File Offset: 0x00115614
		public TopBBOTFEXadCompletedEventHandler _TopBBOTFEXadCompleted;
		public event TopBBOTFEXadCompletedEventHandler TopBBOTFEXadCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._TopBBOTFEXadCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._TopBBOTFEXadCompleted -= value;
            }
		}

		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x0600148A RID: 5258 RVA: 0x0011723C File Offset: 0x0011563C
		// (remove) Token: 0x0600148B RID: 5259 RVA: 0x00117264 File Offset: 0x00115664
		public TFEXTopActiveBBOCompletedEventHandler _TFEXTopActiveBBOCompleted;
		public event TFEXTopActiveBBOCompletedEventHandler TFEXTopActiveBBOCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._TFEXTopActiveBBOCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._TFEXTopActiveBBOCompleted -= value;
            }
		}

		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x0600148C RID: 5260 RVA: 0x0011728C File Offset: 0x0011568C
		// (remove) Token: 0x0600148D RID: 5261 RVA: 0x001172B4 File Offset: 0x001156B4
        public TFEXTopActiveBBO_MyPortCompletedEventHandler _TFEXTopActiveBBO_MyPortCompleted;
		public event TFEXTopActiveBBO_MyPortCompletedEventHandler TFEXTopActiveBBO_MyPortCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TFEXTopActiveBBO_MyPortCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TFEXTopActiveBBO_MyPortCompleted -= value;
            }
		}

		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x0600148E RID: 5262 RVA: 0x001172DC File Offset: 0x001156DC
		// (remove) Token: 0x0600148F RID: 5263 RVA: 0x00117304 File Offset: 0x00115704
		public BestProjected_TFEXCompletedEventHandler _BestProjected_TFEXCompleted;
		public event BestProjected_TFEXCompletedEventHandler BestProjected_TFEXCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestProjected_TFEXCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestProjected_TFEXCompleted -= value;
            }
		}

		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06001490 RID: 5264 RVA: 0x0011732C File Offset: 0x0011572C
		// (remove) Token: 0x06001491 RID: 5265 RVA: 0x00117354 File Offset: 0x00115754
		public BestBidOfferByListCompletedEventHandler _BestBidOfferByListCompleted;
		public event BestBidOfferByListCompletedEventHandler BestBidOfferByListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestBidOfferByListCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestBidOfferByListCompleted -= value;
            }
		}

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06001492 RID: 5266 RVA: 0x0011737C File Offset: 0x0011577C
		// (remove) Token: 0x06001493 RID: 5267 RVA: 0x001173A4 File Offset: 0x001157A4
		public BestBidOfferByInstrumentCompletedEventHandler _BestBidOfferByInstrumentCompleted;
		public event BestBidOfferByInstrumentCompletedEventHandler BestBidOfferByInstrumentCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestBidOfferByInstrumentCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestBidOfferByInstrumentCompleted -= value;
            }
		}

		// Token: 0x140000DB RID: 219
		// (add) Token: 0x06001494 RID: 5268 RVA: 0x001173CC File Offset: 0x001157CC
		// (remove) Token: 0x06001495 RID: 5269 RVA: 0x001173F4 File Offset: 0x001157F4
		public BestBidOfferByOptionsListCompletedEventHandler _BestBidOfferByOptionsListCompleted;
		public event BestBidOfferByOptionsListCompletedEventHandler BestBidOfferByOptionsListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestBidOfferByOptionsListCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestBidOfferByOptionsListCompleted -= value;
            }
		}

		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06001496 RID: 5270 RVA: 0x0011741C File Offset: 0x0011581C
		// (remove) Token: 0x06001497 RID: 5271 RVA: 0x00117444 File Offset: 0x00115844
		public Get5BidOfferTFEXCompletedEventHandler _Get5BidOfferTFEXCompleted;
		public event Get5BidOfferTFEXCompletedEventHandler Get5BidOfferTFEXCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._Get5BidOfferTFEXCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._Get5BidOfferTFEXCompleted -= value;
            }
		}

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06001498 RID: 5272 RVA: 0x0011746C File Offset: 0x0011586C
		// (remove) Token: 0x06001499 RID: 5273 RVA: 0x00117494 File Offset: 0x00115894
		public GetChartImageCompletedEventHandler _GetChartImageCompleted;
		public event GetChartImageCompletedEventHandler GetChartImageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetChartImageCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetChartImageCompleted -= value;
            }
		}

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x0600149A RID: 5274 RVA: 0x001174BC File Offset: 0x001158BC
		// (remove) Token: 0x0600149B RID: 5275 RVA: 0x001174E4 File Offset: 0x001158E4
		public GetSwitchAccountInfoTFEXCompletedEventHandler _GetSwitchAccountInfoTFEXCompleted;
		public event GetSwitchAccountInfoTFEXCompletedEventHandler GetSwitchAccountInfoTFEXCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetSwitchAccountInfoTFEXCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetSwitchAccountInfoTFEXCompleted -= value;
            }
		}

		// Token: 0x140000DF RID: 223
		// (add) Token: 0x0600149C RID: 5276 RVA: 0x0011750C File Offset: 0x0011590C
		// (remove) Token: 0x0600149D RID: 5277 RVA: 0x00117534 File Offset: 0x00115934
		public SeriesSaleByTimeCompletedEventHandler _SeriesSaleByTimeCompleted;
		public event SeriesSaleByTimeCompletedEventHandler SeriesSaleByTimeCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SeriesSaleByTimeCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SeriesSaleByTimeCompleted -= value;
            }
		}

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x0600149E RID: 5278 RVA: 0x0011755C File Offset: 0x0011595C
		// (remove) Token: 0x0600149F RID: 5279 RVA: 0x00117584 File Offset: 0x00115984
		public SeriesSaleByPriceCompletedEventHandler _SeriesSaleByPriceCompleted;
		public event SeriesSaleByPriceCompletedEventHandler SeriesSaleByPriceCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SeriesSaleByPriceCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SeriesSaleByPriceCompleted -= value;
            }
		}

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x060014A0 RID: 5280 RVA: 0x001175AC File Offset: 0x001159AC
		// (remove) Token: 0x060014A1 RID: 5281 RVA: 0x001175D4 File Offset: 0x001159D4
		public StockInPlayCompletedEventHandler _StockInPlayCompleted;
		public event StockInPlayCompletedEventHandler StockInPlayCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockInPlayCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockInPlayCompleted -= value;
            }
		}

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x060014A2 RID: 5282 RVA: 0x001175FC File Offset: 0x001159FC
		// (remove) Token: 0x060014A3 RID: 5283 RVA: 0x00117624 File Offset: 0x00115A24
		public StockInPlayADCompletedEventHandler _StockInPlayADCompleted;
		public event StockInPlayADCompletedEventHandler StockInPlayADCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockInPlayADCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockInPlayADCompleted -= value;
            }
		}

		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x060014A4 RID: 5284 RVA: 0x0011764C File Offset: 0x00115A4C
		// (remove) Token: 0x060014A5 RID: 5285 RVA: 0x00117674 File Offset: 0x00115A74
		public  SeriesSumaryCompletedEventHandler _SeriesSumaryCompleted;
		public event SeriesSumaryCompletedEventHandler SeriesSumaryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SeriesSumaryCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SeriesSumaryCompleted -= value;
            }
		}

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x060014A6 RID: 5286 RVA: 0x0011769C File Offset: 0x00115A9C
		// (remove) Token: 0x060014A7 RID: 5287 RVA: 0x001176C4 File Offset: 0x00115AC4
		public TFEXBoardcastMessageCompletedEventHandler _TFEXBoardcastMessageCompleted;
		public event TFEXBoardcastMessageCompletedEventHandler TFEXBoardcastMessageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TFEXBoardcastMessageCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TFEXBoardcastMessageCompleted -= value;
            }
		}

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x060014A8 RID: 5288 RVA: 0x001176EC File Offset: 0x00115AEC
		// (remove) Token: 0x060014A9 RID: 5289 RVA: 0x00117714 File Offset: 0x00115B14
		public ViewOrderTransactionCompletedEventHandler _ViewOrderTransactionCompleted;
		public event ViewOrderTransactionCompletedEventHandler ViewOrderTransactionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderTransactionCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderTransactionCompleted -= value;
            }
		}

		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x060014AA RID: 5290 RVA: 0x0011773C File Offset: 0x00115B3C
		// (remove) Token: 0x060014AB RID: 5291 RVA: 0x00117764 File Offset: 0x00115B64
		public ViewOrderByOrderNoCompletedEventHandler _ViewOrderByOrderNoCompleted;
		public event ViewOrderByOrderNoCompletedEventHandler ViewOrderByOrderNoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderByOrderNoCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderByOrderNoCompleted -= value;
            }
		}

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x060014AC RID: 5292 RVA: 0x0011778C File Offset: 0x00115B8C
		// (remove) Token: 0x060014AD RID: 5293 RVA: 0x001177B4 File Offset: 0x00115BB4
		public ViewCustomersCreditCompletedEventHandler _ViewCustomersCreditCompleted;
		public event ViewCustomersCreditCompletedEventHandler ViewCustomersCreditCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomersCreditCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomersCreditCompleted -= value;
            }
		}

		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x060014AE RID: 5294 RVA: 0x001177DC File Offset: 0x00115BDC
		// (remove) Token: 0x060014AF RID: 5295 RVA: 0x00117804 File Offset: 0x00115C04
		public ViewCustomersInfoCompletedEventHandler _ViewCustomersInfoCompleted;
		public event ViewCustomersInfoCompletedEventHandler ViewCustomersInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomersInfoCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomersInfoCompleted -= value;
            }
		}

		// Token: 0x140000E9 RID: 233
		// (add) Token: 0x060014B0 RID: 5296 RVA: 0x0011782C File Offset: 0x00115C2C
		// (remove) Token: 0x060014B1 RID: 5297 RVA: 0x00117854 File Offset: 0x00115C54
		public ViewCustomersAllCompletedEventHandler _ViewCustomersAllCompleted;
		public event ViewCustomersAllCompletedEventHandler ViewCustomersAllCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomersAllCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomersAllCompleted -= value;
            }
		}

		// Token: 0x140000EA RID: 234
		// (add) Token: 0x060014B2 RID: 5298 RVA: 0x0011787C File Offset: 0x00115C7C
		// (remove) Token: 0x060014B3 RID: 5299 RVA: 0x001178A4 File Offset: 0x00115CA4
		public ViewOrderDealDataCompletedEventHandler _ViewOrderDealDataCompleted;
		public event ViewOrderDealDataCompletedEventHandler ViewOrderDealDataCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderDealDataCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderDealDataCompleted -= value;
            }
		}

		// Token: 0x140000EB RID: 235
		// (add) Token: 0x060014B4 RID: 5300 RVA: 0x001178CC File Offset: 0x00115CCC
		// (remove) Token: 0x060014B5 RID: 5301 RVA: 0x001178F4 File Offset: 0x00115CF4
		public ViewCustomerCreditOnSendBoxCompletedEventHandler _ViewCustomerCreditOnSendBoxCompleted;
		public event ViewCustomerCreditOnSendBoxCompletedEventHandler ViewCustomerCreditOnSendBoxCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomerCreditOnSendBoxCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomerCreditOnSendBoxCompleted -= value;
            }
		}

		// Token: 0x140000EC RID: 236
		// (add) Token: 0x060014B6 RID: 5302 RVA: 0x0011791C File Offset: 0x00115D1C
		// (remove) Token: 0x060014B7 RID: 5303 RVA: 0x00117944 File Offset: 0x00115D44
		public ViewCustomer_RiskManagementCompletedEventHandler _ViewCustomer_RiskManagementCompleted;
		public event ViewCustomer_RiskManagementCompletedEventHandler ViewCustomer_RiskManagementCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_RiskManagementCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_RiskManagementCompleted -= value;
            }
		}

		// Token: 0x140000ED RID: 237
		// (add) Token: 0x060014B8 RID: 5304 RVA: 0x0011796C File Offset: 0x00115D6C
		// (remove) Token: 0x060014B9 RID: 5305 RVA: 0x00117994 File Offset: 0x00115D94
		public SendTFEXNewOrderCompletedEventHandler _SendTFEXNewOrderCompleted;
		public event SendTFEXNewOrderCompletedEventHandler SendTFEXNewOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendTFEXNewOrderCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendTFEXNewOrderCompleted -= value;
            }
		}

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x060014BA RID: 5306 RVA: 0x001179BC File Offset: 0x00115DBC
		// (remove) Token: 0x060014BB RID: 5307 RVA: 0x001179E4 File Offset: 0x00115DE4
		public SendTFEXCancelOrderCompletedEventHandler _SendTFEXCancelOrderCompleted;
		public event SendTFEXCancelOrderCompletedEventHandler SendTFEXCancelOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendTFEXCancelOrderCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendTFEXCancelOrderCompleted -= value;
            }
		}

		// Token: 0x140000EF RID: 239
		// (add) Token: 0x060014BC RID: 5308 RVA: 0x00117A0C File Offset: 0x00115E0C
		// (remove) Token: 0x060014BD RID: 5309 RVA: 0x00117A34 File Offset: 0x00115E34
		public WriteLogCompletedEventHandler _WriteLogCompleted;
		public event WriteLogCompletedEventHandler WriteLogCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._WriteLogCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._WriteLogCompleted -= value;
            }
		}

		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x060014BE RID: 5310 RVA: 0x00117A5C File Offset: 0x00115E5C
		// (remove) Token: 0x060014BF RID: 5311 RVA: 0x00117A84 File Offset: 0x00115E84
		public event GetGoldSpotCompletedEventHandler _GetGoldSpotCompleted;
		public event GetGoldSpotCompletedEventHandler GetGoldSpotCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetGoldSpotCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetGoldSpotCompleted += value;
            }
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00117AAC File Offset: 0x00115EAC
		[SoapDocumentMethod("http://tempuri.org/LoadSETindex", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadSETindex()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadSETindex", new object[0]);
			return (string)array[0];
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00117AEC File Offset: 0x00115EEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSETindexAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadSETindexAsync(null);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00117B08 File Offset: 0x00115F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSETindexAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadSETindexOperationCompleted == null)
			{
				this.LoadSETindexOperationCompleted = new SendOrPostCallback(this.OnLoadSETindexOperationCompleted);
			}
			base.InvokeAsync("LoadSETindex", new object[0], this.LoadSETindexOperationCompleted, userState);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00117B64 File Offset: 0x00115F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadSETindexOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadSETindexCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadSETindexCompleted(this, new LoadSETindexCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00117BC4 File Offset: 0x00115FC4
		[SoapDocumentMethod("http://tempuri.org/LoadMktStatus", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadMktStatus()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadMktStatus", new object[0]);
			return (string)array[0];
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00117C04 File Offset: 0x00116004
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadMktStatusAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadMktStatusAsync(null);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00117C20 File Offset: 0x00116020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadMktStatusAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadMktStatusOperationCompleted == null)
			{
				this.LoadMktStatusOperationCompleted = new SendOrPostCallback(this.OnLoadMktStatusOperationCompleted);
			}
			base.InvokeAsync("LoadMktStatus", new object[0], this.LoadMktStatusOperationCompleted, userState);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00117C7C File Offset: 0x0011607C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadMktStatusOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadMktStatusCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadMktStatusCompleted(this, new LoadMktStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00117CDC File Offset: 0x001160DC
		[SoapDocumentMethod("http://tempuri.org/TFEXInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TFEXInformation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TFEXInformation", new object[0]);
			return (string)array[0];
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00117D1C File Offset: 0x0011611C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXInformationAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TFEXInformationAsync(null);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00117D38 File Offset: 0x00116138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXInformationAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TFEXInformationOperationCompleted == null)
			{
				this.TFEXInformationOperationCompleted = new SendOrPostCallback(this.OnTFEXInformationOperationCompleted);
			}
			base.InvokeAsync("TFEXInformation", new object[0], this.TFEXInformationOperationCompleted, userState);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00117D94 File Offset: 0x00116194
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTFEXInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TFEXInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TFEXInformationCompleted(this, new TFEXInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00117DF4 File Offset: 0x001161F4
		[SoapDocumentMethod("http://tempuri.org/LoadTFEXInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadTFEXInformation(int orderBookId, int topSelect)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadTFEXInformation", new object[]
			{
				orderBookId,
				topSelect
			});
			return (string)array[0];
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00117E48 File Offset: 0x00116248
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadTFEXInformationAsync(int orderBookId, int topSelect)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadTFEXInformationAsync(orderBookId, topSelect, null);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00117E64 File Offset: 0x00116264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadTFEXInformationAsync(int orderBookId, int topSelect, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadTFEXInformationOperationCompleted == null)
			{
				this.LoadTFEXInformationOperationCompleted = new SendOrPostCallback(this.OnLoadTFEXInformationOperationCompleted);
			}
			base.InvokeAsync("LoadTFEXInformation", new object[]
			{
				orderBookId,
				topSelect
			}, this.LoadTFEXInformationOperationCompleted, userState);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00117ED4 File Offset: 0x001162D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadTFEXInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadTFEXInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadTFEXInformationCompleted(this, new LoadTFEXInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00117F34 File Offset: 0x00116334
		[SoapDocumentMethod("http://tempuri.org/SeriesState", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SeriesState()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SeriesState", new object[0]);
			return (string)array[0];
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00117F74 File Offset: 0x00116374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesStateAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SeriesStateAsync(null);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00117F90 File Offset: 0x00116390
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesStateAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SeriesStateOperationCompleted == null)
			{
				this.SeriesStateOperationCompleted = new SendOrPostCallback(this.OnSeriesStateOperationCompleted);
			}
			base.InvokeAsync("SeriesState", new object[0], this.SeriesStateOperationCompleted, userState);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00117FEC File Offset: 0x001163EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSeriesStateOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SeriesStateCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SeriesStateCompleted(this, new SeriesStateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0011804C File Offset: 0x0011644C
		[SoapDocumentMethod("http://tempuri.org/GetTotalMarketValueInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetTotalMarketValueInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetTotalMarketValueInfo", new object[0]);
			return (string)array[0];
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0011808C File Offset: 0x0011648C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTotalMarketValueInfoAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetTotalMarketValueInfoAsync(null);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x001180A8 File Offset: 0x001164A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTotalMarketValueInfoAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetTotalMarketValueInfoOperationCompleted == null)
			{
				this.GetTotalMarketValueInfoOperationCompleted = new SendOrPostCallback(this.OnGetTotalMarketValueInfoOperationCompleted);
			}
			base.InvokeAsync("GetTotalMarketValueInfo", new object[0], this.GetTotalMarketValueInfoOperationCompleted, userState);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00118104 File Offset: 0x00116504
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetTotalMarketValueInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetTotalMarketValueInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetTotalMarketValueInfoCompleted(this, new GetTotalMarketValueInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00118164 File Offset: 0x00116564
		[SoapDocumentMethod("http://tempuri.org/SeriesByPricePage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SeriesByPricePage(string seriesInfo, string seriesType, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SeriesByPricePage", new object[]
			{
				seriesInfo,
				seriesType,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x001181B4 File Offset: 0x001165B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesByPricePageAsync(string seriesInfo, string seriesType, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SeriesByPricePageAsync(seriesInfo, seriesType, maxTicker, null);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x001181D0 File Offset: 0x001165D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesByPricePageAsync(string seriesInfo, string seriesType, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SeriesByPricePageOperationCompleted == null)
			{
				this.SeriesByPricePageOperationCompleted = new SendOrPostCallback(this.OnSeriesByPricePageOperationCompleted);
			}
			base.InvokeAsync("SeriesByPricePage", new object[]
			{
				seriesInfo,
				seriesType,
				maxTicker
			}, this.SeriesByPricePageOperationCompleted, userState);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00118240 File Offset: 0x00116640
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSeriesByPricePageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SeriesByPricePageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SeriesByPricePageCompleted(this, new SeriesByPricePageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x001182A0 File Offset: 0x001166A0
		[SoapDocumentMethod("http://tempuri.org/TopBBOTFEX", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopBBOTFEX(string[] seriesList, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopBBOTFEX", new object[]
			{
				seriesList,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x001182EC File Offset: 0x001166EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOTFEXAsync(string[] seriesList, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopBBOTFEXAsync(seriesList, maxTicker, null);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00118308 File Offset: 0x00116708
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOTFEXAsync(string[] seriesList, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopBBOTFEXOperationCompleted == null)
			{
				this.TopBBOTFEXOperationCompleted = new SendOrPostCallback(this.OnTopBBOTFEXOperationCompleted);
			}
			base.InvokeAsync("TopBBOTFEX", new object[]
			{
				seriesList,
				maxTicker
			}, this.TopBBOTFEXOperationCompleted, userState);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00118374 File Offset: 0x00116774
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopBBOTFEXOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopBBOTFEXCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopBBOTFEXCompleted(this, new TopBBOTFEXCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x001183D4 File Offset: 0x001167D4
		[SoapDocumentMethod("http://tempuri.org/TopBBOTFEXad", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopBBOTFEXad(string series, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopBBOTFEXad", new object[]
			{
				series,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00118420 File Offset: 0x00116820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOTFEXadAsync(string series, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopBBOTFEXadAsync(series, maxTicker, null);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0011843C File Offset: 0x0011683C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOTFEXadAsync(string series, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopBBOTFEXadOperationCompleted == null)
			{
				this.TopBBOTFEXadOperationCompleted = new SendOrPostCallback(this.OnTopBBOTFEXadOperationCompleted);
			}
			base.InvokeAsync("TopBBOTFEXad", new object[]
			{
				series,
				maxTicker
			}, this.TopBBOTFEXadOperationCompleted, userState);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x001184A8 File Offset: 0x001168A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopBBOTFEXadOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopBBOTFEXadCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopBBOTFEXadCompleted(this, new TopBBOTFEXadCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00118508 File Offset: 0x00116908
		[SoapDocumentMethod("http://tempuri.org/TFEXTopActiveBBO", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TFEXTopActiveBBO(string viewType, bool isFuture)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TFEXTopActiveBBO", new object[]
			{
				viewType,
				isFuture
			});
			return (string)array[0];
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00118554 File Offset: 0x00116954
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXTopActiveBBOAsync(string viewType, bool isFuture)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TFEXTopActiveBBOAsync(viewType, isFuture, null);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00118570 File Offset: 0x00116970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXTopActiveBBOAsync(string viewType, bool isFuture, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TFEXTopActiveBBOOperationCompleted == null)
			{
				this.TFEXTopActiveBBOOperationCompleted = new SendOrPostCallback(this.OnTFEXTopActiveBBOOperationCompleted);
			}
			base.InvokeAsync("TFEXTopActiveBBO", new object[]
			{
				viewType,
				isFuture
			}, this.TFEXTopActiveBBOOperationCompleted, userState);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x001185DC File Offset: 0x001169DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTFEXTopActiveBBOOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TFEXTopActiveBBOCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TFEXTopActiveBBOCompleted(this, new TFEXTopActiveBBOCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0011863C File Offset: 0x00116A3C
		[SoapDocumentMethod("http://tempuri.org/TFEXTopActiveBBO_MyPort", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TFEXTopActiveBBO_MyPort(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TFEXTopActiveBBO_MyPort", new object[]
			{
				custId
			});
			return (string)array[0];
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00118680 File Offset: 0x00116A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXTopActiveBBO_MyPortAsync(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TFEXTopActiveBBO_MyPortAsync(custId, null);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0011869C File Offset: 0x00116A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXTopActiveBBO_MyPortAsync(string custId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TFEXTopActiveBBO_MyPortOperationCompleted == null)
			{
				this.TFEXTopActiveBBO_MyPortOperationCompleted = new SendOrPostCallback(this.OnTFEXTopActiveBBO_MyPortOperationCompleted);
			}
			base.InvokeAsync("TFEXTopActiveBBO_MyPort", new object[]
			{
				custId
			}, this.TFEXTopActiveBBO_MyPortOperationCompleted, userState);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00118700 File Offset: 0x00116B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTFEXTopActiveBBO_MyPortOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TFEXTopActiveBBO_MyPortCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TFEXTopActiveBBO_MyPortCompleted(this, new TFEXTopActiveBBO_MyPortCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00118760 File Offset: 0x00116B60
		[SoapDocumentMethod("http://tempuri.org/BestProjected_TFEX", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestProjected_TFEX(bool isFutures, string viewType, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestProjected_TFEX", new object[]
			{
				isFutures,
				viewType,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x001187B8 File Offset: 0x00116BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestProjected_TFEXAsync(bool isFutures, string viewType, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestProjected_TFEXAsync(isFutures, viewType, rowPerPage, null);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x001187D4 File Offset: 0x00116BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestProjected_TFEXAsync(bool isFutures, string viewType, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestProjected_TFEXOperationCompleted == null)
			{
				this.BestProjected_TFEXOperationCompleted = new SendOrPostCallback(this.OnBestProjected_TFEXOperationCompleted);
			}
			base.InvokeAsync("BestProjected_TFEX", new object[]
			{
				isFutures,
				viewType,
				rowPerPage
			}, this.BestProjected_TFEXOperationCompleted, userState);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0011884C File Offset: 0x00116C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestProjected_TFEXOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestProjected_TFEXCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestProjected_TFEXCompleted(this, new BestProjected_TFEXCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x001188AC File Offset: 0x00116CAC
		[SoapDocumentMethod("http://tempuri.org/BestBidOfferByList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestBidOfferByList(string seriesListName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestBidOfferByList", new object[]
			{
				seriesListName
			});
			return (string)array[0];
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x001188F0 File Offset: 0x00116CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByListAsync(string seriesListName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestBidOfferByListAsync(seriesListName, null);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0011890C File Offset: 0x00116D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByListAsync(string seriesListName, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestBidOfferByListOperationCompleted == null)
			{
				this.BestBidOfferByListOperationCompleted = new SendOrPostCallback(this.OnBestBidOfferByListOperationCompleted);
			}
			base.InvokeAsync("BestBidOfferByList", new object[]
			{
				seriesListName
			}, this.BestBidOfferByListOperationCompleted, userState);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00118970 File Offset: 0x00116D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestBidOfferByListOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestBidOfferByListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestBidOfferByListCompleted(this, new BestBidOfferByListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x001189D0 File Offset: 0x00116DD0
		[SoapDocumentMethod("http://tempuri.org/BestBidOfferByInstrument", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestBidOfferByInstrument(int orderBookID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestBidOfferByInstrument", new object[]
			{
				orderBookID
			});
			return (string)array[0];
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00118A18 File Offset: 0x00116E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByInstrumentAsync(int orderBookID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestBidOfferByInstrumentAsync(orderBookID, null);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00118A34 File Offset: 0x00116E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByInstrumentAsync(int orderBookID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestBidOfferByInstrumentOperationCompleted == null)
			{
				this.BestBidOfferByInstrumentOperationCompleted = new SendOrPostCallback(this.OnBestBidOfferByInstrumentOperationCompleted);
			}
			base.InvokeAsync("BestBidOfferByInstrument", new object[]
			{
				orderBookID
			}, this.BestBidOfferByInstrumentOperationCompleted, userState);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00118A9C File Offset: 0x00116E9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestBidOfferByInstrumentOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestBidOfferByInstrumentCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestBidOfferByInstrumentCompleted(this, new BestBidOfferByInstrumentCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00118AFC File Offset: 0x00116EFC
		[SoapDocumentMethod("http://tempuri.org/BestBidOfferByOptionsList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestBidOfferByOptionsList(string expDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestBidOfferByOptionsList", new object[]
			{
				expDate
			});
			return (string)array[0];
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00118B40 File Offset: 0x00116F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByOptionsListAsync(string expDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestBidOfferByOptionsListAsync(expDate, null);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00118B5C File Offset: 0x00116F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferByOptionsListAsync(string expDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestBidOfferByOptionsListOperationCompleted == null)
			{
				this.BestBidOfferByOptionsListOperationCompleted = new SendOrPostCallback(this.OnBestBidOfferByOptionsListOperationCompleted);
			}
			base.InvokeAsync("BestBidOfferByOptionsList", new object[]
			{
				expDate
			}, this.BestBidOfferByOptionsListOperationCompleted, userState);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00118BC0 File Offset: 0x00116FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestBidOfferByOptionsListOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestBidOfferByOptionsListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestBidOfferByOptionsListCompleted(this, new BestBidOfferByOptionsListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00118C20 File Offset: 0x00117020
		[SoapDocumentMethod("http://tempuri.org/Get5BidOfferTFEX", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Get5BidOfferTFEX(string series)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("Get5BidOfferTFEX", new object[]
			{
				series
			});
			return (string)array[0];
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00118C64 File Offset: 0x00117064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Get5BidOfferTFEXAsync(string series)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Get5BidOfferTFEXAsync(series, null);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00118C80 File Offset: 0x00117080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Get5BidOfferTFEXAsync(string series, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.Get5BidOfferTFEXOperationCompleted == null)
			{
				this.Get5BidOfferTFEXOperationCompleted = new SendOrPostCallback(this.OnGet5BidOfferTFEXOperationCompleted);
			}
			base.InvokeAsync("Get5BidOfferTFEX", new object[]
			{
				series
			}, this.Get5BidOfferTFEXOperationCompleted, userState);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00118CE4 File Offset: 0x001170E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGet5BidOfferTFEXOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._Get5BidOfferTFEXCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._Get5BidOfferTFEXCompleted(this, new Get5BidOfferTFEXCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00118D44 File Offset: 0x00117144
		[SoapDocumentMethod("http://tempuri.org/GetChartImage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetChartImage(string seriesName, bool showVolumn, int width, int height, int marketCode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetChartImage", new object[]
			{
				seriesName,
				showVolumn,
				width,
				height,
				marketCode
			});
			return (string)array[0];
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00118DB0 File Offset: 0x001171B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChartImageAsync(string seriesName, bool showVolumn, int width, int height, int marketCode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetChartImageAsync(seriesName, showVolumn, width, height, marketCode, null);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00118DD0 File Offset: 0x001171D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChartImageAsync(string seriesName, bool showVolumn, int width, int height, int marketCode, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetChartImageOperationCompleted == null)
			{
				this.GetChartImageOperationCompleted = new SendOrPostCallback(this.OnGetChartImageOperationCompleted);
			}
			base.InvokeAsync("GetChartImage", new object[]
			{
				seriesName,
				showVolumn,
				width,
				height,
				marketCode
			}, this.GetChartImageOperationCompleted, userState);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00118E5C File Offset: 0x0011725C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetChartImageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetChartImageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetChartImageCompleted(this, new GetChartImageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00118EBC File Offset: 0x001172BC
		[SoapDocumentMethod("http://tempuri.org/GetSwitchAccountInfoTFEX", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSwitchAccountInfoTFEX(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetSwitchAccountInfoTFEX", new object[]
			{
				account
			});
			return (string)array[0];
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00118F00 File Offset: 0x00117300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSwitchAccountInfoTFEXAsync(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetSwitchAccountInfoTFEXAsync(account, null);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00118F1C File Offset: 0x0011731C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSwitchAccountInfoTFEXAsync(string account, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetSwitchAccountInfoTFEXOperationCompleted == null)
			{
				this.GetSwitchAccountInfoTFEXOperationCompleted = new SendOrPostCallback(this.OnGetSwitchAccountInfoTFEXOperationCompleted);
			}
			base.InvokeAsync("GetSwitchAccountInfoTFEX", new object[]
			{
				account
			}, this.GetSwitchAccountInfoTFEXOperationCompleted, userState);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00118F80 File Offset: 0x00117380
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetSwitchAccountInfoTFEXOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetSwitchAccountInfoTFEXCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetSwitchAccountInfoTFEXCompleted(this, new GetSwitchAccountInfoTFEXCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00118FE0 File Offset: 0x001173E0
		[SoapDocumentMethod("http://tempuri.org/SeriesSaleByTime", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SeriesSaleByTime(string seriesName, string seriesType, int pageNo, int recordPerPage, int maxTicker, string timeSearch)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SeriesSaleByTime", new object[]
			{
				seriesName,
				seriesType,
				pageNo,
				recordPerPage,
				maxTicker,
				timeSearch
			});
			return (string)array[0];
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0011904C File Offset: 0x0011744C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSaleByTimeAsync(string seriesName, string seriesType, int pageNo, int recordPerPage, int maxTicker, string timeSearch)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SeriesSaleByTimeAsync(seriesName, seriesType, pageNo, recordPerPage, maxTicker, timeSearch, null);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0011907C File Offset: 0x0011747C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSaleByTimeAsync(string seriesName, string seriesType, int pageNo, int recordPerPage, int maxTicker, string timeSearch, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SeriesSaleByTimeOperationCompleted == null)
			{
				this.SeriesSaleByTimeOperationCompleted = new SendOrPostCallback(this.OnSeriesSaleByTimeOperationCompleted);
			}
			base.InvokeAsync("SeriesSaleByTime", new object[]
			{
				seriesName,
				seriesType,
				pageNo,
				recordPerPage,
				maxTicker,
				timeSearch
			}, this.SeriesSaleByTimeOperationCompleted, userState);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00119108 File Offset: 0x00117508
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSeriesSaleByTimeOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SeriesSaleByTimeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SeriesSaleByTimeCompleted(this, new SeriesSaleByTimeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00119168 File Offset: 0x00117568
		[SoapDocumentMethod("http://tempuri.org/SeriesSaleByPrice", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SeriesSaleByPrice(string seriesName, string seriesType, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SeriesSaleByPrice", new object[]
			{
				seriesName,
				seriesType,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x001191B8 File Offset: 0x001175B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSaleByPriceAsync(string seriesName, string seriesType, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SeriesSaleByPriceAsync(seriesName, seriesType, maxTicker, null);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x001191D4 File Offset: 0x001175D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSaleByPriceAsync(string seriesName, string seriesType, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SeriesSaleByPriceOperationCompleted == null)
			{
				this.SeriesSaleByPriceOperationCompleted = new SendOrPostCallback(this.OnSeriesSaleByPriceOperationCompleted);
			}
			base.InvokeAsync("SeriesSaleByPrice", new object[]
			{
				seriesName,
				seriesType,
				maxTicker
			}, this.SeriesSaleByPriceOperationCompleted, userState);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00119244 File Offset: 0x00117644
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSeriesSaleByPriceOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SeriesSaleByPriceCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SeriesSaleByPriceCompleted(this, new SeriesSaleByPriceCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x001192A4 File Offset: 0x001176A4
		[SoapDocumentMethod("http://tempuri.org/StockInPlay", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockInPlay(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockInPlay", new object[]
			{
				seriesName,
				seriesType,
				tickSize,
				TFEXSession,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00119324 File Offset: 0x00117724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayAsync(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockInPlayAsync(seriesName, seriesType, tickSize, TFEXSession, StartPrice, Side, rowPerPage, maxTicker, null);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00119358 File Offset: 0x00117758
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayAsync(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockInPlayOperationCompleted == null)
			{
				this.StockInPlayOperationCompleted = new SendOrPostCallback(this.OnStockInPlayOperationCompleted);
			}
			base.InvokeAsync("StockInPlay", new object[]
			{
				seriesName,
				seriesType,
				tickSize,
				TFEXSession,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			}, this.StockInPlayOperationCompleted, userState);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x001193F8 File Offset: 0x001177F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockInPlayOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockInPlayCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockInPlayCompleted(this, new StockInPlayCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00119458 File Offset: 0x00117858
		[SoapDocumentMethod("http://tempuri.org/StockInPlayAD", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockInPlayAD(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockInPlayAD", new object[]
			{
				seriesName,
				seriesType,
				tickSize,
				TFEXSession,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x001194D8 File Offset: 0x001178D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayADAsync(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockInPlayADAsync(seriesName, seriesType, tickSize, TFEXSession, StartPrice, Side, rowPerPage, maxTicker, null);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0011950C File Offset: 0x0011790C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayADAsync(string seriesName, string seriesType, decimal tickSize, int TFEXSession, decimal StartPrice, string Side, int rowPerPage, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockInPlayADOperationCompleted == null)
			{
				this.StockInPlayADOperationCompleted = new SendOrPostCallback(this.OnStockInPlayADOperationCompleted);
			}
			base.InvokeAsync("StockInPlayAD", new object[]
			{
				seriesName,
				seriesType,
				tickSize,
				TFEXSession,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			}, this.StockInPlayADOperationCompleted, userState);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x001195AC File Offset: 0x001179AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockInPlayADOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockInPlayADCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockInPlayADCompleted(this, new StockInPlayADCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0011960C File Offset: 0x00117A0C
		[SoapDocumentMethod("http://tempuri.org/SeriesSumary", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SeriesSumary(string seriesName, string seriesType, int pageNo, int maxTicker, string timeSearch)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SeriesSumary", new object[]
			{
				seriesName,
				seriesType,
				pageNo,
				maxTicker,
				timeSearch
			});
			return (string)array[0];
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0011966C File Offset: 0x00117A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSumaryAsync(string seriesName, string seriesType, int pageNo, int maxTicker, string timeSearch)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SeriesSumaryAsync(seriesName, seriesType, pageNo, maxTicker, timeSearch, null);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0011968C File Offset: 0x00117A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SeriesSumaryAsync(string seriesName, string seriesType, int pageNo, int maxTicker, string timeSearch, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SeriesSumaryOperationCompleted == null)
			{
				this.SeriesSumaryOperationCompleted = new SendOrPostCallback(this.OnSeriesSumaryOperationCompleted);
			}
			base.InvokeAsync("SeriesSumary", new object[]
			{
				seriesName,
				seriesType,
				pageNo,
				maxTicker,
				timeSearch
			}, this.SeriesSumaryOperationCompleted, userState);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0011970C File Offset: 0x00117B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSeriesSumaryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SeriesSumaryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SeriesSumaryCompleted(this, new SeriesSumaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0011976C File Offset: 0x00117B6C
		[SoapDocumentMethod("http://tempuri.org/TFEXBoardcastMessage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TFEXBoardcastMessage(int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TFEXBoardcastMessage", new object[]
			{
				recordPerPage
			});
			return (string)array[0];
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x001197B4 File Offset: 0x00117BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXBoardcastMessageAsync(int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TFEXBoardcastMessageAsync(recordPerPage, null);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x001197D0 File Offset: 0x00117BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TFEXBoardcastMessageAsync(int recordPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TFEXBoardcastMessageOperationCompleted == null)
			{
				this.TFEXBoardcastMessageOperationCompleted = new SendOrPostCallback(this.OnTFEXBoardcastMessageOperationCompleted);
			}
			base.InvokeAsync("TFEXBoardcastMessage", new object[]
			{
				recordPerPage
			}, this.TFEXBoardcastMessageOperationCompleted, userState);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00119838 File Offset: 0x00117C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTFEXBoardcastMessageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TFEXBoardcastMessageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TFEXBoardcastMessageCompleted(this, new TFEXBoardcastMessageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00119898 File Offset: 0x00117C98
		[SoapDocumentMethod("http://tempuri.org/ViewOrderTransaction", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderTransaction(string id, string senderType, int readType, string account, string stock, string side, string price, string status, long startOrderNo, int rowPerPage, int expression)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderTransaction", new object[]
			{
				id,
				senderType,
				readType,
				account,
				stock,
				side,
				price,
				status,
				startOrderNo,
				rowPerPage,
				expression
			});
			return (string)array[0];
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00119924 File Offset: 0x00117D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderTransactionAsync(string id, string senderType, int readType, string account, string stock, string side, string price, string status, long startOrderNo, int rowPerPage, int expression)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderTransactionAsync(id, senderType, readType, account, stock, side, price, status, startOrderNo, rowPerPage, expression, null);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0011995C File Offset: 0x00117D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderTransactionAsync(string id, string senderType, int readType, string account, string stock, string side, string price, string status, long startOrderNo, int rowPerPage, int expression, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderTransactionOperationCompleted == null)
			{
				this.ViewOrderTransactionOperationCompleted = new SendOrPostCallback(this.OnViewOrderTransactionOperationCompleted);
			}
			base.InvokeAsync("ViewOrderTransaction", new object[]
			{
				id,
				senderType,
				readType,
				account,
				stock,
				side,
				price,
				status,
				startOrderNo,
				rowPerPage,
				expression
			}, this.ViewOrderTransactionOperationCompleted, userState);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00119A08 File Offset: 0x00117E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderTransactionOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderTransactionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderTransactionCompleted(this, new ViewOrderTransactionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00119A68 File Offset: 0x00117E68
		[SoapDocumentMethod("http://tempuri.org/ViewOrderByOrderNo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderByOrderNo(string account, string orderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderByOrderNo", new object[]
			{
				account,
				orderNo
			});
			return (string)array[0];
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00119AB0 File Offset: 0x00117EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderByOrderNoAsync(string account, string orderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderByOrderNoAsync(account, orderNo, null);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00119ACC File Offset: 0x00117ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderByOrderNoAsync(string account, string orderNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderByOrderNoOperationCompleted == null)
			{
				this.ViewOrderByOrderNoOperationCompleted = new SendOrPostCallback(this.OnViewOrderByOrderNoOperationCompleted);
			}
			base.InvokeAsync("ViewOrderByOrderNo", new object[]
			{
				account,
				orderNo
			}, this.ViewOrderByOrderNoOperationCompleted, userState);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00119B34 File Offset: 0x00117F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderByOrderNoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderByOrderNoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderByOrderNoCompleted(this, new ViewOrderByOrderNoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00119B94 File Offset: 0x00117F94
		[SoapDocumentMethod("http://tempuri.org/ViewCustomersCredit", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomersCredit(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomersCredit", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00119BD8 File Offset: 0x00117FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersCreditAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomersCreditAsync(custAccID, null);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00119BF4 File Offset: 0x00117FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersCreditAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomersCreditOperationCompleted == null)
			{
				this.ViewCustomersCreditOperationCompleted = new SendOrPostCallback(this.OnViewCustomersCreditOperationCompleted);
			}
			base.InvokeAsync("ViewCustomersCredit", new object[]
			{
				custAccID
			}, this.ViewCustomersCreditOperationCompleted, userState);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00119C58 File Offset: 0x00118058
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomersCreditOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomersCreditCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomersCreditCompleted(this, new ViewCustomersCreditCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00119CB8 File Offset: 0x001180B8
		[SoapDocumentMethod("http://tempuri.org/ViewCustomersInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomersInfo(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomersInfo", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00119CFC File Offset: 0x001180FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersInfoAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomersInfoAsync(custAccID, null);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00119D18 File Offset: 0x00118118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersInfoAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomersInfoOperationCompleted == null)
			{
				this.ViewCustomersInfoOperationCompleted = new SendOrPostCallback(this.OnViewCustomersInfoOperationCompleted);
			}
			base.InvokeAsync("ViewCustomersInfo", new object[]
			{
				custAccID
			}, this.ViewCustomersInfoOperationCompleted, userState);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00119D7C File Offset: 0x0011817C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomersInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomersInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomersInfoCompleted(this, new ViewCustomersInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00119DDC File Offset: 0x001181DC
		[SoapDocumentMethod("http://tempuri.org/ViewCustomersAll", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomersAll(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomersAll", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00119E20 File Offset: 0x00118220
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersAllAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomersAllAsync(custAccID, null);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00119E3C File Offset: 0x0011823C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersAllAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomersAllOperationCompleted == null)
			{
				this.ViewCustomersAllOperationCompleted = new SendOrPostCallback(this.OnViewCustomersAllOperationCompleted);
			}
			base.InvokeAsync("ViewCustomersAll", new object[]
			{
				custAccID
			}, this.ViewCustomersAllOperationCompleted, userState);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00119EA0 File Offset: 0x001182A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomersAllOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomersAllCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomersAllCompleted(this, new ViewCustomersAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00119F00 File Offset: 0x00118300
		[SoapDocumentMethod("http://tempuri.org/ViewOrderDealData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderDealData(long orderNumber, int startRow, int rowPerPage, int dbType, string ordType, string sendDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderDealData", new object[]
			{
				orderNumber,
				startRow,
				rowPerPage,
				dbType,
				ordType,
				sendDate
			});
			return (string)array[0];
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00119F70 File Offset: 0x00118370
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataAsync(long orderNumber, int startRow, int rowPerPage, int dbType, string ordType, string sendDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderDealDataAsync(orderNumber, startRow, rowPerPage, dbType, ordType, sendDate, null);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00119FA0 File Offset: 0x001183A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataAsync(long orderNumber, int startRow, int rowPerPage, int dbType, string ordType, string sendDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderDealDataOperationCompleted == null)
			{
				this.ViewOrderDealDataOperationCompleted = new SendOrPostCallback(this.OnViewOrderDealDataOperationCompleted);
			}
			base.InvokeAsync("ViewOrderDealData", new object[]
			{
				orderNumber,
				startRow,
				rowPerPage,
				dbType,
				ordType,
				sendDate
			}, this.ViewOrderDealDataOperationCompleted, userState);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0011A030 File Offset: 0x00118430
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderDealDataOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderDealDataCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderDealDataCompleted(this, new ViewOrderDealDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0011A090 File Offset: 0x00118490
		[SoapDocumentMethod("http://tempuri.org/ViewCustomerCreditOnSendBox", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomerCreditOnSendBox(string account, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomerCreditOnSendBox", new object[]
			{
				account,
				stock
			});
			return (string)array[0];
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0011A0D8 File Offset: 0x001184D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerCreditOnSendBoxAsync(string account, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomerCreditOnSendBoxAsync(account, stock, null);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0011A0F4 File Offset: 0x001184F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerCreditOnSendBoxAsync(string account, string stock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomerCreditOnSendBoxOperationCompleted == null)
			{
				this.ViewCustomerCreditOnSendBoxOperationCompleted = new SendOrPostCallback(this.OnViewCustomerCreditOnSendBoxOperationCompleted);
			}
			base.InvokeAsync("ViewCustomerCreditOnSendBox", new object[]
			{
				account,
				stock
			}, this.ViewCustomerCreditOnSendBoxOperationCompleted, userState);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0011A15C File Offset: 0x0011855C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomerCreditOnSendBoxOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomerCreditOnSendBoxCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomerCreditOnSendBoxCompleted(this, new ViewCustomerCreditOnSendBoxCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0011A1BC File Offset: 0x001185BC
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_RiskManagement", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_RiskManagement(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_RiskManagement", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0011A200 File Offset: 0x00118600
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RiskManagementAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_RiskManagementAsync(custAccID, null);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0011A21C File Offset: 0x0011861C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RiskManagementAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_RiskManagementOperationCompleted == null)
			{
				this.ViewCustomer_RiskManagementOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_RiskManagementOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_RiskManagement", new object[]
			{
				custAccID
			}, this.ViewCustomer_RiskManagementOperationCompleted, userState);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0011A280 File Offset: 0x00118680
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_RiskManagementOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_RiskManagementCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_RiskManagementCompleted(this, new ViewCustomer_RiskManagementCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0011A2E0 File Offset: 0x001186E0
		[SoapDocumentMethod("http://tempuri.org/SendTFEXNewOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendTFEXNewOrder(string series, string side, long volume, string price, string account, long publishVolume, string position, string stopPrice, string stopCond, string stopSeries, string Validity, string ValidityDate, string sessionID, string requstID, string pinCode, string authenKey, string TraderID, string localIp, string kimengSession, string kimengLocal, string AppSymbol, string priceType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendTFEXNewOrder", new object[]
			{
				series,
				side,
				volume,
				price,
				account,
				publishVolume,
				position,
				stopPrice,
				stopCond,
				stopSeries,
				Validity,
				ValidityDate,
				sessionID,
				requstID,
				pinCode,
				authenKey,
				TraderID,
				localIp,
				kimengSession,
				kimengLocal,
				AppSymbol,
				priceType
			});
			return (string)array[0];
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0011A3A4 File Offset: 0x001187A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTFEXNewOrderAsync(string series, string side, long volume, string price, string account, long publishVolume, string position, string stopPrice, string stopCond, string stopSeries, string Validity, string ValidityDate, string sessionID, string requstID, string pinCode, string authenKey, string TraderID, string localIp, string kimengSession, string kimengLocal, string AppSymbol, string priceType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendTFEXNewOrderAsync(series, side, volume, price, account, publishVolume, position, stopPrice, stopCond, stopSeries, Validity, ValidityDate, sessionID, requstID, pinCode, authenKey, TraderID, localIp, kimengSession, kimengLocal, AppSymbol, priceType, null);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0011A3F4 File Offset: 0x001187F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTFEXNewOrderAsync(string series, string side, long volume, string price, string account, long publishVolume, string position, string stopPrice, string stopCond, string stopSeries, string Validity, string ValidityDate, string sessionID, string requstID, string pinCode, string authenKey, string TraderID, string localIp, string kimengSession, string kimengLocal, string AppSymbol, string priceType, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendTFEXNewOrderOperationCompleted == null)
			{
				this.SendTFEXNewOrderOperationCompleted = new SendOrPostCallback(this.OnSendTFEXNewOrderOperationCompleted);
			}
			base.InvokeAsync("SendTFEXNewOrder", new object[]
			{
				series,
				side,
				volume,
				price,
				account,
				publishVolume,
				position,
				stopPrice,
				stopCond,
				stopSeries,
				Validity,
				ValidityDate,
				sessionID,
				requstID,
				pinCode,
				authenKey,
				TraderID,
				localIp,
				kimengSession,
				kimengLocal,
				AppSymbol,
				priceType
			}, this.SendTFEXNewOrderOperationCompleted, userState);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0011A4D8 File Offset: 0x001188D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendTFEXNewOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendTFEXNewOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendTFEXNewOrderCompleted(this, new SendTFEXNewOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0011A538 File Offset: 0x00118938
		[SoapDocumentMethod("http://tempuri.org/SendTFEXCancelOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendTFEXCancelOrder(long orderNumber, string entryID, string sendDate, string internetUser, string authenKey, string localIp, string kimengSession, string AppSymbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendTFEXCancelOrder", new object[]
			{
				orderNumber,
				entryID,
				sendDate,
				internetUser,
				authenKey,
				localIp,
				kimengSession,
				AppSymbol
			});
			return (string)array[0];
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0011A5A4 File Offset: 0x001189A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTFEXCancelOrderAsync(long orderNumber, string entryID, string sendDate, string internetUser, string authenKey, string localIp, string kimengSession, string AppSymbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendTFEXCancelOrderAsync(orderNumber, entryID, sendDate, internetUser, authenKey, localIp, kimengSession, AppSymbol, null);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0011A5D8 File Offset: 0x001189D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTFEXCancelOrderAsync(long orderNumber, string entryID, string sendDate, string internetUser, string authenKey, string localIp, string kimengSession, string AppSymbol, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendTFEXCancelOrderOperationCompleted == null)
			{
				this.SendTFEXCancelOrderOperationCompleted = new SendOrPostCallback(this.OnSendTFEXCancelOrderOperationCompleted);
			}
			base.InvokeAsync("SendTFEXCancelOrder", new object[]
			{
				orderNumber,
				entryID,
				sendDate,
				internetUser,
				authenKey,
				localIp,
				kimengSession,
				AppSymbol
			}, this.SendTFEXCancelOrderOperationCompleted, userState);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0011A664 File Offset: 0x00118A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendTFEXCancelOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendTFEXCancelOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendTFEXCancelOrderCompleted(this, new SendTFEXCancelOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0011A6C4 File Offset: 0x00118AC4
		[SoapDocumentMethod("http://tempuri.org/WriteLog", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteLog(string log)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Invoke("WriteLog", new object[]
			{
				log
			});
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0011A6F8 File Offset: 0x00118AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteLogAsync(string log)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.WriteLogAsync(log, null);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0011A714 File Offset: 0x00118B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteLogAsync(string log, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.WriteLogOperationCompleted == null)
			{
				this.WriteLogOperationCompleted = new SendOrPostCallback(this.OnWriteLogOperationCompleted);
			}
			base.InvokeAsync("WriteLog", new object[]
			{
				log
			}, this.WriteLogOperationCompleted, userState);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0011A778 File Offset: 0x00118B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnWriteLogOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._WriteLogCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._WriteLogCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0011A7D4 File Offset: 0x00118BD4
		[SoapDocumentMethod("http://tempuri.org/GetGoldSpot", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetGoldSpot()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetGoldSpot", new object[0]);
			return (string)array[0];
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0011A814 File Offset: 0x00118C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetGoldSpotAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetGoldSpotAsync(null);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0011A830 File Offset: 0x00118C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetGoldSpotAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetGoldSpotOperationCompleted == null)
			{
				this.GetGoldSpotOperationCompleted = new SendOrPostCallback(this.OnGetGoldSpotOperationCompleted);
			}
			base.InvokeAsync("GetGoldSpot", new object[0], this.GetGoldSpotOperationCompleted, userState);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0011A88C File Offset: 0x00118C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetGoldSpotOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetGoldSpotCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetGoldSpotCompleted(this, new GetGoldSpotCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0011A8EC File Offset: 0x00118CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void CancelAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.CancelAsync(userState);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0011A908 File Offset: 0x00118D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsLocalFileSystemWebService(string url)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (url == null || url == string.Empty)
			{
				result = false;
			}
			else
			{
				Uri uri = new Uri(url);
				result = (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0);
			}
			return result;
		}

		// Token: 0x04000AC4 RID: 2756
		private SendOrPostCallback LoadSETindexOperationCompleted;

		// Token: 0x04000AC5 RID: 2757
		private SendOrPostCallback LoadMktStatusOperationCompleted;

		// Token: 0x04000AC6 RID: 2758
		private SendOrPostCallback TFEXInformationOperationCompleted;

		// Token: 0x04000AC7 RID: 2759
		private SendOrPostCallback LoadTFEXInformationOperationCompleted;

		// Token: 0x04000AC8 RID: 2760
		private SendOrPostCallback SeriesStateOperationCompleted;

		// Token: 0x04000AC9 RID: 2761
		private SendOrPostCallback GetTotalMarketValueInfoOperationCompleted;

		// Token: 0x04000ACA RID: 2762
		private SendOrPostCallback SeriesByPricePageOperationCompleted;

		// Token: 0x04000ACB RID: 2763
		private SendOrPostCallback TopBBOTFEXOperationCompleted;

		// Token: 0x04000ACC RID: 2764
		private SendOrPostCallback TopBBOTFEXadOperationCompleted;

		// Token: 0x04000ACD RID: 2765
		private SendOrPostCallback TFEXTopActiveBBOOperationCompleted;

		// Token: 0x04000ACE RID: 2766
		private SendOrPostCallback TFEXTopActiveBBO_MyPortOperationCompleted;

		// Token: 0x04000ACF RID: 2767
		private SendOrPostCallback BestProjected_TFEXOperationCompleted;

		// Token: 0x04000AD0 RID: 2768
		private SendOrPostCallback BestBidOfferByListOperationCompleted;

		// Token: 0x04000AD1 RID: 2769
		private SendOrPostCallback BestBidOfferByInstrumentOperationCompleted;

		// Token: 0x04000AD2 RID: 2770
		private SendOrPostCallback BestBidOfferByOptionsListOperationCompleted;

		// Token: 0x04000AD3 RID: 2771
		private SendOrPostCallback Get5BidOfferTFEXOperationCompleted;

		// Token: 0x04000AD4 RID: 2772
		private SendOrPostCallback GetChartImageOperationCompleted;

		// Token: 0x04000AD5 RID: 2773
		private SendOrPostCallback GetSwitchAccountInfoTFEXOperationCompleted;

		// Token: 0x04000AD6 RID: 2774
		private SendOrPostCallback SeriesSaleByTimeOperationCompleted;

		// Token: 0x04000AD7 RID: 2775
		private SendOrPostCallback SeriesSaleByPriceOperationCompleted;

		// Token: 0x04000AD8 RID: 2776
		private SendOrPostCallback StockInPlayOperationCompleted;

		// Token: 0x04000AD9 RID: 2777
		private SendOrPostCallback StockInPlayADOperationCompleted;

		// Token: 0x04000ADA RID: 2778
		private SendOrPostCallback SeriesSumaryOperationCompleted;

		// Token: 0x04000ADB RID: 2779
		private SendOrPostCallback TFEXBoardcastMessageOperationCompleted;

		// Token: 0x04000ADC RID: 2780
		private SendOrPostCallback ViewOrderTransactionOperationCompleted;

		// Token: 0x04000ADD RID: 2781
		private SendOrPostCallback ViewOrderByOrderNoOperationCompleted;

		// Token: 0x04000ADE RID: 2782
		private SendOrPostCallback ViewCustomersCreditOperationCompleted;

		// Token: 0x04000ADF RID: 2783
		private SendOrPostCallback ViewCustomersInfoOperationCompleted;

		// Token: 0x04000AE0 RID: 2784
		private SendOrPostCallback ViewCustomersAllOperationCompleted;

		// Token: 0x04000AE1 RID: 2785
		private SendOrPostCallback ViewOrderDealDataOperationCompleted;

		// Token: 0x04000AE2 RID: 2786
		private SendOrPostCallback ViewCustomerCreditOnSendBoxOperationCompleted;

		// Token: 0x04000AE3 RID: 2787
		private SendOrPostCallback ViewCustomer_RiskManagementOperationCompleted;

		// Token: 0x04000AE4 RID: 2788
		private SendOrPostCallback SendTFEXNewOrderOperationCompleted;

		// Token: 0x04000AE5 RID: 2789
		private SendOrPostCallback SendTFEXCancelOrderOperationCompleted;

		// Token: 0x04000AE6 RID: 2790
		private SendOrPostCallback WriteLogOperationCompleted;

		// Token: 0x04000AE7 RID: 2791
		private SendOrPostCallback GetGoldSpotOperationCompleted;

		// Token: 0x04000AE8 RID: 2792
		private bool useDefaultCredentialsSetExplicitly;
	}
}
