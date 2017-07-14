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

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200010D RID: 269
	[DebuggerStepThrough, WebServiceBinding(Name = "ServiceSoap", Namespace = "http://tempuri.org/"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class Service : SoapHttpClientProtocol
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x000E9584 File Offset: 0x000E7984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Service() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.Url = Settings.Default.efinTradePlus_ITSNetBusinessWS_Service;
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000E95F4 File Offset: 0x000E79F4
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x000E9620 File Offset: 0x000E7A20
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000E9680 File Offset: 0x000E7A80
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x000E96AC File Offset: 0x000E7AAC
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

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000CB8 RID: 3256 RVA: 0x000E96CC File Offset: 0x000E7ACC
		// (remove) Token: 0x06000CB9 RID: 3257 RVA: 0x000E96F4 File Offset: 0x000E7AF4
		public  SendNewOrderCompletedEventHandler _SendNewOrderCompleted;
		public event SendNewOrderCompletedEventHandler SendNewOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendNewOrderCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendNewOrderCompleted -= value;
            }
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000CBA RID: 3258 RVA: 0x000E971C File Offset: 0x000E7B1C
		// (remove) Token: 0x06000CBB RID: 3259 RVA: 0x000E9744 File Offset: 0x000E7B44
		public SendCancelOrder_AfterCloseFwCompletedEventHandler _SendCancelOrder_AfterCloseFwCompleted;
		public event SendCancelOrder_AfterCloseFwCompletedEventHandler SendCancelOrder_AfterCloseFwCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendCancelOrder_AfterCloseFwCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendCancelOrder_AfterCloseFwCompleted -= value;
            }
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000CBC RID: 3260 RVA: 0x000E976C File Offset: 0x000E7B6C
		// (remove) Token: 0x06000CBD RID: 3261 RVA: 0x000E9794 File Offset: 0x000E7B94
		public SendCancelOrderCompletedEventHandler _SendCancelOrderCompleted;
		public event SendCancelOrderCompletedEventHandler SendCancelOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendCancelOrderCompleted += value;

			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendCancelOrderCompleted -= value;
			
            }
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000CBE RID: 3262 RVA: 0x000E97BC File Offset: 0x000E7BBC
		// (remove) Token: 0x06000CBF RID: 3263 RVA: 0x000E97E4 File Offset: 0x000E7BE4
		public SendEditOrderCompletedEventHandler _SendEditOrderCompleted;
		public event SendEditOrderCompletedEventHandler SendEditOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendEditOrderCompleted += value;

			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendEditOrderCompleted -= value;
			
            }
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000CC0 RID: 3264 RVA: 0x000E980C File Offset: 0x000E7C0C
		// (remove) Token: 0x06000CC1 RID: 3265 RVA: 0x000E9834 File Offset: 0x000E7C34
		public  CountOrderCancelForDumpCompletedEventHandler _CountOrderCancelForDumpCompleted;
		public event CountOrderCancelForDumpCompletedEventHandler CountOrderCancelForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._CountOrderCancelForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._CountOrderCancelForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000CC2 RID: 3266 RVA: 0x000E985C File Offset: 0x000E7C5C
		// (remove) Token: 0x06000CC3 RID: 3267 RVA: 0x000E9884 File Offset: 0x000E7C84
		public ViewCustomerByStockForDumpCompletedEventHandler _ViewCustomerByStockForDumpCompleted;
		public event ViewCustomerByStockForDumpCompletedEventHandler ViewCustomerByStockForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomerByStockForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomerByStockForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000CC4 RID: 3268 RVA: 0x000E98AC File Offset: 0x000E7CAC
		// (remove) Token: 0x06000CC5 RID: 3269 RVA: 0x000E98D4 File Offset: 0x000E7CD4
		public GetBrokerMarginVolumeCompletedEventHandler _GetBrokerMarginVolumeCompleted;
		public event GetBrokerMarginVolumeCompletedEventHandler GetBrokerMarginVolumeCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetBrokerMarginVolumeCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetBrokerMarginVolumeCompleted -= value;
			
            }
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000CC6 RID: 3270 RVA: 0x000E98FC File Offset: 0x000E7CFC
		// (remove) Token: 0x06000CC7 RID: 3271 RVA: 0x000E9924 File Offset: 0x000E7D24
		public VerifyPincode2CompletedEventHandler _VerifyPincode2Completed;
		public event VerifyPincode2CompletedEventHandler VerifyPincode2Completed
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._VerifyPincode2Completed += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._VerifyPincode2Completed -= value;
			
            }
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000CC8 RID: 3272 RVA: 0x000E994C File Offset: 0x000E7D4C
		// (remove) Token: 0x06000CC9 RID: 3273 RVA: 0x000E9974 File Offset: 0x000E7D74
		public ViewBAMessageCompletedEventHandler _ViewBAMessageCompleted;
		public event ViewBAMessageCompletedEventHandler ViewBAMessageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewBAMessageCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewBAMessageCompleted -= value;
			
            }
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06000CCA RID: 3274 RVA: 0x000E999C File Offset: 0x000E7D9C
		// (remove) Token: 0x06000CCB RID: 3275 RVA: 0x000E99C4 File Offset: 0x000E7DC4
		public StockHistoryCompletedEventHandler _StockHistoryCompleted;
		public event StockHistoryCompletedEventHandler StockHistoryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockHistoryCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockHistoryCompleted -= value;
			
            }
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000CCC RID: 3276 RVA: 0x000E99EC File Offset: 0x000E7DEC
		// (remove) Token: 0x06000CCD RID: 3277 RVA: 0x000E9A14 File Offset: 0x000E7E14
		public StockChartCompletedEventHandler _StockChartCompleted;
		public event StockChartCompletedEventHandler StockChartCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockChartCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockChartCompleted -= value;
			
            }
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000CCE RID: 3278 RVA: 0x000E9A3C File Offset: 0x000E7E3C
		// (remove) Token: 0x06000CCF RID: 3279 RVA: 0x000E9A64 File Offset: 0x000E7E64
		public StockHistDataCompletedEventHandler _StockHistDataCompleted;
		public event StockHistDataCompletedEventHandler StockHistDataCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockHistDataCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockHistDataCompleted -= value;
			
            }
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000CD0 RID: 3280 RVA: 0x000E9A8C File Offset: 0x000E7E8C
		// (remove) Token: 0x06000CD1 RID: 3281 RVA: 0x000E9AB4 File Offset: 0x000E7EB4
		public LoadStockNicknameCompletedEventHandler _LoadStockNicknameCompleted;
		public event LoadStockNicknameCompletedEventHandler LoadStockNicknameCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadStockNicknameCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadStockNicknameCompleted -= value;
			
            }
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000CD2 RID: 3282 RVA: 0x000E9ADC File Offset: 0x000E7EDC
		// (remove) Token: 0x06000CD3 RID: 3283 RVA: 0x000E9B04 File Offset: 0x000E7F04
		public SaveStockNicknameCompletedEventHandler _SaveStockNicknameCompleted;
		public event SaveStockNicknameCompletedEventHandler SaveStockNicknameCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveStockNicknameCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveStockNicknameCompleted -= value;
			
            }
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000CD4 RID: 3284 RVA: 0x000E9B2C File Offset: 0x000E7F2C
		// (remove) Token: 0x06000CD5 RID: 3285 RVA: 0x000E9B54 File Offset: 0x000E7F54
		public DeleteStockNicknameCompletedEventHandler _DeleteStockNicknameCompleted;
		public event DeleteStockNicknameCompletedEventHandler DeleteStockNicknameCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._DeleteStockNicknameCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._DeleteStockNicknameCompleted -= value;
			
            }
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000CD6 RID: 3286 RVA: 0x000E9B7C File Offset: 0x000E7F7C
		// (remove) Token: 0x06000CD7 RID: 3287 RVA: 0x000E9BA4 File Offset: 0x000E7FA4
		public LoadStockNicknameExtraCompletedEventHandler _LoadStockNicknameExtraCompleted;
		public event LoadStockNicknameExtraCompletedEventHandler LoadStockNicknameExtraCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadStockNicknameExtraCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadStockNicknameExtraCompleted -= value;
			
            }
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000CD8 RID: 3288 RVA: 0x000E9BCC File Offset: 0x000E7FCC
		// (remove) Token: 0x06000CD9 RID: 3289 RVA: 0x000E9BF4 File Offset: 0x000E7FF4
		public SaveStockNicknameExtraCompletedEventHandler _SaveStockNicknameExtraCompleted;
		public event SaveStockNicknameExtraCompletedEventHandler SaveStockNicknameExtraCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveStockNicknameExtraCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveStockNicknameExtraCompleted -= value;

            }
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000CDA RID: 3290 RVA: 0x000E9C1C File Offset: 0x000E801C
		// (remove) Token: 0x06000CDB RID: 3291 RVA: 0x000E9C44 File Offset: 0x000E8044
		public DeleteStockNicknameExtraCompletedEventHandler _DeleteStockNicknameExtraCompleted;
		public event DeleteStockNicknameExtraCompletedEventHandler DeleteStockNicknameExtraCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._DeleteStockNicknameExtraCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._DeleteStockNicknameExtraCompleted -= value;
			
            }
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000CDC RID: 3292 RVA: 0x000E9C6C File Offset: 0x000E806C
		// (remove) Token: 0x06000CDD RID: 3293 RVA: 0x000E9C94 File Offset: 0x000E8094
		public IntradayChartCompletedEventHandler _IntradayChartCompleted;
		public event IntradayChartCompletedEventHandler IntradayChartCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._IntradayChartCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._IntradayChartCompleted -= value;
			
            }
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000CDE RID: 3294 RVA: 0x000E9CBC File Offset: 0x000E80BC
		// (remove) Token: 0x06000CDF RID: 3295 RVA: 0x000E9CE4 File Offset: 0x000E80E4
		public IntradayIndexChartCompletedEventHandler _IntradayIndexChartCompleted;
		public event IntradayIndexChartCompletedEventHandler IntradayIndexChartCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._IntradayIndexChartCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._IntradayIndexChartCompleted -= value;
			
            }
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000CE0 RID: 3296 RVA: 0x000E9D0C File Offset: 0x000E810C
		// (remove) Token: 0x06000CE1 RID: 3297 RVA: 0x000E9D34 File Offset: 0x000E8134
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

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000CE2 RID: 3298 RVA: 0x000E9D5C File Offset: 0x000E815C
		// (remove) Token: 0x06000CE3 RID: 3299 RVA: 0x000E9D84 File Offset: 0x000E8184
		public GetSetIndexChartImageCompletedEventHandler _GetSetIndexChartImageCompleted;
		public event GetSetIndexChartImageCompletedEventHandler GetSetIndexChartImageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetSetIndexChartImageCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetSetIndexChartImageCompleted -= value;
			
            }
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000CE4 RID: 3300 RVA: 0x000E9DAC File Offset: 0x000E81AC
		// (remove) Token: 0x06000CE5 RID: 3301 RVA: 0x000E9DD4 File Offset: 0x000E81D4
		public GetPortfolioStatAllStockCompletedEventHandler _GetPortfolioStatAllStockCompleted;
		public event GetPortfolioStatAllStockCompletedEventHandler GetPortfolioStatAllStockCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetPortfolioStatAllStockCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetPortfolioStatAllStockCompleted -= value;
			
            }
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000CE6 RID: 3302 RVA: 0x000E9DFC File Offset: 0x000E81FC
		// (remove) Token: 0x06000CE7 RID: 3303 RVA: 0x000E9E24 File Offset: 0x000E8224
		public GetPortfolioStatByStockCompletedEventHandler _GetPortfolioStatByStockCompleted;
		public event GetPortfolioStatByStockCompletedEventHandler GetPortfolioStatByStockCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetPortfolioStatByStockCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetPortfolioStatByStockCompleted -= value;
			
            }
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000CE8 RID: 3304 RVA: 0x000E9E4C File Offset: 0x000E824C
		// (remove) Token: 0x06000CE9 RID: 3305 RVA: 0x000E9E74 File Offset: 0x000E8274
		public SavePushAccountCompletedEventHandler _SavePushAccountCompleted;
		public event SavePushAccountCompletedEventHandler SavePushAccountCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SavePushAccountCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SavePushAccountCompleted -= value;
			
            }
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000CEA RID: 3306 RVA: 0x000E9E9C File Offset: 0x000E829C
		// (remove) Token: 0x06000CEB RID: 3307 RVA: 0x000E9EC4 File Offset: 0x000E82C4
		public SaveStockAlertCompletedEventHandler _SaveStockAlertCompleted;
		public event SaveStockAlertCompletedEventHandler SaveStockAlertCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveStockAlertCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveStockAlertCompleted -= value;
			
            }
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000CEC RID: 3308 RVA: 0x000E9EEC File Offset: 0x000E82EC
		// (remove) Token: 0x06000CED RID: 3309 RVA: 0x000E9F14 File Offset: 0x000E8314
		public SavePortAlertCompletedEventHandler _SavePortAlertCompleted;
		public event SavePortAlertCompletedEventHandler SavePortAlertCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SavePortAlertCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SavePortAlertCompleted -= value;
			
            }
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000CEE RID: 3310 RVA: 0x000E9F3C File Offset: 0x000E833C
		// (remove) Token: 0x06000CEF RID: 3311 RVA: 0x000E9F64 File Offset: 0x000E8364
		public SendAutoTradeCompletedEventHandler _SendAutoTradeCompleted;
		public event SendAutoTradeCompletedEventHandler SendAutoTradeCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendAutoTradeCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendAutoTradeCompleted -= value;
			
            }
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000CF0 RID: 3312 RVA: 0x000E9F8C File Offset: 0x000E838C
		// (remove) Token: 0x06000CF1 RID: 3313 RVA: 0x000E9FB4 File Offset: 0x000E83B4
		public StopOrderRegisterCompletedEventHandler _StopOrderRegisterCompleted;
		public event StopOrderRegisterCompletedEventHandler StopOrderRegisterCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StopOrderRegisterCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StopOrderRegisterCompleted -= value;
			
            }
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000CF2 RID: 3314 RVA: 0x000E9FDC File Offset: 0x000E83DC
		// (remove) Token: 0x06000CF3 RID: 3315 RVA: 0x000EA004 File Offset: 0x000E8404
		public StopOrderCheckDisclaimerCompletedEventHandler _StopOrderCheckDisclaimerCompleted;
		public event StopOrderCheckDisclaimerCompletedEventHandler StopOrderCheckDisclaimerCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StopOrderCheckDisclaimerCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StopOrderCheckDisclaimerCompleted -= value;
			
            }
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000CF4 RID: 3316 RVA: 0x000EA02C File Offset: 0x000E842C
		// (remove) Token: 0x06000CF5 RID: 3317 RVA: 0x000EA054 File Offset: 0x000E8454
		public ViewAutoTradeTransCompletedEventHandler _ViewAutoTradeTransCompleted;
		public event ViewAutoTradeTransCompletedEventHandler ViewAutoTradeTransCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewAutoTradeTransCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewAutoTradeTransCompleted -= value;
			
            }
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000CF6 RID: 3318 RVA: 0x000EA07C File Offset: 0x000E847C
		// (remove) Token: 0x06000CF7 RID: 3319 RVA: 0x000EA0A4 File Offset: 0x000E84A4
		public ViewAutoTradeDCAItemsCompletedEventHandler _ViewAutoTradeDCAItemsCompleted;
		public event ViewAutoTradeDCAItemsCompletedEventHandler ViewAutoTradeDCAItemsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewAutoTradeDCAItemsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewAutoTradeDCAItemsCompleted -= value;
			
            }
		}

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000CF8 RID: 3320 RVA: 0x000EA0CC File Offset: 0x000E84CC
		// (remove) Token: 0x06000CF9 RID: 3321 RVA: 0x000EA0F4 File Offset: 0x000E84F4
		public ViewAutoTradePzItemsCompletedEventHandler _ViewAutoTradePzItemsCompleted;
		public event ViewAutoTradePzItemsCompletedEventHandler ViewAutoTradePzItemsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewAutoTradePzItemsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewAutoTradePzItemsCompleted -= value;
			
            }
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000CFA RID: 3322 RVA: 0x000EA11C File Offset: 0x000E851C
		// (remove) Token: 0x06000CFB RID: 3323 RVA: 0x000EA144 File Offset: 0x000E8544
		public ViewAutoTradeFTSItemsCompletedEventHandler _ViewAutoTradeFTSItemsCompleted;
		public event ViewAutoTradeFTSItemsCompletedEventHandler ViewAutoTradeFTSItemsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewAutoTradeFTSItemsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewAutoTradeFTSItemsCompleted -= value;
			
            }
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000CFC RID: 3324 RVA: 0x000EA16C File Offset: 0x000E856C
		// (remove) Token: 0x06000CFD RID: 3325 RVA: 0x000EA194 File Offset: 0x000E8594
		public GetHolidayCompletedEventHandler _GetHolidayCompleted;
		public event GetHolidayCompletedEventHandler GetHolidayCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetHolidayCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetHolidayCompleted -= value;
			
            }
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000CFE RID: 3326 RVA: 0x000EA1BC File Offset: 0x000E85BC
		// (remove) Token: 0x06000CFF RID: 3327 RVA: 0x000EA1E4 File Offset: 0x000E85E4
		public SaveUserAlertCompletedEventHandler _SaveUserAlertCompleted;
		public event SaveUserAlertCompletedEventHandler SaveUserAlertCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserAlertCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserAlertCompleted -= value;
			
            }
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000D00 RID: 3328 RVA: 0x000EA20C File Offset: 0x000E860C
		// (remove) Token: 0x06000D01 RID: 3329 RVA: 0x000EA234 File Offset: 0x000E8634
		public SaveUserAlert2CompletedEventHandler _SaveUserAlert2Completed;
		public event SaveUserAlert2CompletedEventHandler SaveUserAlert2Completed
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserAlert2Completed += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserAlert2Completed -= value;
			
            }
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000D02 RID: 3330 RVA: 0x000EA25C File Offset: 0x000E865C
		// (remove) Token: 0x06000D03 RID: 3331 RVA: 0x000EA284 File Offset: 0x000E8684
		public GetAlertLogCompletedEventHandler _GetAlertLogCompleted;
		public event GetAlertLogCompletedEventHandler GetAlertLogCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetAlertLogCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetAlertLogCompleted -= value;
			
            }
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000D04 RID: 3332 RVA: 0x000EA2AC File Offset: 0x000E86AC
		// (remove) Token: 0x06000D05 RID: 3333 RVA: 0x000EA2D4 File Offset: 0x000E86D4
		public GetAlertLogByGroupCompletedEventHandler _GetAlertLogByGroupCompleted;
		public event GetAlertLogByGroupCompletedEventHandler GetAlertLogByGroupCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetAlertLogByGroupCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetAlertLogByGroupCompleted -= value;
			
            }
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000D06 RID: 3334 RVA: 0x000EA2FC File Offset: 0x000E86FC
		// (remove) Token: 0x06000D07 RID: 3335 RVA: 0x000EA324 File Offset: 0x000E8724
		public VerifyAlertManagerCompletedEventHandler _VerifyAlertManagerCompleted;
		public event VerifyAlertManagerCompletedEventHandler VerifyAlertManagerCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._VerifyAlertManagerCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._VerifyAlertManagerCompleted -= value;
			
            }
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000D08 RID: 3336 RVA: 0x000EA34C File Offset: 0x000E874C
		// (remove) Token: 0x06000D09 RID: 3337 RVA: 0x000EA374 File Offset: 0x000E8774
		public GetUserAlertCompletedEventHandler _GetUserAlertCompleted;
		public event GetUserAlertCompletedEventHandler GetUserAlertCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetUserAlertCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{

                this._GetUserAlertCompleted -= value;
            }
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000D0A RID: 3338 RVA: 0x000EA39C File Offset: 0x000E879C
		// (remove) Token: 0x06000D0B RID: 3339 RVA: 0x000EA3C4 File Offset: 0x000E87C4
		public GetStockAlertItemsCompletedEventHandler _GetStockAlertItemsCompleted;
		public event GetStockAlertItemsCompletedEventHandler GetStockAlertItemsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetStockAlertItemsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetStockAlertItemsCompleted -= value;
			
            }
		}

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000D0C RID: 3340 RVA: 0x000EA3EC File Offset: 0x000E87EC
		// (remove) Token: 0x06000D0D RID: 3341 RVA: 0x000EA414 File Offset: 0x000E8814
		public GetPortAlertItemsCompletedEventHandler _GetPortAlertItemsCompleted;
		public event GetPortAlertItemsCompletedEventHandler GetPortAlertItemsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetPortAlertItemsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetPortAlertItemsCompleted -= value;
		
            }
		}

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000D0E RID: 3342 RVA: 0x000EA43C File Offset: 0x000E883C
		// (remove) Token: 0x06000D0F RID: 3343 RVA: 0x000EA464 File Offset: 0x000E8864
		public NAVChartCompletedEventHandler _NAVChartCompleted;
		public event NAVChartCompletedEventHandler NAVChartCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._NAVChartCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._NAVChartCompleted -= value;
			
            }
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000D10 RID: 3344 RVA: 0x000EA48C File Offset: 0x000E888C
		// (remove) Token: 0x06000D11 RID: 3345 RVA: 0x000EA4B4 File Offset: 0x000E88B4
		public NAVAdjustmentCompletedEventHandler _NAVAdjustmentCompleted;
		public event NAVAdjustmentCompletedEventHandler NAVAdjustmentCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._NAVAdjustmentCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._NAVAdjustmentCompleted -= value;
			
            }
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06000D12 RID: 3346 RVA: 0x000EA4DC File Offset: 0x000E88DC
		// (remove) Token: 0x06000D13 RID: 3347 RVA: 0x000EA504 File Offset: 0x000E8904
		public GetDataForSmartClickCompletedEventHandler _GetDataForSmartClickCompleted;
		public event GetDataForSmartClickCompletedEventHandler GetDataForSmartClickCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetDataForSmartClickCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetDataForSmartClickCompleted -= value;
			
            }
		}

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06000D14 RID: 3348 RVA: 0x000EA52C File Offset: 0x000E892C
		// (remove) Token: 0x06000D15 RID: 3349 RVA: 0x000EA554 File Offset: 0x000E8954
		public GetOrderFor1ClickCompletedEventHandler _GetOrderFor1ClickCompleted;
		public event GetOrderFor1ClickCompletedEventHandler GetOrderFor1ClickCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetOrderFor1ClickCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetOrderFor1ClickCompleted -= value;
			
            }
		}

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06000D16 RID: 3350 RVA: 0x000EA57C File Offset: 0x000E897C
		// (remove) Token: 0x06000D17 RID: 3351 RVA: 0x000EA5A4 File Offset: 0x000E89A4
		public SaveSummaryMarketDataCompletedEventHandler _SaveSummaryMarketDataCompleted;
		public event SaveSummaryMarketDataCompletedEventHandler SaveSummaryMarketDataCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveSummaryMarketDataCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveSummaryMarketDataCompleted -= value;
			
            }
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06000D18 RID: 3352 RVA: 0x000EA5CC File Offset: 0x000E89CC
		// (remove) Token: 0x06000D19 RID: 3353 RVA: 0x000EA5F4 File Offset: 0x000E89F4
		public GetStockIndicatorCompletedEventHandler _GetStockIndicatorCompleted;
		public event GetStockIndicatorCompletedEventHandler GetStockIndicatorCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetStockIndicatorCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetStockIndicatorCompleted -= value;
			
            }
		}

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06000D1A RID: 3354 RVA: 0x000EA61C File Offset: 0x000E8A1C
		// (remove) Token: 0x06000D1B RID: 3355 RVA: 0x000EA644 File Offset: 0x000E8A44
		public SaveUserConfigCompletedEventHandler _SaveUserConfigCompleted;
		public event SaveUserConfigCompletedEventHandler SaveUserConfigCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserConfigCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserConfigCompleted -= value;
			
            }
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000D1C RID: 3356 RVA: 0x000EA66C File Offset: 0x000E8A6C
		// (remove) Token: 0x06000D1D RID: 3357 RVA: 0x000EA694 File Offset: 0x000E8A94
		public SaveUserConfigAllCompletedEventHandler _SaveUserConfigAllCompleted;
		public event SaveUserConfigAllCompletedEventHandler SaveUserConfigAllCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserConfigAllCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserConfigAllCompleted -= value;
			
            }
		}

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000D1E RID: 3358 RVA: 0x000EA6BC File Offset: 0x000E8ABC
		// (remove) Token: 0x06000D1F RID: 3359 RVA: 0x000EA6E4 File Offset: 0x000E8AE4
		public GetPortEquityCompletedEventHandler _GetPortEquityCompleted;
		public event GetPortEquityCompletedEventHandler GetPortEquityCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetPortEquityCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetPortEquityCompleted -= value;
			
            }
		}

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06000D20 RID: 3360 RVA: 0x000EA70C File Offset: 0x000E8B0C
		// (remove) Token: 0x06000D21 RID: 3361 RVA: 0x000EA734 File Offset: 0x000E8B34
		public SendHeartBeat2CompletedEventHandler _SendHeartBeat2Completed;
		public event SendHeartBeat2CompletedEventHandler SendHeartBeat2Completed
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendHeartBeat2Completed += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendHeartBeat2Completed -= value;
			
            }
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x06000D22 RID: 3362 RVA: 0x000EA75C File Offset: 0x000E8B5C
		// (remove) Token: 0x06000D23 RID: 3363 RVA: 0x000EA784 File Offset: 0x000E8B84
		public SaveUserEfinForwardCompletedEventHandler _SaveUserEfinForwardCompleted;
		public event SaveUserEfinForwardCompletedEventHandler SaveUserEfinForwardCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserEfinForwardCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserEfinForwardCompleted -= value;
			
            }
		}

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06000D24 RID: 3364 RVA: 0x000EA7AC File Offset: 0x000E8BAC
		// (remove) Token: 0x06000D25 RID: 3365 RVA: 0x000EA7D4 File Offset: 0x000E8BD4
		public LoadAllInformationCompletedEventHandler _LoadAllInformationCompleted;
		public event LoadAllInformationCompletedEventHandler LoadAllInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadAllInformationCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadAllInformationCompleted -= value;
			
            }
		}

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06000D26 RID: 3366 RVA: 0x000EA7FC File Offset: 0x000E8BFC
		// (remove) Token: 0x06000D27 RID: 3367 RVA: 0x000EA824 File Offset: 0x000E8C24
		public LoadAllInformationIsoddCompletedEventHandler _LoadAllInformationIsoddCompleted;
		public event LoadAllInformationIsoddCompletedEventHandler LoadAllInformationIsoddCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadAllInformationIsoddCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadAllInformationIsoddCompleted -= value;
			
            }
		}

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x06000D28 RID: 3368 RVA: 0x000EA84C File Offset: 0x000E8C4C
		// (remove) Token: 0x06000D29 RID: 3369 RVA: 0x000EA874 File Offset: 0x000E8C74
		public LoadStockInformationCompletedEventHandler _LoadStockInformationCompleted;
		public event LoadStockInformationCompletedEventHandler LoadStockInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadStockInformationCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadStockInformationCompleted -= value;
			
            }
		}

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x06000D2A RID: 3370 RVA: 0x000EA89C File Offset: 0x000E8C9C
		// (remove) Token: 0x06000D2B RID: 3371 RVA: 0x000EA8C4 File Offset: 0x000E8CC4
		public ReloadSETIndexInfoCompletedEventHandler _ReloadSETIndexInfoCompleted;
		public event ReloadSETIndexInfoCompletedEventHandler ReloadSETIndexInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ReloadSETIndexInfoCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ReloadSETIndexInfoCompleted -= value;
			
            }
		}

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06000D2C RID: 3372 RVA: 0x000EA8EC File Offset: 0x000E8CEC
		// (remove) Token: 0x06000D2D RID: 3373 RVA: 0x000EA914 File Offset: 0x000E8D14
		public LoadMarketInformationCompletedEventHandler _LoadMarketInformationCompleted;
		public event LoadMarketInformationCompletedEventHandler LoadMarketInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadMarketInformationCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadMarketInformationCompleted -= value;
			
            }
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000D2E RID: 3374 RVA: 0x000EA93C File Offset: 0x000E8D3C
		// (remove) Token: 0x06000D2F RID: 3375 RVA: 0x000EA964 File Offset: 0x000E8D64
		public LoadOddLotInformationCompletedEventHandler _LoadOddLotInformationCompleted;
		public event LoadOddLotInformationCompletedEventHandler LoadOddLotInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LoadOddLotInformationCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LoadOddLotInformationCompleted -= value;
			
            }
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06000D30 RID: 3376 RVA: 0x000EA98C File Offset: 0x000E8D8C
		// (remove) Token: 0x06000D31 RID: 3377 RVA: 0x000EA9B4 File Offset: 0x000E8DB4
		public BoardcastMessageCompletedEventHandler _BoardcastMessageCompleted;
		public event BoardcastMessageCompletedEventHandler BoardcastMessageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BoardcastMessageCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BoardcastMessageCompleted -= value;
			
            }
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06000D32 RID: 3378 RVA: 0x000EA9DC File Offset: 0x000E8DDC
		// (remove) Token: 0x06000D33 RID: 3379 RVA: 0x000EAA04 File Offset: 0x000E8E04
		public SendPushMessageCompletedEventHandler _SendPushMessageCompleted;
		public event SendPushMessageCompletedEventHandler SendPushMessageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SendPushMessageCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SendPushMessageCompleted -= value;
			
            }
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06000D34 RID: 3380 RVA: 0x000EAA2C File Offset: 0x000E8E2C
		// (remove) Token: 0x06000D35 RID: 3381 RVA: 0x000EAA54 File Offset: 0x000E8E54
		public BestBidOfferCompletedEventHandler _BestBidOfferCompleted;
		public event BestBidOfferCompletedEventHandler BestBidOfferCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestBidOfferCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestBidOfferCompleted -= value;
			
            }
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06000D36 RID: 3382 RVA: 0x000EAA7C File Offset: 0x000E8E7C
		// (remove) Token: 0x06000D37 RID: 3383 RVA: 0x000EAAA4 File Offset: 0x000E8EA4
		public BestOpenPriceCompletedEventHandler _BestOpenPriceCompleted;
		public event BestOpenPriceCompletedEventHandler BestOpenPriceCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestOpenPriceCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestOpenPriceCompleted -= value;
			
            }
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06000D38 RID: 3384 RVA: 0x000EAACC File Offset: 0x000E8ECC
		// (remove) Token: 0x06000D39 RID: 3385 RVA: 0x000EAAF4 File Offset: 0x000E8EF4
		public BestProjectedCompletedEventHandler _BestProjectedCompleted;
		public event BestProjectedCompletedEventHandler BestProjectedCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._BestProjectedCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._BestProjectedCompleted -= value;
			
            }
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x06000D3A RID: 3386 RVA: 0x000EAB1C File Offset: 0x000E8F1C
		// (remove) Token: 0x06000D3B RID: 3387 RVA: 0x000EAB44 File Offset: 0x000E8F44
		public IndustryStatCompletedEventHandler _IndustryStatCompleted;
		public event IndustryStatCompletedEventHandler IndustryStatCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._IndustryStatCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._IndustryStatCompleted -= value;
			
            }
		}

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06000D3C RID: 3388 RVA: 0x000EAB6C File Offset: 0x000E8F6C
		// (remove) Token: 0x06000D3D RID: 3389 RVA: 0x000EAB94 File Offset: 0x000E8F94
		public TopActiveCompletedEventHandler _TopActiveCompleted;
		public event TopActiveCompletedEventHandler TopActiveCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveCompleted -= value;
			
            }
		}

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06000D3E RID: 3390 RVA: 0x000EABBC File Offset: 0x000E8FBC
		// (remove) Token: 0x06000D3F RID: 3391 RVA: 0x000EABE4 File Offset: 0x000E8FE4
		public TopActiveBBOCompletedEventHandler _TopActiveBBOCompleted;
		public event TopActiveBBOCompletedEventHandler TopActiveBBOCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBOCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBOCompleted -= value;
			
            }
		}

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x06000D40 RID: 3392 RVA: 0x000EAC0C File Offset: 0x000E900C
		// (remove) Token: 0x06000D41 RID: 3393 RVA: 0x000EAC34 File Offset: 0x000E9034
		public TopActiveBBO_BenefitCompletedEventHandler _TopActiveBBO_BenefitCompleted;
		public event TopActiveBBO_BenefitCompletedEventHandler TopActiveBBO_BenefitCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_BenefitCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_BenefitCompleted -= value;
			
            }
		}

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x06000D42 RID: 3394 RVA: 0x000EAC5C File Offset: 0x000E905C
		// (remove) Token: 0x06000D43 RID: 3395 RVA: 0x000EAC84 File Offset: 0x000E9084
		public TopActiveBBO_WarrantCompletedEventHandler _TopActiveBBO_WarrantCompleted;
		public event TopActiveBBO_WarrantCompletedEventHandler TopActiveBBO_WarrantCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_WarrantCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_WarrantCompleted -= value;
			
            }
		}

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x06000D44 RID: 3396 RVA: 0x000EACAC File Offset: 0x000E90AC
		// (remove) Token: 0x06000D45 RID: 3397 RVA: 0x000EACD4 File Offset: 0x000E90D4
		public TopActiveBBO_CMPRCompletedEventHandler _TopActiveBBO_CMPRCompleted;
		public event TopActiveBBO_CMPRCompletedEventHandler TopActiveBBO_CMPRCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_CMPRCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_CMPRCompleted -= value;
			
            }
		}

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x06000D46 RID: 3398 RVA: 0x000EACFC File Offset: 0x000E90FC
		// (remove) Token: 0x06000D47 RID: 3399 RVA: 0x000EAD24 File Offset: 0x000E9124
		public TopActiveBBO_MyPortCompletedEventHandler _TopActiveBBO_MyPortCompleted;
		public event TopActiveBBO_MyPortCompletedEventHandler TopActiveBBO_MyPortCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_MyPortCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_MyPortCompleted -= value;
			
            }
		}

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06000D48 RID: 3400 RVA: 0x000EAD4C File Offset: 0x000E914C
		// (remove) Token: 0x06000D49 RID: 3401 RVA: 0x000EAD74 File Offset: 0x000E9174
		public GetMyPortSymbolListCompletedEventHandler _GetMyPortSymbolListCompleted;
		public event GetMyPortSymbolListCompletedEventHandler GetMyPortSymbolListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetMyPortSymbolListCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetMyPortSymbolListCompleted -= value;
			
            }
		}

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x06000D4A RID: 3402 RVA: 0x000EAD9C File Offset: 0x000E919C
		// (remove) Token: 0x06000D4B RID: 3403 RVA: 0x000EADC4 File Offset: 0x000E91C4
		public TopActiveBBO_DWCompletedEventHandler _TopActiveBBO_DWCompleted;
		public event TopActiveBBO_DWCompletedEventHandler TopActiveBBO_DWCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_DWCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_DWCompleted -= value;
			
            }
		}

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x06000D4C RID: 3404 RVA: 0x000EADEC File Offset: 0x000E91EC
		// (remove) Token: 0x06000D4D RID: 3405 RVA: 0x000EAE14 File Offset: 0x000E9214
		public TopActiveBBO_NewsCompletedEventHandler _TopActiveBBO_NewsCompleted;
		public event TopActiveBBO_NewsCompletedEventHandler TopActiveBBO_NewsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_NewsCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_NewsCompleted -= value;
			
            }
		}

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06000D4E RID: 3406 RVA: 0x000EAE3C File Offset: 0x000E923C
		// (remove) Token: 0x06000D4F RID: 3407 RVA: 0x000EAE64 File Offset: 0x000E9264
		public TopActiveBBO_TurnOverCompletedEventHandler _TopActiveBBO_TurnOverCompleted;
		public event TopActiveBBO_TurnOverCompletedEventHandler TopActiveBBO_TurnOverCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_TurnOverCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_TurnOverCompleted -= value;
			
            }
		}

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06000D50 RID: 3408 RVA: 0x000EAE8C File Offset: 0x000E928C
		// (remove) Token: 0x06000D51 RID: 3409 RVA: 0x000EAEB4 File Offset: 0x000E92B4
		public TopActiveBBO_SectorCompletedEventHandler _TopActiveBBO_SectorCompleted;
		public event TopActiveBBO_SectorCompletedEventHandler TopActiveBBO_SectorCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopActiveBBO_SectorCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopActiveBBO_SectorCompleted -= value;
			
            }
		}

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x06000D52 RID: 3410 RVA: 0x000EAEDC File Offset: 0x000E92DC
		// (remove) Token: 0x06000D53 RID: 3411 RVA: 0x000EAF04 File Offset: 0x000E9304
		public InvestorTypeCompletedEventHandler _InvestorTypeCompleted;
		public event InvestorTypeCompletedEventHandler InvestorTypeCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._InvestorTypeCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._InvestorTypeCompleted -= value;
			
            }
		}

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x06000D54 RID: 3412 RVA: 0x000EAF2C File Offset: 0x000E932C
		// (remove) Token: 0x06000D55 RID: 3413 RVA: 0x000EAF54 File Offset: 0x000E9354
		public MarketIndicatorCompletedEventHandler _MarketIndicatorCompleted;
		public event MarketIndicatorCompletedEventHandler MarketIndicatorCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._MarketIndicatorCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._MarketIndicatorCompleted -= value;
			
            }
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x06000D56 RID: 3414 RVA: 0x000EAF7C File Offset: 0x000E937C
		// (remove) Token: 0x06000D57 RID: 3415 RVA: 0x000EAFA4 File Offset: 0x000E93A4
		public SaleByPriceCompletedEventHandler _SaleByPriceCompleted;
		public event SaleByPriceCompletedEventHandler SaleByPriceCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaleByPriceCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaleByPriceCompleted -= value;
			
            }
		}

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06000D58 RID: 3416 RVA: 0x000EAFCC File Offset: 0x000E93CC
		// (remove) Token: 0x06000D59 RID: 3417 RVA: 0x000EAFF4 File Offset: 0x000E93F4
		public SectorStatCompletedEventHandler _SectorStatCompleted;
		public event SectorStatCompletedEventHandler SectorStatCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SectorStatCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SectorStatCompleted -= value;
			
            }
		}

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x06000D5A RID: 3418 RVA: 0x000EB01C File Offset: 0x000E941C
		// (remove) Token: 0x06000D5B RID: 3419 RVA: 0x000EB044 File Offset: 0x000E9444
		public SectorStatForDumpCompletedEventHandler _SectorStatForDumpCompleted;
		public event SectorStatForDumpCompletedEventHandler SectorStatForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SectorStatForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SectorStatForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06000D5C RID: 3420 RVA: 0x000EB06C File Offset: 0x000E946C
		// (remove) Token: 0x06000D5D RID: 3421 RVA: 0x000EB094 File Offset: 0x000E9494
		public StockStatForDumpCompletedEventHandler _StockStatForDumpCompleted;
		public event StockStatForDumpCompletedEventHandler StockStatForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockStatForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockStatForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06000D5E RID: 3422 RVA: 0x000EB0BC File Offset: 0x000E94BC
		// (remove) Token: 0x06000D5F RID: 3423 RVA: 0x000EB0E4 File Offset: 0x000E94E4
		public GetUserConfigForDumpCompletedEventHandler _GetUserConfigForDumpCompleted;
		public event GetUserConfigForDumpCompletedEventHandler GetUserConfigForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetUserConfigForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetUserConfigForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000D60 RID: 3424 RVA: 0x000EB10C File Offset: 0x000E950C
		// (remove) Token: 0x06000D61 RID: 3425 RVA: 0x000EB134 File Offset: 0x000E9534
		public SaveUserConfigForDumpCompletedEventHandler _SaveUserConfigForDumpCompleted;
		public event SaveUserConfigForDumpCompletedEventHandler SaveUserConfigForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveUserConfigForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveUserConfigForDumpCompleted -= value;
			
            }
		}

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000D62 RID: 3426 RVA: 0x000EB15C File Offset: 0x000E955C
		// (remove) Token: 0x06000D63 RID: 3427 RVA: 0x000EB184 File Offset: 0x000E9584
		public SaleByTime2CompletedEventHandler _SaleByTime2Completed;
		public event SaleByTime2CompletedEventHandler SaleByTime2Completed
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaleByTime2Completed += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaleByTime2Completed -= value;
			
            }
		}

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06000D64 RID: 3428 RVA: 0x000EB1AC File Offset: 0x000E95AC
		// (remove) Token: 0x06000D65 RID: 3429 RVA: 0x000EB1D4 File Offset: 0x000E95D4
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

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x06000D66 RID: 3430 RVA: 0x000EB1FC File Offset: 0x000E95FC
		// (remove) Token: 0x06000D67 RID: 3431 RVA: 0x000EB224 File Offset: 0x000E9624
		public StockByPricePageCompletedEventHandler _StockByPricePageCompleted;
		public event StockByPricePageCompletedEventHandler StockByPricePageCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockByPricePageCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockByPricePageCompleted -= value;
			
            }
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06000D68 RID: 3432 RVA: 0x000EB24C File Offset: 0x000E964C
		// (remove) Token: 0x06000D69 RID: 3433 RVA: 0x000EB274 File Offset: 0x000E9674
		public MarketStatusCompletedEventHandler _MarketStatusCompleted;
		public event MarketStatusCompletedEventHandler MarketStatusCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._MarketStatusCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._MarketStatusCompleted -= value;
			
            }
		}

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x06000D6A RID: 3434 RVA: 0x000EB29C File Offset: 0x000E969C
		// (remove) Token: 0x06000D6B RID: 3435 RVA: 0x000EB2C4 File Offset: 0x000E96C4
		public TopBBOCompletedEventHandler _TopBBOCompleted;
		public event TopBBOCompletedEventHandler TopBBOCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopBBOCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopBBOCompleted -= value;
			
            }
		}

		// Token: 0x1400009A RID: 154
		// (add) Token: 0x06000D6C RID: 3436 RVA: 0x000EB2EC File Offset: 0x000E96EC
		// (remove) Token: 0x06000D6D RID: 3437 RVA: 0x000EB314 File Offset: 0x000E9714
		public TopBBOadCompletedEventHandler _TopBBOadCompleted;
		public event TopBBOadCompletedEventHandler TopBBOadCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._TopBBOadCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._TopBBOadCompleted -= value;
			
            }
		}

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x06000D6E RID: 3438 RVA: 0x000EB33C File Offset: 0x000E973C
		// (remove) Token: 0x06000D6F RID: 3439 RVA: 0x000EB364 File Offset: 0x000E9764
		public ViewOddlotCompletedEventHandler _ViewOddlotCompleted;
		public event ViewOddlotCompletedEventHandler ViewOddlotCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOddlotCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOddlotCompleted -= value;
			
            }
		}

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06000D70 RID: 3440 RVA: 0x000EB38C File Offset: 0x000E978C
		// (remove) Token: 0x06000D71 RID: 3441 RVA: 0x000EB3B4 File Offset: 0x000E97B4
		public Get5BidOfferCompletedEventHandler _Get5BidOfferCompleted;
		public event Get5BidOfferCompletedEventHandler Get5BidOfferCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._Get5BidOfferCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._Get5BidOfferCompleted -= value;
			
            }
		}

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06000D72 RID: 3442 RVA: 0x000EB3DC File Offset: 0x000E97DC
		// (remove) Token: 0x06000D73 RID: 3443 RVA: 0x000EB404 File Offset: 0x000E9804
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

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06000D74 RID: 3444 RVA: 0x000EB42C File Offset: 0x000E982C
		// (remove) Token: 0x06000D75 RID: 3445 RVA: 0x000EB454 File Offset: 0x000E9854
		public ViewOrderHistoryCompletedEventHandler _ViewOrderHistoryCompleted;
		public event ViewOrderHistoryCompletedEventHandler ViewOrderHistoryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderHistoryCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderHistoryCompleted -= value;
			
            }
		}

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06000D76 RID: 3446 RVA: 0x000EB47C File Offset: 0x000E987C
		// (remove) Token: 0x06000D77 RID: 3447 RVA: 0x000EB4A4 File Offset: 0x000E98A4
		public ViewOrdersForDumpCompletedEventHandler _ViewOrdersForDumpCompleted;
		public event ViewOrdersForDumpCompletedEventHandler ViewOrdersForDumpCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrdersForDumpCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrdersForDumpCompleted -= value;
			
            }
		}

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x06000D78 RID: 3448 RVA: 0x000EB4CC File Offset: 0x000E98CC
		// (remove) Token: 0x06000D79 RID: 3449 RVA: 0x000EB4F4 File Offset: 0x000E98F4
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

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x06000D7A RID: 3450 RVA: 0x000EB51C File Offset: 0x000E991C
		// (remove) Token: 0x06000D7B RID: 3451 RVA: 0x000EB544 File Offset: 0x000E9944
		public ViewNewsHeaderCompletedEventHandler _ViewNewsHeaderCompleted;
		public event ViewNewsHeaderCompletedEventHandler ViewNewsHeaderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewNewsHeaderCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewNewsHeaderCompleted -= value;
			
            }
		}

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06000D7C RID: 3452 RVA: 0x000EB56C File Offset: 0x000E996C
		// (remove) Token: 0x06000D7D RID: 3453 RVA: 0x000EB594 File Offset: 0x000E9994
		public ViewNewsStoryCompletedEventHandler _ViewNewsStoryCompleted;
		public event ViewNewsStoryCompletedEventHandler ViewNewsStoryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewNewsStoryCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewNewsStoryCompleted -= value;
			
            }
		}

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000D7E RID: 3454 RVA: 0x000EB5BC File Offset: 0x000E99BC
		// (remove) Token: 0x06000D7F RID: 3455 RVA: 0x000EB5E4 File Offset: 0x000E99E4
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

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000D80 RID: 3456 RVA: 0x000EB60C File Offset: 0x000E9A0C
		// (remove) Token: 0x06000D81 RID: 3457 RVA: 0x000EB634 File Offset: 0x000E9A34
		public ViewCustomerCreditOnSendBox_FreewillCompletedEventHandler _ViewCustomerCreditOnSendBox_FreewillCompleted;
		public event ViewCustomerCreditOnSendBox_FreewillCompletedEventHandler ViewCustomerCreditOnSendBox_FreewillCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomerCreditOnSendBox_FreewillCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomerCreditOnSendBox_FreewillCompleted -= value;
			
            }
		}

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06000D82 RID: 3458 RVA: 0x000EB65C File Offset: 0x000E9A5C
		// (remove) Token: 0x06000D83 RID: 3459 RVA: 0x000EB684 File Offset: 0x000E9A84
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

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x06000D84 RID: 3460 RVA: 0x000EB6AC File Offset: 0x000E9AAC
		// (remove) Token: 0x06000D85 RID: 3461 RVA: 0x000EB6D4 File Offset: 0x000E9AD4
		public GetSwitchAccountInfoCompletedEventHandler _GetSwitchAccountInfoCompleted;
		public event GetSwitchAccountInfoCompletedEventHandler GetSwitchAccountInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetSwitchAccountInfoCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetSwitchAccountInfoCompleted -= value;
			
            }
		}

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x06000D86 RID: 3462 RVA: 0x000EB6FC File Offset: 0x000E9AFC
		// (remove) Token: 0x06000D87 RID: 3463 RVA: 0x000EB724 File Offset: 0x000E9B24
		public ViewCustomer_MobileReportAllCompletedEventHandler _ViewCustomer_MobileReportAllCompleted;
		public event ViewCustomer_MobileReportAllCompletedEventHandler ViewCustomer_MobileReportAllCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_MobileReportAllCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_MobileReportAllCompleted -= value;
			
            }
		}

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x06000D88 RID: 3464 RVA: 0x000EB74C File Offset: 0x000E9B4C
		// (remove) Token: 0x06000D89 RID: 3465 RVA: 0x000EB774 File Offset: 0x000E9B74
		public ViewCustomer_OrdersConfirmsCompletedEventHandler _ViewCustomer_OrdersConfirmsCompleted;
		public event ViewCustomer_OrdersConfirmsCompletedEventHandler ViewCustomer_OrdersConfirmsCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_OrdersConfirmsCompleted -= value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_OrdersConfirmsCompleted -= value;
			
            }
		}

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x06000D8A RID: 3466 RVA: 0x000EB79C File Offset: 0x000E9B9C
		// (remove) Token: 0x06000D8B RID: 3467 RVA: 0x000EB7C4 File Offset: 0x000E9BC4
		public ViewCustomer_CreditPositionCompletedEventHandler _ViewCustomer_CreditPositionCompleted;
		public event ViewCustomer_CreditPositionCompletedEventHandler ViewCustomer_CreditPositionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_CreditPositionCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_CreditPositionCompleted -= value;
			
            }
		}

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06000D8C RID: 3468 RVA: 0x000EB7EC File Offset: 0x000E9BEC
		// (remove) Token: 0x06000D8D RID: 3469 RVA: 0x000EB814 File Offset: 0x000E9C14
		public ViewCustomer_ProjectedProfitLossCompletedEventHandler _ViewCustomer_ProjectedProfitLossCompleted;
		public event ViewCustomer_ProjectedProfitLossCompletedEventHandler ViewCustomer_ProjectedProfitLossCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_ProjectedProfitLossCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_ProjectedProfitLossCompleted -= value;
			
            }
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000D8E RID: 3470 RVA: 0x000EB83C File Offset: 0x000E9C3C
		// (remove) Token: 0x06000D8F RID: 3471 RVA: 0x000EB864 File Offset: 0x000E9C64
		public ViewCustomer_FScoreAnalysisCompletedEventHandler _ViewCustomer_FScoreAnalysisCompleted;
		public event ViewCustomer_FScoreAnalysisCompletedEventHandler ViewCustomer_FScoreAnalysisCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_FScoreAnalysisCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_FScoreAnalysisCompleted -= value;
			
            }
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x06000D90 RID: 3472 RVA: 0x000EB88C File Offset: 0x000E9C8C
		// (remove) Token: 0x06000D91 RID: 3473 RVA: 0x000EB8B4 File Offset: 0x000E9CB4
		public ViewCustomer_BetaAnalysisCompletedEventHandler _ViewCustomer_BetaAnalysisCompleted;
		public event ViewCustomer_BetaAnalysisCompletedEventHandler ViewCustomer_BetaAnalysisCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_BetaAnalysisCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_BetaAnalysisCompleted -= value;
			
            }
		}

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x06000D92 RID: 3474 RVA: 0x000EB8DC File Offset: 0x000E9CDC
		// (remove) Token: 0x06000D93 RID: 3475 RVA: 0x000EB904 File Offset: 0x000E9D04
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

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x06000D94 RID: 3476 RVA: 0x000EB92C File Offset: 0x000E9D2C
		// (remove) Token: 0x06000D95 RID: 3477 RVA: 0x000EB954 File Offset: 0x000E9D54
		public ViewCustomer_RiskManagement_SaveValueCompletedEventHandler _ViewCustomer_RiskManagement_SaveValueCompleted;
		public event ViewCustomer_RiskManagement_SaveValueCompletedEventHandler ViewCustomer_RiskManagement_SaveValueCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_RiskManagement_SaveValueCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_RiskManagement_SaveValueCompleted -= value;
			
            }
		}

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x06000D96 RID: 3478 RVA: 0x000EB97C File Offset: 0x000E9D7C
		// (remove) Token: 0x06000D97 RID: 3479 RVA: 0x000EB9A4 File Offset: 0x000E9DA4
		public ViewCustomer_RealizeProfitLossCompletedEventHandler _ViewCustomer_RealizeProfitLossCompleted;
		public event ViewCustomer_RealizeProfitLossCompletedEventHandler ViewCustomer_RealizeProfitLossCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_RealizeProfitLossCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_RealizeProfitLossCompleted -= value;
			
            }
		}

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x06000D98 RID: 3480 RVA: 0x000EB9CC File Offset: 0x000E9DCC
		// (remove) Token: 0x06000D99 RID: 3481 RVA: 0x000EB9F4 File Offset: 0x000E9DF4
		public ViewCustomer_SummaryCompletedEventHandler _ViewCustomer_SummaryCompleted;
		public event ViewCustomer_SummaryCompletedEventHandler ViewCustomer_SummaryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_SummaryCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_SummaryCompleted -= value;
			
            }
		}

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x06000D9A RID: 3482 RVA: 0x000EBA1C File Offset: 0x000E9E1C
		// (remove) Token: 0x06000D9B RID: 3483 RVA: 0x000EBA44 File Offset: 0x000E9E44
		public ViewCustomer_ConfirmSummaryCompletedEventHandler _ViewCustomer_ConfirmSummaryCompleted;
		public event ViewCustomer_ConfirmSummaryCompletedEventHandler ViewCustomer_ConfirmSummaryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_ConfirmSummaryCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_ConfirmSummaryCompleted -= value;
			
            }
		}

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x06000D9C RID: 3484 RVA: 0x000EBA6C File Offset: 0x000E9E6C
		// (remove) Token: 0x06000D9D RID: 3485 RVA: 0x000EBA94 File Offset: 0x000E9E94
		public ViewCustomer_ConfirmCompletedEventHandler _ViewCustomer_ConfirmCompleted;
		public event ViewCustomer_ConfirmCompletedEventHandler ViewCustomer_ConfirmCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_ConfirmCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_ConfirmCompleted -= value;
			
            }
		}

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x06000D9E RID: 3486 RVA: 0x000EBABC File Offset: 0x000E9EBC
		// (remove) Token: 0x06000D9F RID: 3487 RVA: 0x000EBAE4 File Offset: 0x000E9EE4
		public ViewCustomer_ConfirmByDealIDCompletedEventHandler _ViewCustomer_ConfirmByDealIDCompleted;
		public event ViewCustomer_ConfirmByDealIDCompletedEventHandler ViewCustomer_ConfirmByDealIDCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_ConfirmByDealIDCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_ConfirmByDealIDCompleted -= value;
			
            }
		}

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x06000DA0 RID: 3488 RVA: 0x000EBB0C File Offset: 0x000E9F0C
		// (remove) Token: 0x06000DA1 RID: 3489 RVA: 0x000EBB34 File Offset: 0x000E9F34
		public ViewCustomer_ConfirmByStockCompletedEventHandler _ViewCustomer_ConfirmByStockCompleted;
		public event ViewCustomer_ConfirmByStockCompletedEventHandler ViewCustomer_ConfirmByStockCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewCustomer_ConfirmByStockCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewCustomer_ConfirmByStockCompleted -= value;
			
            }
		}

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x06000DA2 RID: 3490 RVA: 0x000EBB5C File Offset: 0x000E9F5C
		// (remove) Token: 0x06000DA3 RID: 3491 RVA: 0x000EBB84 File Offset: 0x000E9F84
		public ViewOrderInfo_AfterCloseFwCompletedEventHandler _ViewOrderInfo_AfterCloseFwCompleted;
		public event ViewOrderInfo_AfterCloseFwCompletedEventHandler ViewOrderInfo_AfterCloseFwCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderInfo_AfterCloseFwCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderInfo_AfterCloseFwCompleted -= value;
			
            }
		}

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x06000DA4 RID: 3492 RVA: 0x000EBBAC File Offset: 0x000E9FAC
		// (remove) Token: 0x06000DA5 RID: 3493 RVA: 0x000EBBD4 File Offset: 0x000E9FD4
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

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x06000DA6 RID: 3494 RVA: 0x000EBBFC File Offset: 0x000E9FFC
		// (remove) Token: 0x06000DA7 RID: 3495 RVA: 0x000EBC24 File Offset: 0x000EA024
		public ViewOrderDealDataHistoryCompletedEventHandler _ViewOrderDealDataHistoryCompleted;
		public event ViewOrderDealDataHistoryCompletedEventHandler ViewOrderDealDataHistoryCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ViewOrderDealDataHistoryCompleted += value;
			
            
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ViewOrderDealDataHistoryCompleted -= value;
			
            }
		}

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x06000DA8 RID: 3496 RVA: 0x000EBC4C File Offset: 0x000EA04C
		// (remove) Token: 0x06000DA9 RID: 3497 RVA: 0x000EBC74 File Offset: 0x000EA074
		public GetCometInfoCompletedEventHandler _GetCometInfoCompleted;
		public event GetCometInfoCompletedEventHandler GetCometInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetCometInfoCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetCometInfoCompleted -= value;
			
            }
		}

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x06000DAA RID: 3498 RVA: 0x000EBC9C File Offset: 0x000EA09C
		// (remove) Token: 0x06000DAB RID: 3499 RVA: 0x000EBCC4 File Offset: 0x000EA0C4
		public GetTunnelConfigCompletedEventHandler _GetTunnelConfigCompleted;
		public event GetTunnelConfigCompletedEventHandler GetTunnelConfigCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetTunnelConfigCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetTunnelConfigCompleted -= value;
			
            }
		}

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x06000DAC RID: 3500 RVA: 0x000EBCEC File Offset: 0x000EA0EC
		// (remove) Token: 0x06000DAD RID: 3501 RVA: 0x000EBD14 File Offset: 0x000EA114
		public GetTunnelCompletedEventHandler _GetTunnelCompleted;
		public event GetTunnelCompletedEventHandler GetTunnelCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetTunnelCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetTunnelCompleted -= value;
			
            }
		}

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x06000DAE RID: 3502 RVA: 0x000EBD3C File Offset: 0x000EA13C
		// (remove) Token: 0x06000DAF RID: 3503 RVA: 0x000EBD64 File Offset: 0x000EA164
        public VerifyOrderCompletedEventHandler _VerifyOrderCompleted;
		public event VerifyOrderCompletedEventHandler VerifyOrderCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._VerifyOrderCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._VerifyOrderCompleted -= value;
			
            }
		}

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x06000DB0 RID: 3504 RVA: 0x000EBD8C File Offset: 0x000EA18C
		// (remove) Token: 0x06000DB1 RID: 3505 RVA: 0x000EBDB4 File Offset: 0x000EA1B4
		public  VerifyOrderFwCompletedEventHandler _VerifyOrderFwCompleted;
		public event VerifyOrderFwCompletedEventHandler VerifyOrderFwCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._VerifyOrderFwCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._VerifyOrderFwCompleted -= value;
			
            }
		}

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x06000DB2 RID: 3506 RVA: 0x000EBDDC File Offset: 0x000EA1DC
		// (remove) Token: 0x06000DB3 RID: 3507 RVA: 0x000EBE04 File Offset: 0x000EA204
		public VerifyOrderMktCompletedEventHandler _VerifyOrderMktCompleted;
		public event VerifyOrderMktCompletedEventHandler VerifyOrderMktCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._VerifyOrderMktCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._VerifyOrderMktCompleted -= value;
			
            }
		}

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x06000DB4 RID: 3508 RVA: 0x000EBE2C File Offset: 0x000EA22C
		// (remove) Token: 0x06000DB5 RID: 3509 RVA: 0x000EBE54 File Offset: 0x000EA254
		public GetMainInfoCompletedEventHandler _GetMainInfoCompleted;
		public event GetMainInfoCompletedEventHandler GetMainInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetMainInfoCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetMainInfoCompleted -= value;
			
            }
		}

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x06000DB6 RID: 3510 RVA: 0x000EBE7C File Offset: 0x000EA27C
		// (remove) Token: 0x06000DB7 RID: 3511 RVA: 0x000EBEA4 File Offset: 0x000EA2A4
		public UserAuthenCompletedEventHandler _UserAuthenCompleted;
		public event UserAuthenCompletedEventHandler UserAuthenCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._UserAuthenCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._UserAuthenCompleted -= value;
			
            }
		}

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06000DB8 RID: 3512 RVA: 0x000EBECC File Offset: 0x000EA2CC
		// (remove) Token: 0x06000DB9 RID: 3513 RVA: 0x000EBEF4 File Offset: 0x000EA2F4
		public ClearEfinSessionCompletedEventHandler _ClearEfinSessionCompleted;
		public event ClearEfinSessionCompletedEventHandler ClearEfinSessionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ClearEfinSessionCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ClearEfinSessionCompleted -= value;
			
            }
		}

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06000DBA RID: 3514 RVA: 0x000EBF1C File Offset: 0x000EA31C
		// (remove) Token: 0x06000DBB RID: 3515 RVA: 0x000EBF44 File Offset: 0x000EA344
		public  GetUrlClientCompletedEventHandler _GetUrlClientCompleted;
		public event GetUrlClientCompletedEventHandler GetUrlClientCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._GetUrlClientCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._GetUrlClientCompleted -= value;
			
            }
		}

		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06000DBC RID: 3516 RVA: 0x000EBF6C File Offset: 0x000EA36C
		// (remove) Token: 0x06000DBD RID: 3517 RVA: 0x000EBF94 File Offset: 0x000EA394
		public LogoutCompletedEventHandler _LogoutCompleted;
		public event LogoutCompletedEventHandler LogoutCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LogoutCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LogoutCompleted -= value;
			
            }
		}

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x06000DBE RID: 3518 RVA: 0x000EBFBC File Offset: 0x000EA3BC
		// (remove) Token: 0x06000DBF RID: 3519 RVA: 0x000EBFE4 File Offset: 0x000EA3E4
		public LogoutADCompletedEventHandler _LogoutADCompleted;
		public event LogoutADCompletedEventHandler LogoutADCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._LogoutADCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._LogoutADCompleted -= value;
			
            }
		}

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x06000DC0 RID: 3520 RVA: 0x000EC00C File Offset: 0x000EA40C
		// (remove) Token: 0x06000DC1 RID: 3521 RVA: 0x000EC034 File Offset: 0x000EA434
		public ChangeCustomerPasswordCompletedEventHandler _ChangeCustomerPasswordCompleted;
		public event ChangeCustomerPasswordCompletedEventHandler ChangeCustomerPasswordCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ChangeCustomerPasswordCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ChangeCustomerPasswordCompleted -= value;
			
            }
		}

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06000DC2 RID: 3522 RVA: 0x000EC05C File Offset: 0x000EA45C
		// (remove) Token: 0x06000DC3 RID: 3523 RVA: 0x000EC084 File Offset: 0x000EA484
		public ChangeTraderPasswordCompletedEventHandler _ChangeTraderPasswordCompleted;
		public event ChangeTraderPasswordCompletedEventHandler ChangeTraderPasswordCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._ChangeTraderPasswordCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._ChangeTraderPasswordCompleted -= value;
			
            }
		}

		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x06000DC4 RID: 3524 RVA: 0x000EC0AC File Offset: 0x000EA4AC
		// (remove) Token: 0x06000DC5 RID: 3525 RVA: 0x000EC0D4 File Offset: 0x000EA4D4
		public StockThresholdInformationCompletedEventHandler _StockThresholdInformationCompleted;
		public event StockThresholdInformationCompletedEventHandler StockThresholdInformationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._StockThresholdInformationCompleted += value;
			
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._StockThresholdInformationCompleted -= value;
			
            }
		}

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06000DC6 RID: 3526 RVA: 0x000EC0FC File Offset: 0x000EA4FC
		// (remove) Token: 0x06000DC7 RID: 3527 RVA: 0x000EC124 File Offset: 0x000EA524
		public  SaveStockThresholdCompletedEventHandler _SaveStockThresholdCompleted;
		public event SaveStockThresholdCompletedEventHandler SaveStockThresholdCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                this._SaveStockThresholdCompleted += value;
            }
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._SaveStockThresholdCompleted -= value;
			
            }
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000EC14C File Offset: 0x000EA54C
		[SoapDocumentMethod("http://tempuri.org/SendNewOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendNewOrder(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendNewOrder", new object[]
			{
				message
			});
			return (string)array[0];
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000EC190 File Offset: 0x000EA590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendNewOrderAsync(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendNewOrderAsync(message, null);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000EC1AC File Offset: 0x000EA5AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendNewOrderAsync(string message, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendNewOrderOperationCompleted == null)
			{
				this.SendNewOrderOperationCompleted = new SendOrPostCallback(this.OnSendNewOrderOperationCompleted);
			}
			base.InvokeAsync("SendNewOrder", new object[]
			{
				message
			}, this.SendNewOrderOperationCompleted, userState);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000EC210 File Offset: 0x000EA610
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendNewOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendNewOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendNewOrderCompleted(this, new SendNewOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x000EC270 File Offset: 0x000EA670
		[SoapDocumentMethod("http://tempuri.org/SendCancelOrder_AfterCloseFw", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendCancelOrder_AfterCloseFw(string orderDate, string orderTime, long orderNumber, string endtryId, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendCancelOrder_AfterCloseFw", new object[]
			{
				orderDate,
				orderTime,
				orderNumber,
				endtryId,
				authenKey
			});
			return (string)array[0];
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000EC2CC File Offset: 0x000EA6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendCancelOrder_AfterCloseFwAsync(string orderDate, string orderTime, long orderNumber, string endtryId, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendCancelOrder_AfterCloseFwAsync(orderDate, orderTime, orderNumber, endtryId, authenKey, null);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000EC2EC File Offset: 0x000EA6EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendCancelOrder_AfterCloseFwAsync(string orderDate, string orderTime, long orderNumber, string endtryId, string authenKey, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendCancelOrder_AfterCloseFwOperationCompleted == null)
			{
				this.SendCancelOrder_AfterCloseFwOperationCompleted = new SendOrPostCallback(this.OnSendCancelOrder_AfterCloseFwOperationCompleted);
			}
			base.InvokeAsync("SendCancelOrder_AfterCloseFw", new object[]
			{
				orderDate,
				orderTime,
				orderNumber,
				endtryId,
				authenKey
			}, this.SendCancelOrder_AfterCloseFwOperationCompleted, userState);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000EC368 File Offset: 0x000EA768
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendCancelOrder_AfterCloseFwOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendCancelOrder_AfterCloseFwCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendCancelOrder_AfterCloseFwCompleted(this, new SendCancelOrder_AfterCloseFwCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000EC3C8 File Offset: 0x000EA7C8
		[SoapDocumentMethod("http://tempuri.org/SendCancelOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendCancelOrder(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendCancelOrder", new object[]
			{
				message
			});
			return (string)array[0];
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000EC40C File Offset: 0x000EA80C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendCancelOrderAsync(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendCancelOrderAsync(message, null);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000EC428 File Offset: 0x000EA828
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendCancelOrderAsync(string message, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendCancelOrderOperationCompleted == null)
			{
				this.SendCancelOrderOperationCompleted = new SendOrPostCallback(this.OnSendCancelOrderOperationCompleted);
			}
			base.InvokeAsync("SendCancelOrder", new object[]
			{
				message
			}, this.SendCancelOrderOperationCompleted, userState);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000EC48C File Offset: 0x000EA88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendCancelOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendCancelOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendCancelOrderCompleted(this, new SendCancelOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000EC4EC File Offset: 0x000EA8EC
		[SoapDocumentMethod("http://tempuri.org/SendEditOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendEditOrder(string authenKey, string sessionId, long orderNumber, string entryDate, long volume, string price, string logIn, long pubVol, int trusteeId, string userNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendEditOrder", new object[]
			{
				authenKey,
				sessionId,
				orderNumber,
				entryDate,
				volume,
				price,
				logIn,
				pubVol,
				trusteeId,
				userNo
			});
			return (string)array[0];
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000EC570 File Offset: 0x000EA970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendEditOrderAsync(string authenKey, string sessionId, long orderNumber, string entryDate, long volume, string price, string logIn, long pubVol, int trusteeId, string userNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendEditOrderAsync(authenKey, sessionId, orderNumber, entryDate, volume, price, logIn, pubVol, trusteeId, userNo, null);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000EC5A8 File Offset: 0x000EA9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendEditOrderAsync(string authenKey, string sessionId, long orderNumber, string entryDate, long volume, string price, string logIn, long pubVol, int trusteeId, string userNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendEditOrderOperationCompleted == null)
			{
				this.SendEditOrderOperationCompleted = new SendOrPostCallback(this.OnSendEditOrderOperationCompleted);
			}
			base.InvokeAsync("SendEditOrder", new object[]
			{
				authenKey,
				sessionId,
				orderNumber,
				entryDate,
				volume,
				price,
				logIn,
				pubVol,
				trusteeId,
				userNo
			}, this.SendEditOrderOperationCompleted, userState);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000EC64C File Offset: 0x000EAA4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendEditOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendEditOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendEditOrderCompleted(this, new SendEditOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000EC6AC File Offset: 0x000EAAAC
		[SoapDocumentMethod("http://tempuri.org/CountOrderCancelForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CountOrderCancelForDump(string account, string stock, int trusteeId, string side, string price, long startOrderNo, long endOrderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("CountOrderCancelForDump", new object[]
			{
				account,
				stock,
				trusteeId,
				side,
				price,
				startOrderNo,
				endOrderNo
			});
			return (string)array[0];
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000EC71C File Offset: 0x000EAB1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CountOrderCancelForDumpAsync(string account, string stock, int trusteeId, string side, string price, long startOrderNo, long endOrderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.CountOrderCancelForDumpAsync(account, stock, trusteeId, side, price, startOrderNo, endOrderNo, null);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000EC74C File Offset: 0x000EAB4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CountOrderCancelForDumpAsync(string account, string stock, int trusteeId, string side, string price, long startOrderNo, long endOrderNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.CountOrderCancelForDumpOperationCompleted == null)
			{
				this.CountOrderCancelForDumpOperationCompleted = new SendOrPostCallback(this.OnCountOrderCancelForDumpOperationCompleted);
			}
			base.InvokeAsync("CountOrderCancelForDump", new object[]
			{
				account,
				stock,
				trusteeId,
				side,
				price,
				startOrderNo,
				endOrderNo
			}, this.CountOrderCancelForDumpOperationCompleted, userState);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000EC7DC File Offset: 0x000EABDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCountOrderCancelForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._CountOrderCancelForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._CountOrderCancelForDumpCompleted(this, new CountOrderCancelForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000EC83C File Offset: 0x000EAC3C
		[SoapDocumentMethod("http://tempuri.org/ViewCustomerByStockForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomerByStockForDump(string account, string stock, int trusteeId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomerByStockForDump", new object[]
			{
				account,
				stock,
				trusteeId
			});
			return (string)array[0];
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000EC88C File Offset: 0x000EAC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerByStockForDumpAsync(string account, string stock, int trusteeId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomerByStockForDumpAsync(account, stock, trusteeId, null);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000EC8A8 File Offset: 0x000EACA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerByStockForDumpAsync(string account, string stock, int trusteeId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomerByStockForDumpOperationCompleted == null)
			{
				this.ViewCustomerByStockForDumpOperationCompleted = new SendOrPostCallback(this.OnViewCustomerByStockForDumpOperationCompleted);
			}
			base.InvokeAsync("ViewCustomerByStockForDump", new object[]
			{
				account,
				stock,
				trusteeId
			}, this.ViewCustomerByStockForDumpOperationCompleted, userState);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000EC918 File Offset: 0x000EAD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomerByStockForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomerByStockForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomerByStockForDumpCompleted(this, new ViewCustomerByStockForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000EC978 File Offset: 0x000EAD78
		[SoapDocumentMethod("http://tempuri.org/GetBrokerMarginVolume", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetBrokerMarginVolume(string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetBrokerMarginVolume", new object[]
			{
				stock
			});
			return (string)array[0];
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000EC9BC File Offset: 0x000EADBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetBrokerMarginVolumeAsync(string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetBrokerMarginVolumeAsync(stock, null);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000EC9D8 File Offset: 0x000EADD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetBrokerMarginVolumeAsync(string stock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetBrokerMarginVolumeOperationCompleted == null)
			{
				this.GetBrokerMarginVolumeOperationCompleted = new SendOrPostCallback(this.OnGetBrokerMarginVolumeOperationCompleted);
			}
			base.InvokeAsync("GetBrokerMarginVolume", new object[]
			{
				stock
			}, this.GetBrokerMarginVolumeOperationCompleted, userState);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000ECA3C File Offset: 0x000EAE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetBrokerMarginVolumeOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetBrokerMarginVolumeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetBrokerMarginVolumeCompleted(this, new GetBrokerMarginVolumeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000ECA9C File Offset: 0x000EAE9C
		[SoapDocumentMethod("http://tempuri.org/VerifyPincode2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string VerifyPincode2(string userId, string pincode, string sessionid, string ktzCustMapKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("VerifyPincode2", new object[]
			{
				userId,
				pincode,
				sessionid,
				ktzCustMapKey
			});
			return (string)array[0];
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000ECAEC File Offset: 0x000EAEEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyPincode2Async(string userId, string pincode, string sessionid, string ktzCustMapKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.VerifyPincode2Async(userId, pincode, sessionid, ktzCustMapKey, null);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000ECB0C File Offset: 0x000EAF0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyPincode2Async(string userId, string pincode, string sessionid, string ktzCustMapKey, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.VerifyPincode2OperationCompleted == null)
			{
				this.VerifyPincode2OperationCompleted = new SendOrPostCallback(this.OnVerifyPincode2OperationCompleted);
			}
			base.InvokeAsync("VerifyPincode2", new object[]
			{
				userId,
				pincode,
				sessionid,
				ktzCustMapKey
			}, this.VerifyPincode2OperationCompleted, userState);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000ECB7C File Offset: 0x000EAF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnVerifyPincode2OperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._VerifyPincode2Completed != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._VerifyPincode2Completed(this, new VerifyPincode2CompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000ECBDC File Offset: 0x000EAFDC
		[SoapDocumentMethod("http://tempuri.org/ViewBAMessage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewBAMessage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewBAMessage", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000ECC1C File Offset: 0x000EB01C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewBAMessageAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewBAMessageAsync(null);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000ECC38 File Offset: 0x000EB038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewBAMessageAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewBAMessageOperationCompleted == null)
			{
				this.ViewBAMessageOperationCompleted = new SendOrPostCallback(this.OnViewBAMessageOperationCompleted);
			}
			base.InvokeAsync("ViewBAMessage", new object[0], this.ViewBAMessageOperationCompleted, userState);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000ECC94 File Offset: 0x000EB094
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewBAMessageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewBAMessageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewBAMessageCompleted(this, new ViewBAMessageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000ECCF4 File Offset: 0x000EB0F4
		[SoapDocumentMethod("http://tempuri.org/StockHistory", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockHistory(string stock, string sDate, bool isPageNext, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockHistory", new object[]
			{
				stock,
				sDate,
				isPageNext,
				recordPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000ECD50 File Offset: 0x000EB150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockHistoryAsync(string stock, string sDate, bool isPageNext, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockHistoryAsync(stock, sDate, isPageNext, recordPerPage, null);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000ECD70 File Offset: 0x000EB170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockHistoryAsync(string stock, string sDate, bool isPageNext, int recordPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockHistoryOperationCompleted == null)
			{
				this.StockHistoryOperationCompleted = new SendOrPostCallback(this.OnStockHistoryOperationCompleted);
			}
			base.InvokeAsync("StockHistory", new object[]
			{
				stock,
				sDate,
				isPageNext,
				recordPerPage
			}, this.StockHistoryOperationCompleted, userState);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000ECDEC File Offset: 0x000EB1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockHistoryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockHistoryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockHistoryCompleted(this, new StockHistoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000ECE4C File Offset: 0x000EB24C
		[SoapDocumentMethod("http://tempuri.org/StockChart", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockChart(int stockNo, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockChart", new object[]
			{
				stockNo,
				recordPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000ECEA0 File Offset: 0x000EB2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockChartAsync(int stockNo, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockChartAsync(stockNo, recordPerPage, null);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000ECEBC File Offset: 0x000EB2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockChartAsync(int stockNo, int recordPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockChartOperationCompleted == null)
			{
				this.StockChartOperationCompleted = new SendOrPostCallback(this.OnStockChartOperationCompleted);
			}
			base.InvokeAsync("StockChart", new object[]
			{
				stockNo,
				recordPerPage
			}, this.StockChartOperationCompleted, userState);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000ECF2C File Offset: 0x000EB32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockChartOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockChartCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockChartCompleted(this, new StockChartCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000ECF8C File Offset: 0x000EB38C
		[SoapDocumentMethod("http://tempuri.org/StockHistData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockHistData(string symbol, string startDate, string key)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockHistData", new object[]
			{
				symbol,
				startDate,
				key
			});
			return (string)array[0];
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000ECFD8 File Offset: 0x000EB3D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockHistDataAsync(string symbol, string startDate, string key)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockHistDataAsync(symbol, startDate, key, null);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000ECFF4 File Offset: 0x000EB3F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockHistDataAsync(string symbol, string startDate, string key, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockHistDataOperationCompleted == null)
			{
				this.StockHistDataOperationCompleted = new SendOrPostCallback(this.OnStockHistDataOperationCompleted);
			}
			base.InvokeAsync("StockHistData", new object[]
			{
				symbol,
				startDate,
				key
			}, this.StockHistDataOperationCompleted, userState);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000ED060 File Offset: 0x000EB460
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockHistDataOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockHistDataCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockHistDataCompleted(this, new StockHistDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000ED0C0 File Offset: 0x000EB4C0
		[SoapDocumentMethod("http://tempuri.org/LoadStockNickname", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadStockNickname(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadStockNickname", new object[]
			{
				custId
			});
			return (string)array[0];
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000ED104 File Offset: 0x000EB504
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockNicknameAsync(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadStockNicknameAsync(custId, null);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000ED120 File Offset: 0x000EB520
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockNicknameAsync(string custId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadStockNicknameOperationCompleted == null)
			{
				this.LoadStockNicknameOperationCompleted = new SendOrPostCallback(this.OnLoadStockNicknameOperationCompleted);
			}
			base.InvokeAsync("LoadStockNickname", new object[]
			{
				custId
			}, this.LoadStockNicknameOperationCompleted, userState);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000ED184 File Offset: 0x000EB584
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadStockNicknameOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadStockNicknameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadStockNicknameCompleted(this, new LoadStockNicknameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000ED1E4 File Offset: 0x000EB5E4
		[SoapDocumentMethod("http://tempuri.org/SaveStockNickname", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SaveStockNickname(string custId, string oldStock, string stock, string nickName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveStockNickname", new object[]
			{
				custId,
				oldStock,
				stock,
				nickName
			});
			return (bool)array[0];
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000ED234 File Offset: 0x000EB634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockNicknameAsync(string custId, string oldStock, string stock, string nickName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveStockNicknameAsync(custId, oldStock, stock, nickName, null);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000ED254 File Offset: 0x000EB654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockNicknameAsync(string custId, string oldStock, string stock, string nickName, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveStockNicknameOperationCompleted == null)
			{
				this.SaveStockNicknameOperationCompleted = new SendOrPostCallback(this.OnSaveStockNicknameOperationCompleted);
			}
			base.InvokeAsync("SaveStockNickname", new object[]
			{
				custId,
				oldStock,
				stock,
				nickName
			}, this.SaveStockNicknameOperationCompleted, userState);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000ED2C4 File Offset: 0x000EB6C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveStockNicknameOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveStockNicknameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveStockNicknameCompleted(this, new SaveStockNicknameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000ED324 File Offset: 0x000EB724
		[SoapDocumentMethod("http://tempuri.org/DeleteStockNickname", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteStockNickname(string custId, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("DeleteStockNickname", new object[]
			{
				custId,
				stock
			});
			return (bool)array[0];
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000ED36C File Offset: 0x000EB76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteStockNicknameAsync(string custId, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DeleteStockNicknameAsync(custId, stock, null);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000ED388 File Offset: 0x000EB788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteStockNicknameAsync(string custId, string stock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.DeleteStockNicknameOperationCompleted == null)
			{
				this.DeleteStockNicknameOperationCompleted = new SendOrPostCallback(this.OnDeleteStockNicknameOperationCompleted);
			}
			base.InvokeAsync("DeleteStockNickname", new object[]
			{
				custId,
				stock
			}, this.DeleteStockNicknameOperationCompleted, userState);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000ED3F0 File Offset: 0x000EB7F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDeleteStockNicknameOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._DeleteStockNicknameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._DeleteStockNicknameCompleted(this, new DeleteStockNicknameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000ED450 File Offset: 0x000EB850
		[SoapDocumentMethod("http://tempuri.org/LoadStockNicknameExtra", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadStockNicknameExtra(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadStockNicknameExtra", new object[]
			{
				custId
			});
			return (string)array[0];
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000ED494 File Offset: 0x000EB894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockNicknameExtraAsync(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadStockNicknameExtraAsync(custId, null);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000ED4B0 File Offset: 0x000EB8B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockNicknameExtraAsync(string custId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadStockNicknameExtraOperationCompleted == null)
			{
				this.LoadStockNicknameExtraOperationCompleted = new SendOrPostCallback(this.OnLoadStockNicknameExtraOperationCompleted);
			}
			base.InvokeAsync("LoadStockNicknameExtra", new object[]
			{
				custId
			}, this.LoadStockNicknameExtraOperationCompleted, userState);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000ED514 File Offset: 0x000EB914
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadStockNicknameExtraOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadStockNicknameExtraCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadStockNicknameExtraCompleted(this, new LoadStockNicknameExtraCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000ED574 File Offset: 0x000EB974
		[SoapDocumentMethod("http://tempuri.org/SaveStockNicknameExtra", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SaveStockNicknameExtra(string custId, string oldStock, string stock, string nickName, string type)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveStockNicknameExtra", new object[]
			{
				custId,
				oldStock,
				stock,
				nickName,
				type
			});
			return (bool)array[0];
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000ED5CC File Offset: 0x000EB9CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockNicknameExtraAsync(string custId, string oldStock, string stock, string nickName, string type)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveStockNicknameExtraAsync(custId, oldStock, stock, nickName, type, null);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000ED5EC File Offset: 0x000EB9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockNicknameExtraAsync(string custId, string oldStock, string stock, string nickName, string type, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveStockNicknameExtraOperationCompleted == null)
			{
				this.SaveStockNicknameExtraOperationCompleted = new SendOrPostCallback(this.OnSaveStockNicknameExtraOperationCompleted);
			}
			base.InvokeAsync("SaveStockNicknameExtra", new object[]
			{
				custId,
				oldStock,
				stock,
				nickName,
				type
			}, this.SaveStockNicknameExtraOperationCompleted, userState);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000ED664 File Offset: 0x000EBA64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveStockNicknameExtraOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveStockNicknameExtraCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveStockNicknameExtraCompleted(this, new SaveStockNicknameExtraCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000ED6C4 File Offset: 0x000EBAC4
		[SoapDocumentMethod("http://tempuri.org/DeleteStockNicknameExtra", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteStockNicknameExtra(string custId, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("DeleteStockNicknameExtra", new object[]
			{
				custId,
				stock
			});
			return (bool)array[0];
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000ED70C File Offset: 0x000EBB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteStockNicknameExtraAsync(string custId, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DeleteStockNicknameExtraAsync(custId, stock, null);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x000ED728 File Offset: 0x000EBB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteStockNicknameExtraAsync(string custId, string stock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.DeleteStockNicknameExtraOperationCompleted == null)
			{
				this.DeleteStockNicknameExtraOperationCompleted = new SendOrPostCallback(this.OnDeleteStockNicknameExtraOperationCompleted);
			}
			base.InvokeAsync("DeleteStockNicknameExtra", new object[]
			{
				custId,
				stock
			}, this.DeleteStockNicknameExtraOperationCompleted, userState);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000ED790 File Offset: 0x000EBB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDeleteStockNicknameExtraOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._DeleteStockNicknameExtraCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._DeleteStockNicknameExtraCompleted(this, new DeleteStockNicknameExtraCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000ED7F0 File Offset: 0x000EBBF0
		[SoapDocumentMethod("http://tempuri.org/IntradayChart", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string IntradayChart(int stockNumber, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("IntradayChart", new object[]
			{
				stockNumber,
				authenKey
			});
			return (string)array[0];
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000ED83C File Offset: 0x000EBC3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IntradayChartAsync(int stockNumber, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IntradayChartAsync(stockNumber, authenKey, null);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000ED858 File Offset: 0x000EBC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IntradayChartAsync(int stockNumber, string authenKey, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IntradayChartOperationCompleted == null)
			{
				this.IntradayChartOperationCompleted = new SendOrPostCallback(this.OnIntradayChartOperationCompleted);
			}
			base.InvokeAsync("IntradayChart", new object[]
			{
				stockNumber,
				authenKey
			}, this.IntradayChartOperationCompleted, userState);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000ED8C4 File Offset: 0x000EBCC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnIntradayChartOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._IntradayChartCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._IntradayChartCompleted(this, new IntradayChartCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000ED924 File Offset: 0x000EBD24
		[SoapDocumentMethod("http://tempuri.org/IntradayIndexChart", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string IntradayIndexChart(string symbol, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("IntradayIndexChart", new object[]
			{
				symbol,
				authenKey
			});
			return (string)array[0];
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000ED96C File Offset: 0x000EBD6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IntradayIndexChartAsync(string symbol, string authenKey)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IntradayIndexChartAsync(symbol, authenKey, null);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000ED988 File Offset: 0x000EBD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IntradayIndexChartAsync(string symbol, string authenKey, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IntradayIndexChartOperationCompleted == null)
			{
				this.IntradayIndexChartOperationCompleted = new SendOrPostCallback(this.OnIntradayIndexChartOperationCompleted);
			}
			base.InvokeAsync("IntradayIndexChart", new object[]
			{
				symbol,
				authenKey
			}, this.IntradayIndexChartOperationCompleted, userState);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000ED9F0 File Offset: 0x000EBDF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnIntradayIndexChartOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._IntradayIndexChartCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._IntradayIndexChartCompleted(this, new IntradayIndexChartCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000EDA50 File Offset: 0x000EBE50
		[SoapDocumentMethod("http://tempuri.org/GetChartImage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetChartImage(int stockNumber, bool showVolumn, int width, int height)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetChartImage", new object[]
			{
				stockNumber,
				showVolumn,
				width,
				height
			});
			return (string)array[0];
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000EDAB4 File Offset: 0x000EBEB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChartImageAsync(int stockNumber, bool showVolumn, int width, int height)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetChartImageAsync(stockNumber, showVolumn, width, height, null);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000EDAD4 File Offset: 0x000EBED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChartImageAsync(int stockNumber, bool showVolumn, int width, int height, object userState)
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
				stockNumber,
				showVolumn,
				width,
				height
			}, this.GetChartImageOperationCompleted, userState);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000EDB58 File Offset: 0x000EBF58
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

		// Token: 0x06000E1C RID: 3612 RVA: 0x000EDBB8 File Offset: 0x000EBFB8
		[SoapDocumentMethod("http://tempuri.org/GetSetIndexChartImage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSetIndexChartImage(string symbol, double prior, int width, int height)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetSetIndexChartImage", new object[]
			{
				symbol,
				prior,
				width,
				height
			});
			return (string)array[0];
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000EDC18 File Offset: 0x000EC018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSetIndexChartImageAsync(string symbol, double prior, int width, int height)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetSetIndexChartImageAsync(symbol, prior, width, height, null);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000EDC38 File Offset: 0x000EC038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSetIndexChartImageAsync(string symbol, double prior, int width, int height, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetSetIndexChartImageOperationCompleted == null)
			{
				this.GetSetIndexChartImageOperationCompleted = new SendOrPostCallback(this.OnGetSetIndexChartImageOperationCompleted);
			}
			base.InvokeAsync("GetSetIndexChartImage", new object[]
			{
				symbol,
				prior,
				width,
				height
			}, this.GetSetIndexChartImageOperationCompleted, userState);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000EDCB8 File Offset: 0x000EC0B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetSetIndexChartImageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetSetIndexChartImageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetSetIndexChartImageCompleted(this, new GetSetIndexChartImageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x000EDD18 File Offset: 0x000EC118
		[SoapDocumentMethod("http://tempuri.org/GetPortfolioStatAllStock", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPortfolioStatAllStock(string custId, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetPortfolioStatAllStock", new object[]
			{
				custId,
				startDate,
				endDate
			});
			return (string)array[0];
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000EDD64 File Offset: 0x000EC164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortfolioStatAllStockAsync(string custId, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetPortfolioStatAllStockAsync(custId, startDate, endDate, null);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000EDD80 File Offset: 0x000EC180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortfolioStatAllStockAsync(string custId, string startDate, string endDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetPortfolioStatAllStockOperationCompleted == null)
			{
				this.GetPortfolioStatAllStockOperationCompleted = new SendOrPostCallback(this.OnGetPortfolioStatAllStockOperationCompleted);
			}
			base.InvokeAsync("GetPortfolioStatAllStock", new object[]
			{
				custId,
				startDate,
				endDate
			}, this.GetPortfolioStatAllStockOperationCompleted, userState);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000EDDEC File Offset: 0x000EC1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetPortfolioStatAllStockOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetPortfolioStatAllStockCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetPortfolioStatAllStockCompleted(this, new GetPortfolioStatAllStockCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000EDE4C File Offset: 0x000EC24C
		[SoapDocumentMethod("http://tempuri.org/GetPortfolioStatByStock", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPortfolioStatByStock(string custId, string stock, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetPortfolioStatByStock", new object[]
			{
				custId,
				stock,
				startDate,
				endDate
			});
			return (string)array[0];
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000EDE9C File Offset: 0x000EC29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortfolioStatByStockAsync(string custId, string stock, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetPortfolioStatByStockAsync(custId, stock, startDate, endDate, null);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000EDEBC File Offset: 0x000EC2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortfolioStatByStockAsync(string custId, string stock, string startDate, string endDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetPortfolioStatByStockOperationCompleted == null)
			{
				this.GetPortfolioStatByStockOperationCompleted = new SendOrPostCallback(this.OnGetPortfolioStatByStockOperationCompleted);
			}
			base.InvokeAsync("GetPortfolioStatByStock", new object[]
			{
				custId,
				stock,
				startDate,
				endDate
			}, this.GetPortfolioStatByStockOperationCompleted, userState);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000EDF2C File Offset: 0x000EC32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetPortfolioStatByStockOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetPortfolioStatByStockCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetPortfolioStatByStockCompleted(this, new GetPortfolioStatByStockCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000EDF8C File Offset: 0x000EC38C
		[SoapDocumentMethod("http://tempuri.org/SavePushAccount", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SavePushAccount(string accountlogin, string registrationID, string device, string accList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SavePushAccount", new object[]
			{
				accountlogin,
				registrationID,
				device,
				accList
			});
			return (bool)array[0];
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000EDFDC File Offset: 0x000EC3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SavePushAccountAsync(string accountlogin, string registrationID, string device, string accList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SavePushAccountAsync(accountlogin, registrationID, device, accList, null);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000EDFFC File Offset: 0x000EC3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SavePushAccountAsync(string accountlogin, string registrationID, string device, string accList, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SavePushAccountOperationCompleted == null)
			{
				this.SavePushAccountOperationCompleted = new SendOrPostCallback(this.OnSavePushAccountOperationCompleted);
			}
			base.InvokeAsync("SavePushAccount", new object[]
			{
				accountlogin,
				registrationID,
				device,
				accList
			}, this.SavePushAccountOperationCompleted, userState);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x000EE06C File Offset: 0x000EC46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSavePushAccountOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SavePushAccountCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SavePushAccountCompleted(this, new SavePushAccountCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000EE0CC File Offset: 0x000EC4CC
		[SoapDocumentMethod("http://tempuri.org/SaveStockAlert", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveStockAlert(string userId, string stock, string field, int operatorType, string mobileAlert, decimal value, int updateMode, string memo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveStockAlert", new object[]
			{
				userId,
				stock,
				field,
				operatorType,
				mobileAlert,
				value,
				updateMode,
				memo
			});
			return (string)array[0];
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000EE140 File Offset: 0x000EC540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockAlertAsync(string userId, string stock, string field, int operatorType, string mobileAlert, decimal value, int updateMode, string memo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveStockAlertAsync(userId, stock, field, operatorType, mobileAlert, value, updateMode, memo, null);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000EE174 File Offset: 0x000EC574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockAlertAsync(string userId, string stock, string field, int operatorType, string mobileAlert, decimal value, int updateMode, string memo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveStockAlertOperationCompleted == null)
			{
				this.SaveStockAlertOperationCompleted = new SendOrPostCallback(this.OnSaveStockAlertOperationCompleted);
			}
			base.InvokeAsync("SaveStockAlert", new object[]
			{
				userId,
				stock,
				field,
				operatorType,
				mobileAlert,
				value,
				updateMode,
				memo
			}, this.SaveStockAlertOperationCompleted, userState);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000EE208 File Offset: 0x000EC608
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveStockAlertOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveStockAlertCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveStockAlertCompleted(this, new SaveStockAlertCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000EE268 File Offset: 0x000EC668
		[SoapDocumentMethod("http://tempuri.org/SavePortAlert", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public long SavePortAlert(string userId, string account, string stock, string sType, int trusteeId, decimal costPct, decimal pricePct, decimal sellPct)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SavePortAlert", new object[]
			{
				userId,
				account,
				stock,
				sType,
				trusteeId,
				costPct,
				pricePct,
				sellPct
			});
			return (long)array[0];
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000EE2E0 File Offset: 0x000EC6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SavePortAlertAsync(string userId, string account, string stock, string sType, int trusteeId, decimal costPct, decimal pricePct, decimal sellPct)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SavePortAlertAsync(userId, account, stock, sType, trusteeId, costPct, pricePct, sellPct, null);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000EE314 File Offset: 0x000EC714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SavePortAlertAsync(string userId, string account, string stock, string sType, int trusteeId, decimal costPct, decimal pricePct, decimal sellPct, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SavePortAlertOperationCompleted == null)
			{
				this.SavePortAlertOperationCompleted = new SendOrPostCallback(this.OnSavePortAlertOperationCompleted);
			}
			base.InvokeAsync("SavePortAlert", new object[]
			{
				userId,
				account,
				stock,
				sType,
				trusteeId,
				costPct,
				pricePct,
				sellPct
			}, this.SavePortAlertOperationCompleted, userState);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000EE3AC File Offset: 0x000EC7AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSavePortAlertOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SavePortAlertCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SavePortAlertCompleted(this, new SavePortAlertCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000EE40C File Offset: 0x000EC80C
		[SoapDocumentMethod("http://tempuri.org/SendAutoTrade", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendAutoTrade(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendAutoTrade", new object[]
			{
				message
			});
			return (string)array[0];
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000EE450 File Offset: 0x000EC850
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAutoTradeAsync(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendAutoTradeAsync(message, null);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000EE46C File Offset: 0x000EC86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAutoTradeAsync(string message, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendAutoTradeOperationCompleted == null)
			{
				this.SendAutoTradeOperationCompleted = new SendOrPostCallback(this.OnSendAutoTradeOperationCompleted);
			}
			base.InvokeAsync("SendAutoTrade", new object[]
			{
				message
			}, this.SendAutoTradeOperationCompleted, userState);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000EE4D0 File Offset: 0x000EC8D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendAutoTradeOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendAutoTradeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendAutoTradeCompleted(this, new SendAutoTradeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000EE530 File Offset: 0x000EC930
		[SoapDocumentMethod("http://tempuri.org/StopOrderRegister", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StopOrderRegister(string userId, bool isRegister)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StopOrderRegister", new object[]
			{
				userId,
				isRegister
			});
			return (string)array[0];
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000EE57C File Offset: 0x000EC97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopOrderRegisterAsync(string userId, bool isRegister)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StopOrderRegisterAsync(userId, isRegister, null);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000EE598 File Offset: 0x000EC998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopOrderRegisterAsync(string userId, bool isRegister, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StopOrderRegisterOperationCompleted == null)
			{
				this.StopOrderRegisterOperationCompleted = new SendOrPostCallback(this.OnStopOrderRegisterOperationCompleted);
			}
			base.InvokeAsync("StopOrderRegister", new object[]
			{
				userId,
				isRegister
			}, this.StopOrderRegisterOperationCompleted, userState);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000EE604 File Offset: 0x000ECA04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStopOrderRegisterOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StopOrderRegisterCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StopOrderRegisterCompleted(this, new StopOrderRegisterCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000EE664 File Offset: 0x000ECA64
		[SoapDocumentMethod("http://tempuri.org/StopOrderCheckDisclaimer", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StopOrderCheckDisclaimer(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StopOrderCheckDisclaimer", new object[]
			{
				userId
			});
			return (string)array[0];
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000EE6A8 File Offset: 0x000ECAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopOrderCheckDisclaimerAsync(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StopOrderCheckDisclaimerAsync(userId, null);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000EE6C4 File Offset: 0x000ECAC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopOrderCheckDisclaimerAsync(string userId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StopOrderCheckDisclaimerOperationCompleted == null)
			{
				this.StopOrderCheckDisclaimerOperationCompleted = new SendOrPostCallback(this.OnStopOrderCheckDisclaimerOperationCompleted);
			}
			base.InvokeAsync("StopOrderCheckDisclaimer", new object[]
			{
				userId
			}, this.StopOrderCheckDisclaimerOperationCompleted, userState);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000EE728 File Offset: 0x000ECB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStopOrderCheckDisclaimerOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StopOrderCheckDisclaimerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StopOrderCheckDisclaimerCompleted(this, new StopOrderCheckDisclaimerCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000EE788 File Offset: 0x000ECB88
		[SoapDocumentMethod("http://tempuri.org/ViewAutoTradeTrans", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewAutoTradeTrans(string userId, string account, string viewType, string stock, string side, string status, bool isHistory)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewAutoTradeTrans", new object[]
			{
				userId,
				account,
				viewType,
				stock,
				side,
				status,
				isHistory
			});
			return (string)array[0];
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000EE7EC File Offset: 0x000ECBEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeTransAsync(string userId, string account, string viewType, string stock, string side, string status, bool isHistory)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewAutoTradeTransAsync(userId, account, viewType, stock, side, status, isHistory, null);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000EE81C File Offset: 0x000ECC1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeTransAsync(string userId, string account, string viewType, string stock, string side, string status, bool isHistory, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewAutoTradeTransOperationCompleted == null)
			{
				this.ViewAutoTradeTransOperationCompleted = new SendOrPostCallback(this.OnViewAutoTradeTransOperationCompleted);
			}
			base.InvokeAsync("ViewAutoTradeTrans", new object[]
			{
				userId,
				account,
				viewType,
				stock,
				side,
				status,
				isHistory
			}, this.ViewAutoTradeTransOperationCompleted, userState);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000EE8A0 File Offset: 0x000ECCA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewAutoTradeTransOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewAutoTradeTransCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewAutoTradeTransCompleted(this, new ViewAutoTradeTransCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000EE900 File Offset: 0x000ECD00
		[SoapDocumentMethod("http://tempuri.org/ViewAutoTradeDCAItems", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewAutoTradeDCAItems(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewAutoTradeDCAItems", new object[]
			{
				refNo
			});
			return (string)array[0];
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000EE948 File Offset: 0x000ECD48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeDCAItemsAsync(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewAutoTradeDCAItemsAsync(refNo, null);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000EE964 File Offset: 0x000ECD64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeDCAItemsAsync(long refNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewAutoTradeDCAItemsOperationCompleted == null)
			{
				this.ViewAutoTradeDCAItemsOperationCompleted = new SendOrPostCallback(this.OnViewAutoTradeDCAItemsOperationCompleted);
			}
			base.InvokeAsync("ViewAutoTradeDCAItems", new object[]
			{
				refNo
			}, this.ViewAutoTradeDCAItemsOperationCompleted, userState);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000EE9CC File Offset: 0x000ECDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewAutoTradeDCAItemsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewAutoTradeDCAItemsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewAutoTradeDCAItemsCompleted(this, new ViewAutoTradeDCAItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000EEA2C File Offset: 0x000ECE2C
		[SoapDocumentMethod("http://tempuri.org/ViewAutoTradePzItems", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewAutoTradePzItems(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewAutoTradePzItems", new object[]
			{
				refNo
			});
			return (string)array[0];
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000EEA74 File Offset: 0x000ECE74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradePzItemsAsync(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewAutoTradePzItemsAsync(refNo, null);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000EEA90 File Offset: 0x000ECE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradePzItemsAsync(long refNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewAutoTradePzItemsOperationCompleted == null)
			{
				this.ViewAutoTradePzItemsOperationCompleted = new SendOrPostCallback(this.OnViewAutoTradePzItemsOperationCompleted);
			}
			base.InvokeAsync("ViewAutoTradePzItems", new object[]
			{
				refNo
			}, this.ViewAutoTradePzItemsOperationCompleted, userState);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000EEAF8 File Offset: 0x000ECEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewAutoTradePzItemsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewAutoTradePzItemsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewAutoTradePzItemsCompleted(this, new ViewAutoTradePzItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000EEB58 File Offset: 0x000ECF58
		[SoapDocumentMethod("http://tempuri.org/ViewAutoTradeFTSItems", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewAutoTradeFTSItems(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewAutoTradeFTSItems", new object[]
			{
				refNo
			});
			return (string)array[0];
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000EEBA0 File Offset: 0x000ECFA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeFTSItemsAsync(long refNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewAutoTradeFTSItemsAsync(refNo, null);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000EEBBC File Offset: 0x000ECFBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewAutoTradeFTSItemsAsync(long refNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewAutoTradeFTSItemsOperationCompleted == null)
			{
				this.ViewAutoTradeFTSItemsOperationCompleted = new SendOrPostCallback(this.OnViewAutoTradeFTSItemsOperationCompleted);
			}
			base.InvokeAsync("ViewAutoTradeFTSItems", new object[]
			{
				refNo
			}, this.ViewAutoTradeFTSItemsOperationCompleted, userState);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000EEC24 File Offset: 0x000ED024
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewAutoTradeFTSItemsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewAutoTradeFTSItemsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewAutoTradeFTSItemsCompleted(this, new ViewAutoTradeFTSItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000EEC84 File Offset: 0x000ED084
		[SoapDocumentMethod("http://tempuri.org/GetHoliday", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetHoliday()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetHoliday", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000EECC4 File Offset: 0x000ED0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetHolidayAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetHolidayAsync(null);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000EECE0 File Offset: 0x000ED0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetHolidayAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetHolidayOperationCompleted == null)
			{
				this.GetHolidayOperationCompleted = new SendOrPostCallback(this.OnGetHolidayOperationCompleted);
			}
			base.InvokeAsync("GetHoliday", new object[0], this.GetHolidayOperationCompleted, userState);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000EED3C File Offset: 0x000ED13C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetHolidayOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetHolidayCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetHolidayCompleted(this, new GetHolidayCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000EED9C File Offset: 0x000ED19C
		[SoapDocumentMethod("http://tempuri.org/SaveUserAlert", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveUserAlert(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string device, int mode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveUserAlert", new object[]
			{
				userId,
				isRecvAdvertise,
				isMktSummary,
				isRecvPort,
				device,
				mode
			});
			return (string)array[0];
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000EEE0C File Offset: 0x000ED20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserAlertAsync(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string device, int mode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserAlertAsync(userId, isRecvAdvertise, isMktSummary, isRecvPort, device, mode, null);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x000EEE3C File Offset: 0x000ED23C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserAlertAsync(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string device, int mode, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserAlertOperationCompleted == null)
			{
				this.SaveUserAlertOperationCompleted = new SendOrPostCallback(this.OnSaveUserAlertOperationCompleted);
			}
			base.InvokeAsync("SaveUserAlert", new object[]
			{
				userId,
				isRecvAdvertise,
				isMktSummary,
				isRecvPort,
				device,
				mode
			}, this.SaveUserAlertOperationCompleted, userState);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000EEECC File Offset: 0x000ED2CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserAlertOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserAlertCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserAlertCompleted(this, new SaveUserAlertCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000EEF2C File Offset: 0x000ED32C
		[SoapDocumentMethod("http://tempuri.org/SaveUserAlert2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveUserAlert2(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string lstActiveGroup)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveUserAlert2", new object[]
			{
				userId,
				isRecvAdvertise,
				isMktSummary,
				isRecvPort,
				lstActiveGroup
			});
			return (string)array[0];
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000EEF90 File Offset: 0x000ED390
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserAlert2Async(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string lstActiveGroup)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserAlert2Async(userId, isRecvAdvertise, isMktSummary, isRecvPort, lstActiveGroup, null);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000EEFB0 File Offset: 0x000ED3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserAlert2Async(string userId, bool isRecvAdvertise, bool isMktSummary, bool isRecvPort, string lstActiveGroup, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserAlert2OperationCompleted == null)
			{
				this.SaveUserAlert2OperationCompleted = new SendOrPostCallback(this.OnSaveUserAlert2OperationCompleted);
			}
			base.InvokeAsync("SaveUserAlert2", new object[]
			{
				userId,
				isRecvAdvertise,
				isMktSummary,
				isRecvPort,
				lstActiveGroup
			}, this.SaveUserAlert2OperationCompleted, userState);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000EF034 File Offset: 0x000ED434
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserAlert2OperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserAlert2Completed != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserAlert2Completed(this, new SaveUserAlert2CompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000EF094 File Offset: 0x000ED494
		[SoapDocumentMethod("http://tempuri.org/GetAlertLog", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAlertLog(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetAlertLog", new object[]
			{
				userId
			});
			return (string)array[0];
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000EF0D8 File Offset: 0x000ED4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetAlertLogAsync(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetAlertLogAsync(userId, null);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000EF0F4 File Offset: 0x000ED4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetAlertLogAsync(string userId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetAlertLogOperationCompleted == null)
			{
				this.GetAlertLogOperationCompleted = new SendOrPostCallback(this.OnGetAlertLogOperationCompleted);
			}
			base.InvokeAsync("GetAlertLog", new object[]
			{
				userId
			}, this.GetAlertLogOperationCompleted, userState);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000EF158 File Offset: 0x000ED558
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetAlertLogOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetAlertLogCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetAlertLogCompleted(this, new GetAlertLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000EF1B8 File Offset: 0x000ED5B8
		[SoapDocumentMethod("http://tempuri.org/GetAlertLogByGroup", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAlertLogByGroup(string groupId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetAlertLogByGroup", new object[]
			{
				groupId
			});
			return (string)array[0];
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000EF1FC File Offset: 0x000ED5FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetAlertLogByGroupAsync(string groupId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetAlertLogByGroupAsync(groupId, null);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000EF218 File Offset: 0x000ED618
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetAlertLogByGroupAsync(string groupId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetAlertLogByGroupOperationCompleted == null)
			{
				this.GetAlertLogByGroupOperationCompleted = new SendOrPostCallback(this.OnGetAlertLogByGroupOperationCompleted);
			}
			base.InvokeAsync("GetAlertLogByGroup", new object[]
			{
				groupId
			}, this.GetAlertLogByGroupOperationCompleted, userState);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000EF27C File Offset: 0x000ED67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetAlertLogByGroupOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetAlertLogByGroupCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetAlertLogByGroupCompleted(this, new GetAlertLogByGroupCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000EF2DC File Offset: 0x000ED6DC
		[SoapDocumentMethod("http://tempuri.org/VerifyAlertManager", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string VerifyAlertManager(string userId, string password)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("VerifyAlertManager", new object[]
			{
				userId,
				password
			});
			return (string)array[0];
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000EF324 File Offset: 0x000ED724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyAlertManagerAsync(string userId, string password)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.VerifyAlertManagerAsync(userId, password, null);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000EF340 File Offset: 0x000ED740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyAlertManagerAsync(string userId, string password, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.VerifyAlertManagerOperationCompleted == null)
			{
				this.VerifyAlertManagerOperationCompleted = new SendOrPostCallback(this.OnVerifyAlertManagerOperationCompleted);
			}
			base.InvokeAsync("VerifyAlertManager", new object[]
			{
				userId,
				password
			}, this.VerifyAlertManagerOperationCompleted, userState);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000EF3A8 File Offset: 0x000ED7A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnVerifyAlertManagerOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._VerifyAlertManagerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._VerifyAlertManagerCompleted(this, new VerifyAlertManagerCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000EF408 File Offset: 0x000ED808
		[SoapDocumentMethod("http://tempuri.org/GetUserAlert", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetUserAlert(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetUserAlert", new object[]
			{
				userId
			});
			return (string)array[0];
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000EF44C File Offset: 0x000ED84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUserAlertAsync(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetUserAlertAsync(userId, null);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000EF468 File Offset: 0x000ED868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUserAlertAsync(string userId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetUserAlertOperationCompleted == null)
			{
				this.GetUserAlertOperationCompleted = new SendOrPostCallback(this.OnGetUserAlertOperationCompleted);
			}
			base.InvokeAsync("GetUserAlert", new object[]
			{
				userId
			}, this.GetUserAlertOperationCompleted, userState);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000EF4CC File Offset: 0x000ED8CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetUserAlertOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetUserAlertCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetUserAlertCompleted(this, new GetUserAlertCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000EF52C File Offset: 0x000ED92C
		[SoapDocumentMethod("http://tempuri.org/GetStockAlertItems", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStockAlertItems(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetStockAlertItems", new object[]
			{
				userId
			});
			return (string)array[0];
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000EF570 File Offset: 0x000ED970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetStockAlertItemsAsync(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetStockAlertItemsAsync(userId, null);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000EF58C File Offset: 0x000ED98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetStockAlertItemsAsync(string userId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetStockAlertItemsOperationCompleted == null)
			{
				this.GetStockAlertItemsOperationCompleted = new SendOrPostCallback(this.OnGetStockAlertItemsOperationCompleted);
			}
			base.InvokeAsync("GetStockAlertItems", new object[]
			{
				userId
			}, this.GetStockAlertItemsOperationCompleted, userState);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000EF5F0 File Offset: 0x000ED9F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetStockAlertItemsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetStockAlertItemsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetStockAlertItemsCompleted(this, new GetStockAlertItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000EF650 File Offset: 0x000EDA50
		[SoapDocumentMethod("http://tempuri.org/GetPortAlertItems", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPortAlertItems(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetPortAlertItems", new object[]
			{
				account
			});
			return (string)array[0];
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000EF694 File Offset: 0x000EDA94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortAlertItemsAsync(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetPortAlertItemsAsync(account, null);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000EF6B0 File Offset: 0x000EDAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortAlertItemsAsync(string account, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetPortAlertItemsOperationCompleted == null)
			{
				this.GetPortAlertItemsOperationCompleted = new SendOrPostCallback(this.OnGetPortAlertItemsOperationCompleted);
			}
			base.InvokeAsync("GetPortAlertItems", new object[]
			{
				account
			}, this.GetPortAlertItemsOperationCompleted, userState);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000EF714 File Offset: 0x000EDB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetPortAlertItemsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetPortAlertItemsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetPortAlertItemsCompleted(this, new GetPortAlertItemsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000EF774 File Offset: 0x000EDB74
		[SoapDocumentMethod("http://tempuri.org/NAVChart", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string NAVChart(string account, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("NAVChart", new object[]
			{
				account,
				startDate,
				endDate
			});
			return (string)array[0];
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000EF7C0 File Offset: 0x000EDBC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NAVChartAsync(string account, string startDate, string endDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.NAVChartAsync(account, startDate, endDate, null);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000EF7DC File Offset: 0x000EDBDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NAVChartAsync(string account, string startDate, string endDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.NAVChartOperationCompleted == null)
			{
				this.NAVChartOperationCompleted = new SendOrPostCallback(this.OnNAVChartOperationCompleted);
			}
			base.InvokeAsync("NAVChart", new object[]
			{
				account,
				startDate,
				endDate
			}, this.NAVChartOperationCompleted, userState);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000EF848 File Offset: 0x000EDC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnNAVChartOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._NAVChartCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._NAVChartCompleted(this, new NAVChartCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000EF8A8 File Offset: 0x000EDCA8
		[SoapDocumentMethod("http://tempuri.org/NAVAdjustment", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string NAVAdjustment(string account, decimal amount, string sDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("NAVAdjustment", new object[]
			{
				account,
				amount,
				sDate
			});
			return (string)array[0];
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000EF8F8 File Offset: 0x000EDCF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NAVAdjustmentAsync(string account, decimal amount, string sDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.NAVAdjustmentAsync(account, amount, sDate, null);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000EF914 File Offset: 0x000EDD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NAVAdjustmentAsync(string account, decimal amount, string sDate, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.NAVAdjustmentOperationCompleted == null)
			{
				this.NAVAdjustmentOperationCompleted = new SendOrPostCallback(this.OnNAVAdjustmentOperationCompleted);
			}
			base.InvokeAsync("NAVAdjustment", new object[]
			{
				account,
				amount,
				sDate
			}, this.NAVAdjustmentOperationCompleted, userState);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000EF984 File Offset: 0x000EDD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnNAVAdjustmentOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._NAVAdjustmentCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._NAVAdjustmentCompleted(this, new NAVAdjustmentCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000EF9E4 File Offset: 0x000EDDE4
		[SoapDocumentMethod("http://tempuri.org/GetDataForSmartClick", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDataForSmartClick(string stock, string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetDataForSmartClick", new object[]
			{
				stock,
				account
			});
			return (string)array[0];
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000EFA2C File Offset: 0x000EDE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetDataForSmartClickAsync(string stock, string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetDataForSmartClickAsync(stock, account, null);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000EFA48 File Offset: 0x000EDE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetDataForSmartClickAsync(string stock, string account, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetDataForSmartClickOperationCompleted == null)
			{
				this.GetDataForSmartClickOperationCompleted = new SendOrPostCallback(this.OnGetDataForSmartClickOperationCompleted);
			}
			base.InvokeAsync("GetDataForSmartClick", new object[]
			{
				stock,
				account
			}, this.GetDataForSmartClickOperationCompleted, userState);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000EFAB0 File Offset: 0x000EDEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetDataForSmartClickOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetDataForSmartClickCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetDataForSmartClickCompleted(this, new GetDataForSmartClickCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000EFB10 File Offset: 0x000EDF10
		[SoapDocumentMethod("http://tempuri.org/GetOrderFor1Click", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetOrderFor1Click(string stock, string account, string price, string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetOrderFor1Click", new object[]
			{
				stock,
				account,
				price,
				side
			});
			return (string)array[0];
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000EFB60 File Offset: 0x000EDF60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOrderFor1ClickAsync(string stock, string account, string price, string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetOrderFor1ClickAsync(stock, account, price, side, null);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000EFB80 File Offset: 0x000EDF80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOrderFor1ClickAsync(string stock, string account, string price, string side, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetOrderFor1ClickOperationCompleted == null)
			{
				this.GetOrderFor1ClickOperationCompleted = new SendOrPostCallback(this.OnGetOrderFor1ClickOperationCompleted);
			}
			base.InvokeAsync("GetOrderFor1Click", new object[]
			{
				stock,
				account,
				price,
				side
			}, this.GetOrderFor1ClickOperationCompleted, userState);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000EFBF0 File Offset: 0x000EDFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetOrderFor1ClickOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetOrderFor1ClickCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetOrderFor1ClickCompleted(this, new GetOrderFor1ClickCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000EFC50 File Offset: 0x000EE050
		[SoapDocumentMethod("http://tempuri.org/SaveSummaryMarketData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int SaveSummaryMarketData(string date, string sumBy, string investor, decimal buyValue, decimal pctBuyValue, decimal sellValue, decimal pctSellValue, decimal sumValue, decimal pctSumValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveSummaryMarketData", new object[]
			{
				date,
				sumBy,
				investor,
				buyValue,
				pctBuyValue,
				sellValue,
				pctSellValue,
				sumValue,
				pctSumValue
			});
			return (int)array[0];
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000EFCD8 File Offset: 0x000EE0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveSummaryMarketDataAsync(string date, string sumBy, string investor, decimal buyValue, decimal pctBuyValue, decimal sellValue, decimal pctSellValue, decimal sumValue, decimal pctSumValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveSummaryMarketDataAsync(date, sumBy, investor, buyValue, pctBuyValue, sellValue, pctSellValue, sumValue, pctSumValue, null);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000EFD0C File Offset: 0x000EE10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveSummaryMarketDataAsync(string date, string sumBy, string investor, decimal buyValue, decimal pctBuyValue, decimal sellValue, decimal pctSellValue, decimal sumValue, decimal pctSumValue, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveSummaryMarketDataOperationCompleted == null)
			{
				this.SaveSummaryMarketDataOperationCompleted = new SendOrPostCallback(this.OnSaveSummaryMarketDataOperationCompleted);
			}
			base.InvokeAsync("SaveSummaryMarketData", new object[]
			{
				date,
				sumBy,
				investor,
				buyValue,
				pctBuyValue,
				sellValue,
				pctSellValue,
				sumValue,
				pctSumValue
			}, this.SaveSummaryMarketDataOperationCompleted, userState);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000EFDB4 File Offset: 0x000EE1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveSummaryMarketDataOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveSummaryMarketDataCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveSummaryMarketDataCompleted(this, new SaveSummaryMarketDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000EFE14 File Offset: 0x000EE214
		[SoapDocumentMethod("http://tempuri.org/GetStockIndicator", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStockIndicator(string indicatorType, string stock, int period)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetStockIndicator", new object[]
			{
				indicatorType,
				stock,
				period
			});
			return (string)array[0];
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000EFE64 File Offset: 0x000EE264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetStockIndicatorAsync(string indicatorType, string stock, int period)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetStockIndicatorAsync(indicatorType, stock, period, null);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000EFE80 File Offset: 0x000EE280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetStockIndicatorAsync(string indicatorType, string stock, int period, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetStockIndicatorOperationCompleted == null)
			{
				this.GetStockIndicatorOperationCompleted = new SendOrPostCallback(this.OnGetStockIndicatorOperationCompleted);
			}
			base.InvokeAsync("GetStockIndicator", new object[]
			{
				indicatorType,
				stock,
				period
			}, this.GetStockIndicatorOperationCompleted, userState);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000EFEF0 File Offset: 0x000EE2F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetStockIndicatorOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetStockIndicatorCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetStockIndicatorCompleted(this, new GetStockIndicatorCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000EFF50 File Offset: 0x000EE350
		[SoapDocumentMethod("http://tempuri.org/SaveUserConfig", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveUserConfig(string userId, string keyValue, string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveUserConfig", new object[]
			{
				userId,
				keyValue,
				value
			});
			return (string)array[0];
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000EFF9C File Offset: 0x000EE39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigAsync(string userId, string keyValue, string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserConfigAsync(userId, keyValue, value, null);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000EFFB8 File Offset: 0x000EE3B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigAsync(string userId, string keyValue, string value, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserConfigOperationCompleted == null)
			{
				this.SaveUserConfigOperationCompleted = new SendOrPostCallback(this.OnSaveUserConfigOperationCompleted);
			}
			base.InvokeAsync("SaveUserConfig", new object[]
			{
				userId,
				keyValue,
				value
			}, this.SaveUserConfigOperationCompleted, userState);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000F0024 File Offset: 0x000EE424
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserConfigOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserConfigCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserConfigCompleted(this, new SaveUserConfigCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000F0084 File Offset: 0x000EE484
		[SoapDocumentMethod("http://tempuri.org/SaveUserConfigAll", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveUserConfigAll(string userId, string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveUserConfigAll", new object[]
			{
				userId,
				value
			});
			return (string)array[0];
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000F00CC File Offset: 0x000EE4CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigAllAsync(string userId, string value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserConfigAllAsync(userId, value, null);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000F00E8 File Offset: 0x000EE4E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigAllAsync(string userId, string value, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserConfigAllOperationCompleted == null)
			{
				this.SaveUserConfigAllOperationCompleted = new SendOrPostCallback(this.OnSaveUserConfigAllOperationCompleted);
			}
			base.InvokeAsync("SaveUserConfigAll", new object[]
			{
				userId,
				value
			}, this.SaveUserConfigAllOperationCompleted, userState);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000F0150 File Offset: 0x000EE550
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserConfigAllOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserConfigAllCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserConfigAllCompleted(this, new SaveUserConfigAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000F01B0 File Offset: 0x000EE5B0
		[SoapDocumentMethod("http://tempuri.org/GetPortEquity", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPortEquity(string account, string accType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetPortEquity", new object[]
			{
				account,
				accType
			});
			return (string)array[0];
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000F01F8 File Offset: 0x000EE5F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortEquityAsync(string account, string accType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetPortEquityAsync(account, accType, null);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000F0214 File Offset: 0x000EE614
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetPortEquityAsync(string account, string accType, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetPortEquityOperationCompleted == null)
			{
				this.GetPortEquityOperationCompleted = new SendOrPostCallback(this.OnGetPortEquityOperationCompleted);
			}
			base.InvokeAsync("GetPortEquity", new object[]
			{
				account,
				accType
			}, this.GetPortEquityOperationCompleted, userState);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000F027C File Offset: 0x000EE67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetPortEquityOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetPortEquityCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetPortEquityCompleted(this, new GetPortEquityCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x000F02DC File Offset: 0x000EE6DC
		[SoapDocumentMethod("http://tempuri.org/SendHeartBeat2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendHeartBeat2(string param)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendHeartBeat2", new object[]
			{
				param
			});
			return (string)array[0];
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000F0320 File Offset: 0x000EE720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendHeartBeat2Async(string param)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendHeartBeat2Async(param, null);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000F033C File Offset: 0x000EE73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendHeartBeat2Async(string param, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendHeartBeat2OperationCompleted == null)
			{
				this.SendHeartBeat2OperationCompleted = new SendOrPostCallback(this.OnSendHeartBeat2OperationCompleted);
			}
			base.InvokeAsync("SendHeartBeat2", new object[]
			{
				param
			}, this.SendHeartBeat2OperationCompleted, userState);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000F03A0 File Offset: 0x000EE7A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendHeartBeat2OperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendHeartBeat2Completed != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendHeartBeat2Completed(this, new SendHeartBeat2CompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000F0400 File Offset: 0x000EE800
		[SoapDocumentMethod("http://tempuri.org/SaveUserEfinForward", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserEfinForward(string fullname, string nickname, string userId, string regisDate, string emailAccount)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Invoke("SaveUserEfinForward", new object[]
			{
				fullname,
				nickname,
				userId,
				regisDate,
				emailAccount
			});
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000F0448 File Offset: 0x000EE848
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserEfinForwardAsync(string fullname, string nickname, string userId, string regisDate, string emailAccount)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserEfinForwardAsync(fullname, nickname, userId, regisDate, emailAccount, null);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000F0468 File Offset: 0x000EE868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserEfinForwardAsync(string fullname, string nickname, string userId, string regisDate, string emailAccount, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserEfinForwardOperationCompleted == null)
			{
				this.SaveUserEfinForwardOperationCompleted = new SendOrPostCallback(this.OnSaveUserEfinForwardOperationCompleted);
			}
			base.InvokeAsync("SaveUserEfinForward", new object[]
			{
				fullname,
				nickname,
				userId,
				regisDate,
				emailAccount
			}, this.SaveUserEfinForwardOperationCompleted, userState);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000F04E0 File Offset: 0x000EE8E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserEfinForwardOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserEfinForwardCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserEfinForwardCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000F053C File Offset: 0x000EE93C
		[SoapDocumentMethod("http://tempuri.org/LoadAllInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadAllInformation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadAllInformation", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000F057C File Offset: 0x000EE97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllInformationAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadAllInformationAsync(null);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000F0598 File Offset: 0x000EE998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllInformationAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadAllInformationOperationCompleted == null)
			{
				this.LoadAllInformationOperationCompleted = new SendOrPostCallback(this.OnLoadAllInformationOperationCompleted);
			}
			base.InvokeAsync("LoadAllInformation", new object[0], this.LoadAllInformationOperationCompleted, userState);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000F05F4 File Offset: 0x000EE9F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadAllInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadAllInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadAllInformationCompleted(this, new LoadAllInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000F0654 File Offset: 0x000EEA54
		[SoapDocumentMethod("http://tempuri.org/LoadAllInformationIsodd", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadAllInformationIsodd(bool isLoadOddlot)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadAllInformationIsodd", new object[]
			{
				isLoadOddlot
			});
			return (string)array[0];
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000F069C File Offset: 0x000EEA9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllInformationIsoddAsync(bool isLoadOddlot)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadAllInformationIsoddAsync(isLoadOddlot, null);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000F06B8 File Offset: 0x000EEAB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllInformationIsoddAsync(bool isLoadOddlot, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadAllInformationIsoddOperationCompleted == null)
			{
				this.LoadAllInformationIsoddOperationCompleted = new SendOrPostCallback(this.OnLoadAllInformationIsoddOperationCompleted);
			}
			base.InvokeAsync("LoadAllInformationIsodd", new object[]
			{
				isLoadOddlot
			}, this.LoadAllInformationIsoddOperationCompleted, userState);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000F0720 File Offset: 0x000EEB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadAllInformationIsoddOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadAllInformationIsoddCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadAllInformationIsoddCompleted(this, new LoadAllInformationIsoddCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000F0780 File Offset: 0x000EEB80
		[SoapDocumentMethod("http://tempuri.org/LoadStockInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadStockInformation(int startSecNo, int topSelect)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadStockInformation", new object[]
			{
				startSecNo,
				topSelect
			});
			return (string)array[0];
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000F07D4 File Offset: 0x000EEBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockInformationAsync(int startSecNo, int topSelect)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadStockInformationAsync(startSecNo, topSelect, null);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000F07F0 File Offset: 0x000EEBF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStockInformationAsync(int startSecNo, int topSelect, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadStockInformationOperationCompleted == null)
			{
				this.LoadStockInformationOperationCompleted = new SendOrPostCallback(this.OnLoadStockInformationOperationCompleted);
			}
			base.InvokeAsync("LoadStockInformation", new object[]
			{
				startSecNo,
				topSelect
			}, this.LoadStockInformationOperationCompleted, userState);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000F0860 File Offset: 0x000EEC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadStockInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadStockInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadStockInformationCompleted(this, new LoadStockInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000F08C0 File Offset: 0x000EECC0
		[SoapDocumentMethod("http://tempuri.org/ReloadSETIndexInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ReloadSETIndexInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ReloadSETIndexInfo", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000F0900 File Offset: 0x000EED00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadSETIndexInfoAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadSETIndexInfoAsync(null);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000F091C File Offset: 0x000EED1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadSETIndexInfoAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ReloadSETIndexInfoOperationCompleted == null)
			{
				this.ReloadSETIndexInfoOperationCompleted = new SendOrPostCallback(this.OnReloadSETIndexInfoOperationCompleted);
			}
			base.InvokeAsync("ReloadSETIndexInfo", new object[0], this.ReloadSETIndexInfoOperationCompleted, userState);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000F0978 File Offset: 0x000EED78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnReloadSETIndexInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ReloadSETIndexInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ReloadSETIndexInfoCompleted(this, new ReloadSETIndexInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000F09D8 File Offset: 0x000EEDD8
		[SoapDocumentMethod("http://tempuri.org/LoadMarketInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadMarketInformation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadMarketInformation", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000F0A18 File Offset: 0x000EEE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadMarketInformationAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadMarketInformationAsync(null);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000F0A34 File Offset: 0x000EEE34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadMarketInformationAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadMarketInformationOperationCompleted == null)
			{
				this.LoadMarketInformationOperationCompleted = new SendOrPostCallback(this.OnLoadMarketInformationOperationCompleted);
			}
			base.InvokeAsync("LoadMarketInformation", new object[0], this.LoadMarketInformationOperationCompleted, userState);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000F0A90 File Offset: 0x000EEE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadMarketInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadMarketInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadMarketInformationCompleted(this, new LoadMarketInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000F0AF0 File Offset: 0x000EEEF0
		[SoapDocumentMethod("http://tempuri.org/LoadOddLotInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LoadOddLotInformation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("LoadOddLotInformation", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000F0B30 File Offset: 0x000EEF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadOddLotInformationAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadOddLotInformationAsync(null);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x000F0B4C File Offset: 0x000EEF4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadOddLotInformationAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LoadOddLotInformationOperationCompleted == null)
			{
				this.LoadOddLotInformationOperationCompleted = new SendOrPostCallback(this.OnLoadOddLotInformationOperationCompleted);
			}
			base.InvokeAsync("LoadOddLotInformation", new object[0], this.LoadOddLotInformationOperationCompleted, userState);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000F0BA8 File Offset: 0x000EEFA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadOddLotInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LoadOddLotInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LoadOddLotInformationCompleted(this, new LoadOddLotInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000F0C08 File Offset: 0x000EF008
		[SoapDocumentMethod("http://tempuri.org/BoardcastMessage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BoardcastMessage(string account, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BoardcastMessage", new object[]
			{
				account,
				recordPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000F0C54 File Offset: 0x000EF054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BoardcastMessageAsync(string account, int recordPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BoardcastMessageAsync(account, recordPerPage, null);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x000F0C70 File Offset: 0x000EF070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BoardcastMessageAsync(string account, int recordPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BoardcastMessageOperationCompleted == null)
			{
				this.BoardcastMessageOperationCompleted = new SendOrPostCallback(this.OnBoardcastMessageOperationCompleted);
			}
			base.InvokeAsync("BoardcastMessage", new object[]
			{
				account,
				recordPerPage
			}, this.BoardcastMessageOperationCompleted, userState);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x000F0CDC File Offset: 0x000EF0DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBoardcastMessageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BoardcastMessageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BoardcastMessageCompleted(this, new BoardcastMessageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000F0D3C File Offset: 0x000EF13C
		[SoapDocumentMethod("http://tempuri.org/SendPushMessage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SendPushMessage(string key, string groupId, string message, string shooter)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SendPushMessage", new object[]
			{
				key,
				groupId,
				message,
				shooter
			});
			return (string)array[0];
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000F0D8C File Offset: 0x000EF18C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendPushMessageAsync(string key, string groupId, string message, string shooter)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendPushMessageAsync(key, groupId, message, shooter, null);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x000F0DAC File Offset: 0x000EF1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendPushMessageAsync(string key, string groupId, string message, string shooter, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SendPushMessageOperationCompleted == null)
			{
				this.SendPushMessageOperationCompleted = new SendOrPostCallback(this.OnSendPushMessageOperationCompleted);
			}
			base.InvokeAsync("SendPushMessage", new object[]
			{
				key,
				groupId,
				message,
				shooter
			}, this.SendPushMessageOperationCompleted, userState);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000F0E1C File Offset: 0x000EF21C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSendPushMessageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SendPushMessageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SendPushMessageCompleted(this, new SendPushMessageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000F0E7C File Offset: 0x000EF27C
		[SoapDocumentMethod("http://tempuri.org/BestBidOffer", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestBidOffer(string stockList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestBidOffer", new object[]
			{
				stockList
			});
			return (string)array[0];
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000F0EC0 File Offset: 0x000EF2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferAsync(string stockList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestBidOfferAsync(stockList, null);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000F0EDC File Offset: 0x000EF2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestBidOfferAsync(string stockList, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestBidOfferOperationCompleted == null)
			{
				this.BestBidOfferOperationCompleted = new SendOrPostCallback(this.OnBestBidOfferOperationCompleted);
			}
			base.InvokeAsync("BestBidOffer", new object[]
			{
				stockList
			}, this.BestBidOfferOperationCompleted, userState);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000F0F40 File Offset: 0x000EF340
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestBidOfferOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestBidOfferCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestBidOfferCompleted(this, new BestBidOfferCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000F0FA0 File Offset: 0x000EF3A0
		[SoapDocumentMethod("http://tempuri.org/BestOpenPrice", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestOpenPrice(string viewType, string compareMode, string marketID, int sesssionID, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestOpenPrice", new object[]
			{
				viewType,
				compareMode,
				marketID,
				sesssionID,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000F100C File Offset: 0x000EF40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestOpenPriceAsync(string viewType, string compareMode, string marketID, int sesssionID, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestOpenPriceAsync(viewType, compareMode, marketID, sesssionID, startRow, rowPerPage, null);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000F103C File Offset: 0x000EF43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestOpenPriceAsync(string viewType, string compareMode, string marketID, int sesssionID, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestOpenPriceOperationCompleted == null)
			{
				this.BestOpenPriceOperationCompleted = new SendOrPostCallback(this.OnBestOpenPriceOperationCompleted);
			}
			base.InvokeAsync("BestOpenPrice", new object[]
			{
				viewType,
				compareMode,
				marketID,
				sesssionID,
				startRow,
				rowPerPage
			}, this.BestOpenPriceOperationCompleted, userState);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000F10C8 File Offset: 0x000EF4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestOpenPriceOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestOpenPriceCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestOpenPriceCompleted(this, new BestOpenPriceCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000F1128 File Offset: 0x000EF528
		[SoapDocumentMethod("http://tempuri.org/BestProjected", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string BestProjected(string boardType, string compareMode, string poType, string marketID, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("BestProjected", new object[]
			{
				boardType,
				compareMode,
				poType,
				marketID,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000F118C File Offset: 0x000EF58C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestProjectedAsync(string boardType, string compareMode, string poType, string marketID, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BestProjectedAsync(boardType, compareMode, poType, marketID, startRow, rowPerPage, null);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000F11BC File Offset: 0x000EF5BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BestProjectedAsync(string boardType, string compareMode, string poType, string marketID, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.BestProjectedOperationCompleted == null)
			{
				this.BestProjectedOperationCompleted = new SendOrPostCallback(this.OnBestProjectedOperationCompleted);
			}
			base.InvokeAsync("BestProjected", new object[]
			{
				boardType,
				compareMode,
				poType,
				marketID,
				startRow,
				rowPerPage
			}, this.BestProjectedOperationCompleted, userState);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000F1240 File Offset: 0x000EF640
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBestProjectedOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._BestProjectedCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._BestProjectedCompleted(this, new BestProjectedCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000F12A0 File Offset: 0x000EF6A0
		[SoapDocumentMethod("http://tempuri.org/IndustryStat", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string IndustryStat()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("IndustryStat", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000F12E0 File Offset: 0x000EF6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IndustryStatAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IndustryStatAsync(null);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000F12FC File Offset: 0x000EF6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IndustryStatAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IndustryStatOperationCompleted == null)
			{
				this.IndustryStatOperationCompleted = new SendOrPostCallback(this.OnIndustryStatOperationCompleted);
			}
			base.InvokeAsync("IndustryStat", new object[0], this.IndustryStatOperationCompleted, userState);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000F1358 File Offset: 0x000EF758
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnIndustryStatOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._IndustryStatCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._IndustryStatCompleted(this, new IndustryStatCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000F13B8 File Offset: 0x000EF7B8
		[SoapDocumentMethod("http://tempuri.org/TopActive", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActive(string viewType, string board, string marketID, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActive", new object[]
			{
				viewType,
				board,
				marketID,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000F1410 File Offset: 0x000EF810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveAsync(string viewType, string board, string marketID, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveAsync(viewType, board, marketID, rowPerPage, null);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000F1430 File Offset: 0x000EF830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveAsync(string viewType, string board, string marketID, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveOperationCompleted == null)
			{
				this.TopActiveOperationCompleted = new SendOrPostCallback(this.OnTopActiveOperationCompleted);
			}
			base.InvokeAsync("TopActive", new object[]
			{
				viewType,
				board,
				marketID,
				rowPerPage
			}, this.TopActiveOperationCompleted, userState);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000F14A8 File Offset: 0x000EF8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveCompleted(this, new TopActiveCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000F1508 File Offset: 0x000EF908
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO(string viewType, string board, string marketID, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO", new object[]
			{
				viewType,
				board,
				marketID,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000F1560 File Offset: 0x000EF960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBOAsync(string viewType, string board, string marketID, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBOAsync(viewType, board, marketID, rowPerPage, null);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000F1580 File Offset: 0x000EF980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBOAsync(string viewType, string board, string marketID, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBOOperationCompleted == null)
			{
				this.TopActiveBBOOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBOOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO", new object[]
			{
				viewType,
				board,
				marketID,
				rowPerPage
			}, this.TopActiveBBOOperationCompleted, userState);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000F15F8 File Offset: 0x000EF9F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBOOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBOCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBOCompleted(this, new TopActiveBBOCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000F1658 File Offset: 0x000EFA58
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_Benefit", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_Benefit()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_Benefit", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000F1698 File Offset: 0x000EFA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_BenefitAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_BenefitAsync(null);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000F16B4 File Offset: 0x000EFAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_BenefitAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_BenefitOperationCompleted == null)
			{
				this.TopActiveBBO_BenefitOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_BenefitOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_Benefit", new object[0], this.TopActiveBBO_BenefitOperationCompleted, userState);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000F1710 File Offset: 0x000EFB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_BenefitOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_BenefitCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_BenefitCompleted(this, new TopActiveBBO_BenefitCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000F1770 File Offset: 0x000EFB70
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_Warrant", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_Warrant()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_Warrant", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000F17B0 File Offset: 0x000EFBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_WarrantAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_WarrantAsync(null);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000F17CC File Offset: 0x000EFBCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_WarrantAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_WarrantOperationCompleted == null)
			{
				this.TopActiveBBO_WarrantOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_WarrantOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_Warrant", new object[0], this.TopActiveBBO_WarrantOperationCompleted, userState);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000F1828 File Offset: 0x000EFC28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_WarrantOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_WarrantCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_WarrantCompleted(this, new TopActiveBBO_WarrantCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000F1888 File Offset: 0x000EFC88
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_CMPR", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_CMPR(int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_CMPR", new object[]
			{
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000F18D0 File Offset: 0x000EFCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_CMPRAsync(int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_CMPRAsync(rowPerPage, null);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000F18EC File Offset: 0x000EFCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_CMPRAsync(int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_CMPROperationCompleted == null)
			{
				this.TopActiveBBO_CMPROperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_CMPROperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_CMPR", new object[]
			{
				rowPerPage
			}, this.TopActiveBBO_CMPROperationCompleted, userState);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000F1954 File Offset: 0x000EFD54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_CMPROperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_CMPRCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_CMPRCompleted(this, new TopActiveBBO_CMPRCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000F19B4 File Offset: 0x000EFDB4
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_MyPort", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_MyPort(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_MyPort", new object[]
			{
				custId
			});
			return (string)array[0];
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000F19F8 File Offset: 0x000EFDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_MyPortAsync(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_MyPortAsync(custId, null);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000F1A14 File Offset: 0x000EFE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_MyPortAsync(string custId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_MyPortOperationCompleted == null)
			{
				this.TopActiveBBO_MyPortOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_MyPortOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_MyPort", new object[]
			{
				custId
			}, this.TopActiveBBO_MyPortOperationCompleted, userState);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000F1A78 File Offset: 0x000EFE78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_MyPortOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_MyPortCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_MyPortCompleted(this, new TopActiveBBO_MyPortCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000F1AD8 File Offset: 0x000EFED8
		[SoapDocumentMethod("http://tempuri.org/GetMyPortSymbolList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetMyPortSymbolList(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetMyPortSymbolList", new object[]
			{
				custId
			});
			return (string)array[0];
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000F1B1C File Offset: 0x000EFF1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetMyPortSymbolListAsync(string custId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetMyPortSymbolListAsync(custId, null);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000F1B38 File Offset: 0x000EFF38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetMyPortSymbolListAsync(string custId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetMyPortSymbolListOperationCompleted == null)
			{
				this.GetMyPortSymbolListOperationCompleted = new SendOrPostCallback(this.OnGetMyPortSymbolListOperationCompleted);
			}
			base.InvokeAsync("GetMyPortSymbolList", new object[]
			{
				custId
			}, this.GetMyPortSymbolListOperationCompleted, userState);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000F1B9C File Offset: 0x000EFF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetMyPortSymbolListOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetMyPortSymbolListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetMyPortSymbolListCompleted(this, new GetMyPortSymbolListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000F1BFC File Offset: 0x000EFFFC
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_DW", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_DW(string parentStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_DW", new object[]
			{
				parentStock
			});
			return (string)array[0];
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000F1C40 File Offset: 0x000F0040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_DWAsync(string parentStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_DWAsync(parentStock, null);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000F1C5C File Offset: 0x000F005C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_DWAsync(string parentStock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_DWOperationCompleted == null)
			{
				this.TopActiveBBO_DWOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_DWOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_DW", new object[]
			{
				parentStock
			}, this.TopActiveBBO_DWOperationCompleted, userState);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000F1CC0 File Offset: 0x000F00C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_DWOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_DWCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_DWCompleted(this, new TopActiveBBO_DWCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000F1D20 File Offset: 0x000F0120
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_News", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_News()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_News", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000F1D60 File Offset: 0x000F0160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_NewsAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_NewsAsync(null);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000F1D7C File Offset: 0x000F017C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_NewsAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_NewsOperationCompleted == null)
			{
				this.TopActiveBBO_NewsOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_NewsOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_News", new object[0], this.TopActiveBBO_NewsOperationCompleted, userState);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000F1DD8 File Offset: 0x000F01D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_NewsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_NewsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_NewsCompleted(this, new TopActiveBBO_NewsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000F1E38 File Offset: 0x000F0238
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_TurnOver", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_TurnOver()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_TurnOver", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000F1E78 File Offset: 0x000F0278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_TurnOverAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_TurnOverAsync(null);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000F1E94 File Offset: 0x000F0294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_TurnOverAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_TurnOverOperationCompleted == null)
			{
				this.TopActiveBBO_TurnOverOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_TurnOverOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_TurnOver", new object[0], this.TopActiveBBO_TurnOverOperationCompleted, userState);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000F1EF0 File Offset: 0x000F02F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_TurnOverOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_TurnOverCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_TurnOverCompleted(this, new TopActiveBBO_TurnOverCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000F1F50 File Offset: 0x000F0350
		[SoapDocumentMethod("http://tempuri.org/TopActiveBBO_Sector", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopActiveBBO_Sector(int sectorNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopActiveBBO_Sector", new object[]
			{
				sectorNumber
			});
			return (string)array[0];
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000F1F98 File Offset: 0x000F0398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_SectorAsync(int sectorNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopActiveBBO_SectorAsync(sectorNumber, null);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000F1FB4 File Offset: 0x000F03B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopActiveBBO_SectorAsync(int sectorNumber, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopActiveBBO_SectorOperationCompleted == null)
			{
				this.TopActiveBBO_SectorOperationCompleted = new SendOrPostCallback(this.OnTopActiveBBO_SectorOperationCompleted);
			}
			base.InvokeAsync("TopActiveBBO_Sector", new object[]
			{
				sectorNumber
			}, this.TopActiveBBO_SectorOperationCompleted, userState);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000F201C File Offset: 0x000F041C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopActiveBBO_SectorOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopActiveBBO_SectorCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopActiveBBO_SectorCompleted(this, new TopActiveBBO_SectorCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000F207C File Offset: 0x000F047C
		[SoapDocumentMethod("http://tempuri.org/InvestorType", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string InvestorType(string summaryType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("InvestorType", new object[]
			{
				summaryType
			});
			return (string)array[0];
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000F20C0 File Offset: 0x000F04C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvestorTypeAsync(string summaryType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.InvestorTypeAsync(summaryType, null);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000F20DC File Offset: 0x000F04DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvestorTypeAsync(string summaryType, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.InvestorTypeOperationCompleted == null)
			{
				this.InvestorTypeOperationCompleted = new SendOrPostCallback(this.OnInvestorTypeOperationCompleted);
			}
			base.InvokeAsync("InvestorType", new object[]
			{
				summaryType
			}, this.InvestorTypeOperationCompleted, userState);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000F2140 File Offset: 0x000F0540
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnInvestorTypeOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._InvestorTypeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._InvestorTypeCompleted(this, new InvestorTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000F21A0 File Offset: 0x000F05A0
		[SoapDocumentMethod("http://tempuri.org/MarketIndicator", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string MarketIndicator()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("MarketIndicator", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000F21E0 File Offset: 0x000F05E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarketIndicatorAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.MarketIndicatorAsync(null);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000F21FC File Offset: 0x000F05FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarketIndicatorAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.MarketIndicatorOperationCompleted == null)
			{
				this.MarketIndicatorOperationCompleted = new SendOrPostCallback(this.OnMarketIndicatorOperationCompleted);
			}
			base.InvokeAsync("MarketIndicator", new object[0], this.MarketIndicatorOperationCompleted, userState);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000F2258 File Offset: 0x000F0658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnMarketIndicatorOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._MarketIndicatorCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._MarketIndicatorCompleted(this, new MarketIndicatorCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000F22B8 File Offset: 0x000F06B8
		[SoapDocumentMethod("http://tempuri.org/SaleByPrice", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaleByPrice(int securityNumber, int startRow, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaleByPrice", new object[]
			{
				securityNumber,
				startRow,
				rowPerPage,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000F231C File Offset: 0x000F071C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaleByPriceAsync(int securityNumber, int startRow, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaleByPriceAsync(securityNumber, startRow, rowPerPage, maxTicker, null);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000F233C File Offset: 0x000F073C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaleByPriceAsync(int securityNumber, int startRow, int rowPerPage, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaleByPriceOperationCompleted == null)
			{
				this.SaleByPriceOperationCompleted = new SendOrPostCallback(this.OnSaleByPriceOperationCompleted);
			}
			base.InvokeAsync("SaleByPrice", new object[]
			{
				securityNumber,
				startRow,
				rowPerPage,
				maxTicker
			}, this.SaleByPriceOperationCompleted, userState);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000F23C0 File Offset: 0x000F07C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaleByPriceOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaleByPriceCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaleByPriceCompleted(this, new SaleByPriceCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000F2420 File Offset: 0x000F0820
		[SoapDocumentMethod("http://tempuri.org/SectorStat", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SectorStat()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SectorStat", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000F2460 File Offset: 0x000F0860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SectorStatAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SectorStatAsync(null);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000F247C File Offset: 0x000F087C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SectorStatAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SectorStatOperationCompleted == null)
			{
				this.SectorStatOperationCompleted = new SendOrPostCallback(this.OnSectorStatOperationCompleted);
			}
			base.InvokeAsync("SectorStat", new object[0], this.SectorStatOperationCompleted, userState);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000F24D8 File Offset: 0x000F08D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSectorStatOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SectorStatCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SectorStatCompleted(this, new SectorStatCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000F2538 File Offset: 0x000F0938
		[SoapDocumentMethod("http://tempuri.org/SectorStatForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SectorStatForDump(int industryNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SectorStatForDump", new object[]
			{
				industryNumber
			});
			return (string)array[0];
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000F2580 File Offset: 0x000F0980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SectorStatForDumpAsync(int industryNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SectorStatForDumpAsync(industryNumber, null);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000F259C File Offset: 0x000F099C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SectorStatForDumpAsync(int industryNumber, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SectorStatForDumpOperationCompleted == null)
			{
				this.SectorStatForDumpOperationCompleted = new SendOrPostCallback(this.OnSectorStatForDumpOperationCompleted);
			}
			base.InvokeAsync("SectorStatForDump", new object[]
			{
				industryNumber
			}, this.SectorStatForDumpOperationCompleted, userState);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000F2604 File Offset: 0x000F0A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSectorStatForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SectorStatForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SectorStatForDumpCompleted(this, new SectorStatForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000F2664 File Offset: 0x000F0A64
		[SoapDocumentMethod("http://tempuri.org/StockStatForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockStatForDump(int sectorNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockStatForDump", new object[]
			{
				sectorNumber
			});
			return (string)array[0];
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000F26AC File Offset: 0x000F0AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockStatForDumpAsync(int sectorNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockStatForDumpAsync(sectorNumber, null);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000F26C8 File Offset: 0x000F0AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockStatForDumpAsync(int sectorNumber, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockStatForDumpOperationCompleted == null)
			{
				this.StockStatForDumpOperationCompleted = new SendOrPostCallback(this.OnStockStatForDumpOperationCompleted);
			}
			base.InvokeAsync("StockStatForDump", new object[]
			{
				sectorNumber
			}, this.StockStatForDumpOperationCompleted, userState);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000F2730 File Offset: 0x000F0B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockStatForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockStatForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockStatForDumpCompleted(this, new StockStatForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000F2790 File Offset: 0x000F0B90
		[SoapDocumentMethod("http://tempuri.org/GetUserConfigForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetUserConfigForDump(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetUserConfigForDump", new object[]
			{
				userId
			});
			return (string)array[0];
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000F27D4 File Offset: 0x000F0BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUserConfigForDumpAsync(string userId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetUserConfigForDumpAsync(userId, null);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x000F27F0 File Offset: 0x000F0BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUserConfigForDumpAsync(string userId, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetUserConfigForDumpOperationCompleted == null)
			{
				this.GetUserConfigForDumpOperationCompleted = new SendOrPostCallback(this.OnGetUserConfigForDumpOperationCompleted);
			}
			base.InvokeAsync("GetUserConfigForDump", new object[]
			{
				userId
			}, this.GetUserConfigForDumpOperationCompleted, userState);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000F2854 File Offset: 0x000F0C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetUserConfigForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetUserConfigForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetUserConfigForDumpCompleted(this, new GetUserConfigForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000F28B4 File Offset: 0x000F0CB4
		[SoapDocumentMethod("http://tempuri.org/SaveUserConfigForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaveUserConfigForDump(string userId, string configName, string configValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveUserConfigForDump", new object[]
			{
				userId,
				configName,
				configValue
			});
			return (string)array[0];
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000F2900 File Offset: 0x000F0D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigForDumpAsync(string userId, string configName, string configValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveUserConfigForDumpAsync(userId, configName, configValue, null);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000F291C File Offset: 0x000F0D1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveUserConfigForDumpAsync(string userId, string configName, string configValue, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveUserConfigForDumpOperationCompleted == null)
			{
				this.SaveUserConfigForDumpOperationCompleted = new SendOrPostCallback(this.OnSaveUserConfigForDumpOperationCompleted);
			}
			base.InvokeAsync("SaveUserConfigForDump", new object[]
			{
				userId,
				configName,
				configValue
			}, this.SaveUserConfigForDumpOperationCompleted, userState);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000F2988 File Offset: 0x000F0D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveUserConfigForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveUserConfigForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveUserConfigForDumpCompleted(this, new SaveUserConfigForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000F29E8 File Offset: 0x000F0DE8
		[SoapDocumentMethod("http://tempuri.org/SaleByTime2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SaleByTime2(int securityNumber, int startRow, int rowPerPage, int maxTicker, string startTime)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaleByTime2", new object[]
			{
				securityNumber,
				startRow,
				rowPerPage,
				maxTicker,
				startTime
			});
			return (string)array[0];
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x000F2A54 File Offset: 0x000F0E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaleByTime2Async(int securityNumber, int startRow, int rowPerPage, int maxTicker, string startTime)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaleByTime2Async(securityNumber, startRow, rowPerPage, maxTicker, startTime, null);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000F2A74 File Offset: 0x000F0E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaleByTime2Async(int securityNumber, int startRow, int rowPerPage, int maxTicker, string startTime, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaleByTime2OperationCompleted == null)
			{
				this.SaleByTime2OperationCompleted = new SendOrPostCallback(this.OnSaleByTime2OperationCompleted);
			}
			base.InvokeAsync("SaleByTime2", new object[]
			{
				securityNumber,
				startRow,
				rowPerPage,
				maxTicker,
				startTime
			}, this.SaleByTime2OperationCompleted, userState);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000F2B00 File Offset: 0x000F0F00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaleByTime2OperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaleByTime2Completed != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaleByTime2Completed(this, new SaleByTime2CompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000F2B60 File Offset: 0x000F0F60
		[SoapDocumentMethod("http://tempuri.org/StockInPlay", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockInPlay(int SecurityNumber, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockInPlay", new object[]
			{
				SecurityNumber,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000F2BCC File Offset: 0x000F0FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayAsync(int SecurityNumber, decimal StartPrice, string Side, int rowPerPage, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockInPlayAsync(SecurityNumber, StartPrice, Side, rowPerPage, maxTicker, null);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000F2BEC File Offset: 0x000F0FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockInPlayAsync(int SecurityNumber, decimal StartPrice, string Side, int rowPerPage, int maxTicker, object userState)
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
				SecurityNumber,
				StartPrice,
				Side,
				rowPerPage,
				maxTicker
			}, this.StockInPlayOperationCompleted, userState);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x000F2C78 File Offset: 0x000F1078
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

		// Token: 0x06000F24 RID: 3876 RVA: 0x000F2CD8 File Offset: 0x000F10D8
		[SoapDocumentMethod("http://tempuri.org/StockByPricePage", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockByPricePage(int stockNumber, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockByPricePage", new object[]
			{
				stockNumber,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000F2D2C File Offset: 0x000F112C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockByPricePageAsync(int stockNumber, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockByPricePageAsync(stockNumber, maxTicker, null);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000F2D48 File Offset: 0x000F1148
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockByPricePageAsync(int stockNumber, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockByPricePageOperationCompleted == null)
			{
				this.StockByPricePageOperationCompleted = new SendOrPostCallback(this.OnStockByPricePageOperationCompleted);
			}
			base.InvokeAsync("StockByPricePage", new object[]
			{
				stockNumber,
				maxTicker
			}, this.StockByPricePageOperationCompleted, userState);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000F2DB8 File Offset: 0x000F11B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockByPricePageOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockByPricePageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockByPricePageCompleted(this, new StockByPricePageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000F2E18 File Offset: 0x000F1218
		[SoapDocumentMethod("http://tempuri.org/MarketStatus", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string MarketStatus()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("MarketStatus", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000F2E58 File Offset: 0x000F1258
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarketStatusAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.MarketStatusAsync(null);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000F2E74 File Offset: 0x000F1274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarketStatusAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.MarketStatusOperationCompleted == null)
			{
				this.MarketStatusOperationCompleted = new SendOrPostCallback(this.OnMarketStatusOperationCompleted);
			}
			base.InvokeAsync("MarketStatus", new object[0], this.MarketStatusOperationCompleted, userState);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000F2ED0 File Offset: 0x000F12D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnMarketStatusOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._MarketStatusCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._MarketStatusCompleted(this, new MarketStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000F2F30 File Offset: 0x000F1330
		[SoapDocumentMethod("http://tempuri.org/TopBBO", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopBBO(int[] stockNumber, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopBBO", new object[]
			{
				stockNumber,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000F2F7C File Offset: 0x000F137C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOAsync(int[] stockNumber, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopBBOAsync(stockNumber, maxTicker, null);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000F2F98 File Offset: 0x000F1398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOAsync(int[] stockNumber, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopBBOOperationCompleted == null)
			{
				this.TopBBOOperationCompleted = new SendOrPostCallback(this.OnTopBBOOperationCompleted);
			}
			base.InvokeAsync("TopBBO", new object[]
			{
				stockNumber,
				maxTicker
			}, this.TopBBOOperationCompleted, userState);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000F3004 File Offset: 0x000F1404
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopBBOOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopBBOCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopBBOCompleted(this, new TopBBOCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000F3064 File Offset: 0x000F1464
		[SoapDocumentMethod("http://tempuri.org/TopBBOad", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TopBBOad(string stocks, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("TopBBOad", new object[]
			{
				stocks,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000F30B0 File Offset: 0x000F14B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOadAsync(string stocks, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.TopBBOadAsync(stocks, maxTicker, null);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000F30CC File Offset: 0x000F14CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopBBOadAsync(string stocks, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.TopBBOadOperationCompleted == null)
			{
				this.TopBBOadOperationCompleted = new SendOrPostCallback(this.OnTopBBOadOperationCompleted);
			}
			base.InvokeAsync("TopBBOad", new object[]
			{
				stocks,
				maxTicker
			}, this.TopBBOadOperationCompleted, userState);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000F3138 File Offset: 0x000F1538
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTopBBOadOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._TopBBOadCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._TopBBOadCompleted(this, new TopBBOadCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000F3198 File Offset: 0x000F1598
		[SoapDocumentMethod("http://tempuri.org/ViewOddlot", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOddlot(int stockNo, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOddlot", new object[]
			{
				stockNo,
				maxTicker
			});
			return (string)array[0];
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000F31EC File Offset: 0x000F15EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOddlotAsync(int stockNo, int maxTicker)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOddlotAsync(stockNo, maxTicker, null);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000F3208 File Offset: 0x000F1608
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOddlotAsync(int stockNo, int maxTicker, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOddlotOperationCompleted == null)
			{
				this.ViewOddlotOperationCompleted = new SendOrPostCallback(this.OnViewOddlotOperationCompleted);
			}
			base.InvokeAsync("ViewOddlot", new object[]
			{
				stockNo,
				maxTicker
			}, this.ViewOddlotOperationCompleted, userState);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000F3278 File Offset: 0x000F1678
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOddlotOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOddlotCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOddlotCompleted(this, new ViewOddlotCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000F32D8 File Offset: 0x000F16D8
		[SoapDocumentMethod("http://tempuri.org/Get5BidOffer", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Get5BidOffer(int stockNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("Get5BidOffer", new object[]
			{
				stockNumber
			});
			return (string)array[0];
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000F3320 File Offset: 0x000F1720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Get5BidOfferAsync(int stockNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Get5BidOfferAsync(stockNumber, null);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000F333C File Offset: 0x000F173C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Get5BidOfferAsync(int stockNumber, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.Get5BidOfferOperationCompleted == null)
			{
				this.Get5BidOfferOperationCompleted = new SendOrPostCallback(this.OnGet5BidOfferOperationCompleted);
			}
			base.InvokeAsync("Get5BidOffer", new object[]
			{
				stockNumber
			}, this.Get5BidOfferOperationCompleted, userState);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000F33A4 File Offset: 0x000F17A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGet5BidOfferOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._Get5BidOfferCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._Get5BidOfferCompleted(this, new Get5BidOfferCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000F3404 File Offset: 0x000F1804
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

		// Token: 0x06000F3D RID: 3901 RVA: 0x000F3490 File Offset: 0x000F1890
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderTransactionAsync(string id, string senderType, int readType, string account, string stock, string side, string price, string status, long startOrderNo, int rowPerPage, int expression)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderTransactionAsync(id, senderType, readType, account, stock, side, price, status, startOrderNo, rowPerPage, expression, null);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000F34C8 File Offset: 0x000F18C8
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

		// Token: 0x06000F3F RID: 3903 RVA: 0x000F3574 File Offset: 0x000F1974
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

		// Token: 0x06000F40 RID: 3904 RVA: 0x000F35D4 File Offset: 0x000F19D4
		[SoapDocumentMethod("http://tempuri.org/ViewOrderHistory", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderHistory(string account, string stock, string side, string selDate1, string selDate2, int compareDays)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderHistory", new object[]
			{
				account,
				stock,
				side,
				selDate1,
				selDate2,
				compareDays
			});
			return (string)array[0];
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000F3634 File Offset: 0x000F1A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderHistoryAsync(string account, string stock, string side, string selDate1, string selDate2, int compareDays)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderHistoryAsync(account, stock, side, selDate1, selDate2, compareDays, null);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000F3664 File Offset: 0x000F1A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderHistoryAsync(string account, string stock, string side, string selDate1, string selDate2, int compareDays, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderHistoryOperationCompleted == null)
			{
				this.ViewOrderHistoryOperationCompleted = new SendOrPostCallback(this.OnViewOrderHistoryOperationCompleted);
			}
			base.InvokeAsync("ViewOrderHistory", new object[]
			{
				account,
				stock,
				side,
				selDate1,
				selDate2,
				compareDays
			}, this.ViewOrderHistoryOperationCompleted, userState);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000F36E4 File Offset: 0x000F1AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderHistoryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderHistoryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderHistoryCompleted(this, new ViewOrderHistoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000F3744 File Offset: 0x000F1B44
		[SoapDocumentMethod("http://tempuri.org/ViewOrdersForDump", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrdersForDump(string account, string stock, string side, string price, string status, long startOrderNumber, int recordPerPage, int page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrdersForDump", new object[]
			{
				account,
				stock,
				side,
				price,
				status,
				startOrderNumber,
				recordPerPage,
				page
			});
			return (string)array[0];
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000F37B8 File Offset: 0x000F1BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrdersForDumpAsync(string account, string stock, string side, string price, string status, long startOrderNumber, int recordPerPage, int page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrdersForDumpAsync(account, stock, side, price, status, startOrderNumber, recordPerPage, page, null);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000F37EC File Offset: 0x000F1BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrdersForDumpAsync(string account, string stock, string side, string price, string status, long startOrderNumber, int recordPerPage, int page, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrdersForDumpOperationCompleted == null)
			{
				this.ViewOrdersForDumpOperationCompleted = new SendOrPostCallback(this.OnViewOrdersForDumpOperationCompleted);
			}
			base.InvokeAsync("ViewOrdersForDump", new object[]
			{
				account,
				stock,
				side,
				price,
				status,
				startOrderNumber,
				recordPerPage,
				page
			}, this.ViewOrdersForDumpOperationCompleted, userState);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000F3880 File Offset: 0x000F1C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrdersForDumpOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrdersForDumpCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrdersForDumpCompleted(this, new ViewOrdersForDumpCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000F38E0 File Offset: 0x000F1CE0
		[SoapDocumentMethod("http://tempuri.org/ViewOrderByOrderNo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderByOrderNo(string account, string orderNoList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderByOrderNo", new object[]
			{
				account,
				orderNoList
			});
			return (string)array[0];
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000F3928 File Offset: 0x000F1D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderByOrderNoAsync(string account, string orderNoList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderByOrderNoAsync(account, orderNoList, null);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000F3944 File Offset: 0x000F1D44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderByOrderNoAsync(string account, string orderNoList, object userState)
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
				orderNoList
			}, this.ViewOrderByOrderNoOperationCompleted, userState);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000F39AC File Offset: 0x000F1DAC
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

		// Token: 0x06000F4C RID: 3916 RVA: 0x000F3A0C File Offset: 0x000F1E0C
		[SoapDocumentMethod("http://tempuri.org/ViewNewsHeader", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewNewsHeader(bool isCurrentDate, string selectDate, string selectStock, int recordPerPage, int page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewNewsHeader", new object[]
			{
				isCurrentDate,
				selectDate,
				selectStock,
				recordPerPage,
				page
			});
			return (string)array[0];
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000F3A70 File Offset: 0x000F1E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewNewsHeaderAsync(bool isCurrentDate, string selectDate, string selectStock, int recordPerPage, int page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewNewsHeaderAsync(isCurrentDate, selectDate, selectStock, recordPerPage, page, null);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000F3A90 File Offset: 0x000F1E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewNewsHeaderAsync(bool isCurrentDate, string selectDate, string selectStock, int recordPerPage, int page, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewNewsHeaderOperationCompleted == null)
			{
				this.ViewNewsHeaderOperationCompleted = new SendOrPostCallback(this.OnViewNewsHeaderOperationCompleted);
			}
			base.InvokeAsync("ViewNewsHeader", new object[]
			{
				isCurrentDate,
				selectDate,
				selectStock,
				recordPerPage,
				page
			}, this.ViewNewsHeaderOperationCompleted, userState);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000F3B14 File Offset: 0x000F1F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewNewsHeaderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewNewsHeaderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewNewsHeaderCompleted(this, new ViewNewsHeaderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000F3B74 File Offset: 0x000F1F74
		[SoapDocumentMethod("http://tempuri.org/ViewNewsStory", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewNewsStory(bool isCurrentDate, string selectDate, long newNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewNewsStory", new object[]
			{
				isCurrentDate,
				selectDate,
				newNo
			});
			return (string)array[0];
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000F3BCC File Offset: 0x000F1FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewNewsStoryAsync(bool isCurrentDate, string selectDate, long newNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewNewsStoryAsync(isCurrentDate, selectDate, newNo, null);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000F3BE8 File Offset: 0x000F1FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewNewsStoryAsync(bool isCurrentDate, string selectDate, long newNo, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewNewsStoryOperationCompleted == null)
			{
				this.ViewNewsStoryOperationCompleted = new SendOrPostCallback(this.OnViewNewsStoryOperationCompleted);
			}
			base.InvokeAsync("ViewNewsStory", new object[]
			{
				isCurrentDate,
				selectDate,
				newNo
			}, this.ViewNewsStoryOperationCompleted, userState);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000F3C60 File Offset: 0x000F2060
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewNewsStoryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewNewsStoryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewNewsStoryCompleted(this, new ViewNewsStoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000F3CC0 File Offset: 0x000F20C0
		[SoapDocumentMethod("http://tempuri.org/ViewCustomersInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomersInfo(string custAccID, string userLoginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomersInfo", new object[]
			{
				custAccID,
				userLoginID
			});
			return (string)array[0];
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000F3D08 File Offset: 0x000F2108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersInfoAsync(string custAccID, string userLoginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomersInfoAsync(custAccID, userLoginID, null);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000F3D24 File Offset: 0x000F2124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomersInfoAsync(string custAccID, string userLoginID, object userState)
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
				custAccID,
				userLoginID
			}, this.ViewCustomersInfoOperationCompleted, userState);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000F3D8C File Offset: 0x000F218C
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

		// Token: 0x06000F58 RID: 3928 RVA: 0x000F3DEC File Offset: 0x000F21EC
		[SoapDocumentMethod("http://tempuri.org/ViewCustomerCreditOnSendBox_Freewill", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomerCreditOnSendBox_Freewill(string account, string accType, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomerCreditOnSendBox_Freewill", new object[]
			{
				account,
				accType,
				stock
			});
			return (string)array[0];
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000F3E38 File Offset: 0x000F2238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerCreditOnSendBox_FreewillAsync(string account, string accType, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomerCreditOnSendBox_FreewillAsync(account, accType, stock, null);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000F3E54 File Offset: 0x000F2254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerCreditOnSendBox_FreewillAsync(string account, string accType, string stock, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomerCreditOnSendBox_FreewillOperationCompleted == null)
			{
				this.ViewCustomerCreditOnSendBox_FreewillOperationCompleted = new SendOrPostCallback(this.OnViewCustomerCreditOnSendBox_FreewillOperationCompleted);
			}
			base.InvokeAsync("ViewCustomerCreditOnSendBox_Freewill", new object[]
			{
				account,
				accType,
				stock
			}, this.ViewCustomerCreditOnSendBox_FreewillOperationCompleted, userState);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000F3EC0 File Offset: 0x000F22C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomerCreditOnSendBox_FreewillOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomerCreditOnSendBox_FreewillCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomerCreditOnSendBox_FreewillCompleted(this, new ViewCustomerCreditOnSendBox_FreewillCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000F3F20 File Offset: 0x000F2320
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

		// Token: 0x06000F5D RID: 3933 RVA: 0x000F3F68 File Offset: 0x000F2368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomerCreditOnSendBoxAsync(string account, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomerCreditOnSendBoxAsync(account, stock, null);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000F3F84 File Offset: 0x000F2384
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

		// Token: 0x06000F5F RID: 3935 RVA: 0x000F3FEC File Offset: 0x000F23EC
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

		// Token: 0x06000F60 RID: 3936 RVA: 0x000F404C File Offset: 0x000F244C
		[SoapDocumentMethod("http://tempuri.org/GetSwitchAccountInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSwitchAccountInfo(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetSwitchAccountInfo", new object[]
			{
				account
			});
			return (string)array[0];
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000F4090 File Offset: 0x000F2490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSwitchAccountInfoAsync(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetSwitchAccountInfoAsync(account, null);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000F40AC File Offset: 0x000F24AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetSwitchAccountInfoAsync(string account, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetSwitchAccountInfoOperationCompleted == null)
			{
				this.GetSwitchAccountInfoOperationCompleted = new SendOrPostCallback(this.OnGetSwitchAccountInfoOperationCompleted);
			}
			base.InvokeAsync("GetSwitchAccountInfo", new object[]
			{
				account
			}, this.GetSwitchAccountInfoOperationCompleted, userState);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000F4110 File Offset: 0x000F2510
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetSwitchAccountInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetSwitchAccountInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetSwitchAccountInfoCompleted(this, new GetSwitchAccountInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x000F4170 File Offset: 0x000F2570
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_MobileReportAll", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_MobileReportAll(string custAccID, string stockSymbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_MobileReportAll", new object[]
			{
				custAccID,
				stockSymbol
			});
			return (string)array[0];
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000F41B8 File Offset: 0x000F25B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_MobileReportAllAsync(string custAccID, string stockSymbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_MobileReportAllAsync(custAccID, stockSymbol, null);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000F41D4 File Offset: 0x000F25D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_MobileReportAllAsync(string custAccID, string stockSymbol, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_MobileReportAllOperationCompleted == null)
			{
				this.ViewCustomer_MobileReportAllOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_MobileReportAllOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_MobileReportAll", new object[]
			{
				custAccID,
				stockSymbol
			}, this.ViewCustomer_MobileReportAllOperationCompleted, userState);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000F423C File Offset: 0x000F263C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_MobileReportAllOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_MobileReportAllCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_MobileReportAllCompleted(this, new ViewCustomer_MobileReportAllCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000F429C File Offset: 0x000F269C
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_OrdersConfirms", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_OrdersConfirms(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_OrdersConfirms", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000F42F8 File Offset: 0x000F26F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_OrdersConfirmsAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_OrdersConfirmsAsync(custAccID, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000F4318 File Offset: 0x000F2718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_OrdersConfirmsAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_OrdersConfirmsOperationCompleted == null)
			{
				this.ViewCustomer_OrdersConfirmsOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_OrdersConfirmsOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_OrdersConfirms", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_OrdersConfirmsOperationCompleted, userState);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000F4394 File Offset: 0x000F2794
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_OrdersConfirmsOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_OrdersConfirmsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_OrdersConfirmsCompleted(this, new ViewCustomer_OrdersConfirmsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000F43F4 File Offset: 0x000F27F4
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_CreditPosition", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_CreditPosition(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_CreditPosition", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000F4450 File Offset: 0x000F2850
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_CreditPositionAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_CreditPositionAsync(custAccID, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000F4470 File Offset: 0x000F2870
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_CreditPositionAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_CreditPositionOperationCompleted == null)
			{
				this.ViewCustomer_CreditPositionOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_CreditPositionOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_CreditPosition", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_CreditPositionOperationCompleted, userState);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000F44EC File Offset: 0x000F28EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_CreditPositionOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_CreditPositionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_CreditPositionCompleted(this, new ViewCustomer_CreditPositionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000F454C File Offset: 0x000F294C
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_ProjectedProfitLoss", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_ProjectedProfitLoss(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_ProjectedProfitLoss", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000F45A8 File Offset: 0x000F29A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ProjectedProfitLossAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_ProjectedProfitLossAsync(custAccID, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000F45C8 File Offset: 0x000F29C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ProjectedProfitLossAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_ProjectedProfitLossOperationCompleted == null)
			{
				this.ViewCustomer_ProjectedProfitLossOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_ProjectedProfitLossOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_ProjectedProfitLoss", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_ProjectedProfitLossOperationCompleted, userState);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000F4644 File Offset: 0x000F2A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_ProjectedProfitLossOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_ProjectedProfitLossCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_ProjectedProfitLossCompleted(this, new ViewCustomer_ProjectedProfitLossCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000F46A4 File Offset: 0x000F2AA4
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_FScoreAnalysis", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_FScoreAnalysis(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_FScoreAnalysis", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000F46E8 File Offset: 0x000F2AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_FScoreAnalysisAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_FScoreAnalysisAsync(custAccID, null);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x000F4704 File Offset: 0x000F2B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_FScoreAnalysisAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_FScoreAnalysisOperationCompleted == null)
			{
				this.ViewCustomer_FScoreAnalysisOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_FScoreAnalysisOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_FScoreAnalysis", new object[]
			{
				custAccID
			}, this.ViewCustomer_FScoreAnalysisOperationCompleted, userState);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000F4768 File Offset: 0x000F2B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_FScoreAnalysisOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_FScoreAnalysisCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_FScoreAnalysisCompleted(this, new ViewCustomer_FScoreAnalysisCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000F47C8 File Offset: 0x000F2BC8
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_BetaAnalysis", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_BetaAnalysis(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_BetaAnalysis", new object[]
			{
				custAccID
			});
			return (string)array[0];
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000F480C File Offset: 0x000F2C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_BetaAnalysisAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_BetaAnalysisAsync(custAccID, null);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000F4828 File Offset: 0x000F2C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_BetaAnalysisAsync(string custAccID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_BetaAnalysisOperationCompleted == null)
			{
				this.ViewCustomer_BetaAnalysisOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_BetaAnalysisOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_BetaAnalysis", new object[]
			{
				custAccID
			}, this.ViewCustomer_BetaAnalysisOperationCompleted, userState);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000F488C File Offset: 0x000F2C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_BetaAnalysisOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_BetaAnalysisCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_BetaAnalysisCompleted(this, new ViewCustomer_BetaAnalysisCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000F48EC File Offset: 0x000F2CEC
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

		// Token: 0x06000F7D RID: 3965 RVA: 0x000F4930 File Offset: 0x000F2D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RiskManagementAsync(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_RiskManagementAsync(custAccID, null);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000F494C File Offset: 0x000F2D4C
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

		// Token: 0x06000F7F RID: 3967 RVA: 0x000F49B0 File Offset: 0x000F2DB0
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

		// Token: 0x06000F80 RID: 3968 RVA: 0x000F4A10 File Offset: 0x000F2E10
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_RiskManagement_SaveValue", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_RiskManagement_SaveValue(string custAccId, string[] items)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_RiskManagement_SaveValue", new object[]
			{
				custAccId,
				items
			});
			return (string)array[0];
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000F4A58 File Offset: 0x000F2E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RiskManagement_SaveValueAsync(string custAccId, string[] items)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_RiskManagement_SaveValueAsync(custAccId, items, null);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000F4A74 File Offset: 0x000F2E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RiskManagement_SaveValueAsync(string custAccId, string[] items, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_RiskManagement_SaveValueOperationCompleted == null)
			{
				this.ViewCustomer_RiskManagement_SaveValueOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_RiskManagement_SaveValueOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_RiskManagement_SaveValue", new object[]
			{
				custAccId,
				items
			}, this.ViewCustomer_RiskManagement_SaveValueOperationCompleted, userState);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000F4ADC File Offset: 0x000F2EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_RiskManagement_SaveValueOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_RiskManagement_SaveValueCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_RiskManagement_SaveValueCompleted(this, new ViewCustomer_RiskManagement_SaveValueCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000F4B3C File Offset: 0x000F2F3C
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_RealizeProfitLoss", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_RealizeProfitLoss(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_RealizeProfitLoss", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000F4B98 File Offset: 0x000F2F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RealizeProfitLossAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_RealizeProfitLossAsync(custAccID, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000F4BB8 File Offset: 0x000F2FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_RealizeProfitLossAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_RealizeProfitLossOperationCompleted == null)
			{
				this.ViewCustomer_RealizeProfitLossOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_RealizeProfitLossOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_RealizeProfitLoss", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_RealizeProfitLossOperationCompleted, userState);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000F4C34 File Offset: 0x000F3034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_RealizeProfitLossOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_RealizeProfitLossCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_RealizeProfitLossCompleted(this, new ViewCustomer_RealizeProfitLossCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000F4C94 File Offset: 0x000F3094
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_Summary", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_Summary(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_Summary", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000F4CF0 File Offset: 0x000F30F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_SummaryAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_SummaryAsync(custAccID, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000F4D10 File Offset: 0x000F3110
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_SummaryAsync(string custAccID, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_SummaryOperationCompleted == null)
			{
				this.ViewCustomer_SummaryOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_SummaryOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_Summary", new object[]
			{
				custAccID,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_SummaryOperationCompleted, userState);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000F4D8C File Offset: 0x000F318C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_SummaryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_SummaryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_SummaryCompleted(this, new ViewCustomer_SummaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000F4DEC File Offset: 0x000F31EC
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_ConfirmSummary", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_ConfirmSummary(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_ConfirmSummary", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000F4E50 File Offset: 0x000F3250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmSummaryAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_ConfirmSummaryAsync(custAccID, commGroup, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000F4E70 File Offset: 0x000F3270
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmSummaryAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_ConfirmSummaryOperationCompleted == null)
			{
				this.ViewCustomer_ConfirmSummaryOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_ConfirmSummaryOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_ConfirmSummary", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_ConfirmSummaryOperationCompleted, userState);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000F4EF4 File Offset: 0x000F32F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_ConfirmSummaryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_ConfirmSummaryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_ConfirmSummaryCompleted(this, new ViewCustomer_ConfirmSummaryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000F4F54 File Offset: 0x000F3354
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_Confirm", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_Confirm(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_Confirm", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000F4FB8 File Offset: 0x000F33B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_ConfirmAsync(custAccID, commGroup, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000F4FD8 File Offset: 0x000F33D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_ConfirmOperationCompleted == null)
			{
				this.ViewCustomer_ConfirmOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_ConfirmOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_Confirm", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_ConfirmOperationCompleted, userState);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000F505C File Offset: 0x000F345C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_ConfirmOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_ConfirmCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_ConfirmCompleted(this, new ViewCustomer_ConfirmCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000F50BC File Offset: 0x000F34BC
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_ConfirmByDealID", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_ConfirmByDealID(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_ConfirmByDealID", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000F5120 File Offset: 0x000F3520
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmByDealIDAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_ConfirmByDealIDAsync(custAccID, commGroup, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000F5140 File Offset: 0x000F3540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmByDealIDAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_ConfirmByDealIDOperationCompleted == null)
			{
				this.ViewCustomer_ConfirmByDealIDOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_ConfirmByDealIDOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_ConfirmByDealID", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_ConfirmByDealIDOperationCompleted, userState);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000F51C4 File Offset: 0x000F35C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_ConfirmByDealIDOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_ConfirmByDealIDCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_ConfirmByDealIDCompleted(this, new ViewCustomer_ConfirmByDealIDCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000F5224 File Offset: 0x000F3624
		[SoapDocumentMethod("http://tempuri.org/ViewCustomer_ConfirmByStock", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewCustomer_ConfirmByStock(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewCustomer_ConfirmByStock", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000F5288 File Offset: 0x000F3688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmByStockAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewCustomer_ConfirmByStockAsync(custAccID, commGroup, stockSymbol, startRow, rowPerPage, null);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000F52A8 File Offset: 0x000F36A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewCustomer_ConfirmByStockAsync(string custAccID, int commGroup, string stockSymbol, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewCustomer_ConfirmByStockOperationCompleted == null)
			{
				this.ViewCustomer_ConfirmByStockOperationCompleted = new SendOrPostCallback(this.OnViewCustomer_ConfirmByStockOperationCompleted);
			}
			base.InvokeAsync("ViewCustomer_ConfirmByStock", new object[]
			{
				custAccID,
				commGroup,
				stockSymbol,
				startRow,
				rowPerPage
			}, this.ViewCustomer_ConfirmByStockOperationCompleted, userState);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000F532C File Offset: 0x000F372C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewCustomer_ConfirmByStockOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewCustomer_ConfirmByStockCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewCustomer_ConfirmByStockCompleted(this, new ViewCustomer_ConfirmByStockCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000F538C File Offset: 0x000F378C
		[SoapDocumentMethod("http://tempuri.org/ViewOrderInfo_AfterCloseFw", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderInfo_AfterCloseFw(long orderNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderInfo_AfterCloseFw", new object[]
			{
				orderNumber
			});
			return (string)array[0];
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000F53D4 File Offset: 0x000F37D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderInfo_AfterCloseFwAsync(long orderNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderInfo_AfterCloseFwAsync(orderNumber, null);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000F53F0 File Offset: 0x000F37F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderInfo_AfterCloseFwAsync(long orderNumber, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderInfo_AfterCloseFwOperationCompleted == null)
			{
				this.ViewOrderInfo_AfterCloseFwOperationCompleted = new SendOrPostCallback(this.OnViewOrderInfo_AfterCloseFwOperationCompleted);
			}
			base.InvokeAsync("ViewOrderInfo_AfterCloseFw", new object[]
			{
				orderNumber
			}, this.ViewOrderInfo_AfterCloseFwOperationCompleted, userState);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000F5458 File Offset: 0x000F3858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderInfo_AfterCloseFwOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderInfo_AfterCloseFwCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderInfo_AfterCloseFwCompleted(this, new ViewOrderInfo_AfterCloseFwCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000F54B8 File Offset: 0x000F38B8
		[SoapDocumentMethod("http://tempuri.org/ViewOrderDealData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderDealData(string sSendDate, long orderNumber, int startRow, int rowPerPage, int dbType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderDealData", new object[]
			{
				sSendDate,
				orderNumber,
				startRow,
				rowPerPage,
				dbType
			});
			return (string)array[0];
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000F5524 File Offset: 0x000F3924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataAsync(string sSendDate, long orderNumber, int startRow, int rowPerPage, int dbType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderDealDataAsync(sSendDate, orderNumber, startRow, rowPerPage, dbType, null);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000F5544 File Offset: 0x000F3944
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataAsync(string sSendDate, long orderNumber, int startRow, int rowPerPage, int dbType, object userState)
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
				sSendDate,
				orderNumber,
				startRow,
				rowPerPage,
				dbType
			}, this.ViewOrderDealDataOperationCompleted, userState);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000F55D0 File Offset: 0x000F39D0
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

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000F5630 File Offset: 0x000F3A30
		[SoapDocumentMethod("http://tempuri.org/ViewOrderDealDataHistory", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ViewOrderDealDataHistory(string sSendDate, long orderNumber, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ViewOrderDealDataHistory", new object[]
			{
				sSendDate,
				orderNumber,
				startRow,
				rowPerPage
			});
			return (string)array[0];
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000F5690 File Offset: 0x000F3A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataHistoryAsync(string sSendDate, long orderNumber, int startRow, int rowPerPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderDealDataHistoryAsync(sSendDate, orderNumber, startRow, rowPerPage, null);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000F56B0 File Offset: 0x000F3AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewOrderDealDataHistoryAsync(string sSendDate, long orderNumber, int startRow, int rowPerPage, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ViewOrderDealDataHistoryOperationCompleted == null)
			{
				this.ViewOrderDealDataHistoryOperationCompleted = new SendOrPostCallback(this.OnViewOrderDealDataHistoryOperationCompleted);
			}
			base.InvokeAsync("ViewOrderDealDataHistory", new object[]
			{
				sSendDate,
				orderNumber,
				startRow,
				rowPerPage
			}, this.ViewOrderDealDataHistoryOperationCompleted, userState);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000F5730 File Offset: 0x000F3B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnViewOrderDealDataHistoryOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ViewOrderDealDataHistoryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ViewOrderDealDataHistoryCompleted(this, new ViewOrderDealDataHistoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000F5790 File Offset: 0x000F3B90
		[SoapDocumentMethod("http://tempuri.org/GetCometInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetCometInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetCometInfo", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000F57D0 File Offset: 0x000F3BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetCometInfoAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetCometInfoAsync(null);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000F57EC File Offset: 0x000F3BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetCometInfoAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetCometInfoOperationCompleted == null)
			{
				this.GetCometInfoOperationCompleted = new SendOrPostCallback(this.OnGetCometInfoOperationCompleted);
			}
			base.InvokeAsync("GetCometInfo", new object[0], this.GetCometInfoOperationCompleted, userState);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000F5848 File Offset: 0x000F3C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetCometInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetCometInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetCometInfoCompleted(this, new GetCometInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000F58A8 File Offset: 0x000F3CA8
		[SoapDocumentMethod("http://tempuri.org/GetTunnelConfig", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetTunnelConfig()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetTunnelConfig", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000F58E8 File Offset: 0x000F3CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTunnelConfigAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetTunnelConfigAsync(null);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000F5904 File Offset: 0x000F3D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTunnelConfigAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetTunnelConfigOperationCompleted == null)
			{
				this.GetTunnelConfigOperationCompleted = new SendOrPostCallback(this.OnGetTunnelConfigOperationCompleted);
			}
			base.InvokeAsync("GetTunnelConfig", new object[0], this.GetTunnelConfigOperationCompleted, userState);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000F5960 File Offset: 0x000F3D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetTunnelConfigOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetTunnelConfigCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetTunnelConfigCompleted(this, new GetTunnelConfigCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000F59C0 File Offset: 0x000F3DC0
		[SoapDocumentMethod("http://tempuri.org/GetTunnel", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetTunnel(bool isRequestTfex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetTunnel", new object[]
			{
				isRequestTfex
			});
			return (string)array[0];
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000F5A08 File Offset: 0x000F3E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTunnelAsync(bool isRequestTfex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetTunnelAsync(isRequestTfex, null);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000F5A24 File Offset: 0x000F3E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTunnelAsync(bool isRequestTfex, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetTunnelOperationCompleted == null)
			{
				this.GetTunnelOperationCompleted = new SendOrPostCallback(this.OnGetTunnelOperationCompleted);
			}
			base.InvokeAsync("GetTunnel", new object[]
			{
				isRequestTfex
			}, this.GetTunnelOperationCompleted, userState);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000F5A8C File Offset: 0x000F3E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetTunnelOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetTunnelCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetTunnelCompleted(this, new GetTunnelCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000F5AEC File Offset: 0x000F3EEC
		[SoapDocumentMethod("http://tempuri.org/VerifyOrder", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string VerifyOrder(string stock, string side, long volume, string price, string account, bool isValidatePolicy)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("VerifyOrder", new object[]
			{
				stock,
				side,
				volume,
				price,
				account,
				isValidatePolicy
			});
			return (string)array[0];
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000F5B50 File Offset: 0x000F3F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderAsync(string stock, string side, long volume, string price, string account, bool isValidatePolicy)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.VerifyOrderAsync(stock, side, volume, price, account, isValidatePolicy, null);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000F5B80 File Offset: 0x000F3F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderAsync(string stock, string side, long volume, string price, string account, bool isValidatePolicy, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.VerifyOrderOperationCompleted == null)
			{
				this.VerifyOrderOperationCompleted = new SendOrPostCallback(this.OnVerifyOrderOperationCompleted);
			}
			base.InvokeAsync("VerifyOrder", new object[]
			{
				stock,
				side,
				volume,
				price,
				account,
				isValidatePolicy
			}, this.VerifyOrderOperationCompleted, userState);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000F5C04 File Offset: 0x000F4004
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnVerifyOrderOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._VerifyOrderCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._VerifyOrderCompleted(this, new VerifyOrderCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000F5C64 File Offset: 0x000F4064
		[SoapDocumentMethod("http://tempuri.org/VerifyOrderFw", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string VerifyOrderFw(string stock, string side, long volume, string price, long pubVol, string condition)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("VerifyOrderFw", new object[]
			{
				stock,
				side,
				volume,
				price,
				pubVol,
				condition
			});
			return (string)array[0];
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000F5CC8 File Offset: 0x000F40C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderFwAsync(string stock, string side, long volume, string price, long pubVol, string condition)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.VerifyOrderFwAsync(stock, side, volume, price, pubVol, condition, null);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000F5CF8 File Offset: 0x000F40F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderFwAsync(string stock, string side, long volume, string price, long pubVol, string condition, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.VerifyOrderFwOperationCompleted == null)
			{
				this.VerifyOrderFwOperationCompleted = new SendOrPostCallback(this.OnVerifyOrderFwOperationCompleted);
			}
			base.InvokeAsync("VerifyOrderFw", new object[]
			{
				stock,
				side,
				volume,
				price,
				pubVol,
				condition
			}, this.VerifyOrderFwOperationCompleted, userState);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000F5D7C File Offset: 0x000F417C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnVerifyOrderFwOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._VerifyOrderFwCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._VerifyOrderFwCompleted(this, new VerifyOrderFwCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000F5DDC File Offset: 0x000F41DC
		[SoapDocumentMethod("http://tempuri.org/VerifyOrderMkt", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string VerifyOrderMkt()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("VerifyOrderMkt", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000F5E1C File Offset: 0x000F421C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderMktAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.VerifyOrderMktAsync(null);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000F5E38 File Offset: 0x000F4238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyOrderMktAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.VerifyOrderMktOperationCompleted == null)
			{
				this.VerifyOrderMktOperationCompleted = new SendOrPostCallback(this.OnVerifyOrderMktOperationCompleted);
			}
			base.InvokeAsync("VerifyOrderMkt", new object[0], this.VerifyOrderMktOperationCompleted, userState);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000F5E94 File Offset: 0x000F4294
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnVerifyOrderMktOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._VerifyOrderMktCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._VerifyOrderMktCompleted(this, new VerifyOrderMktCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000F5EF4 File Offset: 0x000F42F4
		[SoapDocumentMethod("http://tempuri.org/GetMainInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetMainInfo(string userId, string userKey, string localIp)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetMainInfo", new object[]
			{
				userId,
				userKey,
				localIp
			});
			return (string)array[0];
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000F5F40 File Offset: 0x000F4340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetMainInfoAsync(string userId, string userKey, string localIp)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetMainInfoAsync(userId, userKey, localIp, null);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000F5F5C File Offset: 0x000F435C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetMainInfoAsync(string userId, string userKey, string localIp, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetMainInfoOperationCompleted == null)
			{
				this.GetMainInfoOperationCompleted = new SendOrPostCallback(this.OnGetMainInfoOperationCompleted);
			}
			base.InvokeAsync("GetMainInfo", new object[]
			{
				userId,
				userKey,
				localIp
			}, this.GetMainInfoOperationCompleted, userState);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000F5FC8 File Offset: 0x000F43C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetMainInfoOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetMainInfoCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetMainInfoCompleted(this, new GetMainInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000F6028 File Offset: 0x000F4428
		[SoapDocumentMethod("http://tempuri.org/UserAuthen", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string UserAuthen(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("UserAuthen", new object[]
			{
				message
			});
			return (string)array[0];
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000F606C File Offset: 0x000F446C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UserAuthenAsync(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.UserAuthenAsync(message, null);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000F6088 File Offset: 0x000F4488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UserAuthenAsync(string message, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.UserAuthenOperationCompleted == null)
			{
				this.UserAuthenOperationCompleted = new SendOrPostCallback(this.OnUserAuthenOperationCompleted);
			}
			base.InvokeAsync("UserAuthen", new object[]
			{
				message
			}, this.UserAuthenOperationCompleted, userState);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000F60EC File Offset: 0x000F44EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnUserAuthenOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._UserAuthenCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._UserAuthenCompleted(this, new UserAuthenCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000F614C File Offset: 0x000F454C
		[SoapDocumentMethod("http://tempuri.org/ClearEfinSession", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ClearEfinSession(string userefin)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ClearEfinSession", new object[]
			{
				userefin
			});
			return (bool)array[0];
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000F6190 File Offset: 0x000F4590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEfinSessionAsync(string userefin)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ClearEfinSessionAsync(userefin, null);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000F61AC File Offset: 0x000F45AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEfinSessionAsync(string userefin, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ClearEfinSessionOperationCompleted == null)
			{
				this.ClearEfinSessionOperationCompleted = new SendOrPostCallback(this.OnClearEfinSessionOperationCompleted);
			}
			base.InvokeAsync("ClearEfinSession", new object[]
			{
				userefin
			}, this.ClearEfinSessionOperationCompleted, userState);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000F6210 File Offset: 0x000F4610
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnClearEfinSessionOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ClearEfinSessionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ClearEfinSessionCompleted(this, new ClearEfinSessionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000F6270 File Offset: 0x000F4670
		[SoapDocumentMethod("http://tempuri.org/GetUrlClient", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetUrlClient()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("GetUrlClient", new object[0]);
			return (string)array[0];
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000F62B0 File Offset: 0x000F46B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUrlClientAsync()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetUrlClientAsync(null);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000F62CC File Offset: 0x000F46CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetUrlClientAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.GetUrlClientOperationCompleted == null)
			{
				this.GetUrlClientOperationCompleted = new SendOrPostCallback(this.OnGetUrlClientOperationCompleted);
			}
			base.InvokeAsync("GetUrlClient", new object[0], this.GetUrlClientOperationCompleted, userState);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000F6328 File Offset: 0x000F4728
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGetUrlClientOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._GetUrlClientCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._GetUrlClientCompleted(this, new GetUrlClientCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000F6388 File Offset: 0x000F4788
		[SoapDocumentMethod("http://tempuri.org/Logout", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Logout(int sessionID, string loginMode, string userLoginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Invoke("Logout", new object[]
			{
				sessionID,
				loginMode,
				userLoginID
			});
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000F63CC File Offset: 0x000F47CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutAsync(int sessionID, string loginMode, string userLoginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LogoutAsync(sessionID, loginMode, userLoginID, null);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000F63E8 File Offset: 0x000F47E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutAsync(int sessionID, string loginMode, string userLoginID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LogoutOperationCompleted == null)
			{
				this.LogoutOperationCompleted = new SendOrPostCallback(this.OnLogoutOperationCompleted);
			}
			base.InvokeAsync("Logout", new object[]
			{
				sessionID,
				loginMode,
				userLoginID
			}, this.LogoutOperationCompleted, userState);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000F6458 File Offset: 0x000F4858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLogoutOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LogoutCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LogoutCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000F64B4 File Offset: 0x000F48B4
		[SoapDocumentMethod("http://tempuri.org/LogoutAD", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutAD(int sessionID, string loginMode, string userLoginID, string brokerParams)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Invoke("LogoutAD", new object[]
			{
				sessionID,
				loginMode,
				userLoginID,
				brokerParams
			});
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000F64FC File Offset: 0x000F48FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutADAsync(int sessionID, string loginMode, string userLoginID, string brokerParams)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LogoutADAsync(sessionID, loginMode, userLoginID, brokerParams, null);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000F651C File Offset: 0x000F491C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutADAsync(int sessionID, string loginMode, string userLoginID, string brokerParams, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.LogoutADOperationCompleted == null)
			{
				this.LogoutADOperationCompleted = new SendOrPostCallback(this.OnLogoutADOperationCompleted);
			}
			base.InvokeAsync("LogoutAD", new object[]
			{
				sessionID,
				loginMode,
				userLoginID,
				brokerParams
			}, this.LogoutADOperationCompleted, userState);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000F6594 File Offset: 0x000F4994
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLogoutADOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._LogoutADCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._LogoutADCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000F65F0 File Offset: 0x000F49F0
		[SoapDocumentMethod("http://tempuri.org/ChangeCustomerPassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangeCustomerPassword(string custAccID, string oldPassword, string newPassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ChangeCustomerPassword", new object[]
			{
				custAccID,
				oldPassword,
				newPassword
			});
			return (bool)array[0];
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000F663C File Offset: 0x000F4A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeCustomerPasswordAsync(string custAccID, string oldPassword, string newPassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ChangeCustomerPasswordAsync(custAccID, oldPassword, newPassword, null);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000F6658 File Offset: 0x000F4A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeCustomerPasswordAsync(string custAccID, string oldPassword, string newPassword, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ChangeCustomerPasswordOperationCompleted == null)
			{
				this.ChangeCustomerPasswordOperationCompleted = new SendOrPostCallback(this.OnChangeCustomerPasswordOperationCompleted);
			}
			base.InvokeAsync("ChangeCustomerPassword", new object[]
			{
				custAccID,
				oldPassword,
				newPassword
			}, this.ChangeCustomerPasswordOperationCompleted, userState);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000F66C4 File Offset: 0x000F4AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnChangeCustomerPasswordOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ChangeCustomerPasswordCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ChangeCustomerPasswordCompleted(this, new ChangeCustomerPasswordCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000F6724 File Offset: 0x000F4B24
		[SoapDocumentMethod("http://tempuri.org/ChangeTraderPassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangeTraderPassword(string traderID, string oldPassword, string newPassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("ChangeTraderPassword", new object[]
			{
				traderID,
				oldPassword,
				newPassword
			});
			return (bool)array[0];
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000F6770 File Offset: 0x000F4B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeTraderPasswordAsync(string traderID, string oldPassword, string newPassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ChangeTraderPasswordAsync(traderID, oldPassword, newPassword, null);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000F678C File Offset: 0x000F4B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeTraderPasswordAsync(string traderID, string oldPassword, string newPassword, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.ChangeTraderPasswordOperationCompleted == null)
			{
				this.ChangeTraderPasswordOperationCompleted = new SendOrPostCallback(this.OnChangeTraderPasswordOperationCompleted);
			}
			base.InvokeAsync("ChangeTraderPassword", new object[]
			{
				traderID,
				oldPassword,
				newPassword
			}, this.ChangeTraderPasswordOperationCompleted, userState);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000F67F8 File Offset: 0x000F4BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnChangeTraderPasswordOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._ChangeTraderPasswordCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._ChangeTraderPasswordCompleted(this, new ChangeTraderPasswordCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000F6858 File Offset: 0x000F4C58
		[SoapDocumentMethod("http://tempuri.org/StockThresholdInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string StockThresholdInformation(string loginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("StockThresholdInformation", new object[]
			{
				loginID
			});
			return (string)array[0];
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000F689C File Offset: 0x000F4C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockThresholdInformationAsync(string loginID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.StockThresholdInformationAsync(loginID, null);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000F68B8 File Offset: 0x000F4CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StockThresholdInformationAsync(string loginID, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.StockThresholdInformationOperationCompleted == null)
			{
				this.StockThresholdInformationOperationCompleted = new SendOrPostCallback(this.OnStockThresholdInformationOperationCompleted);
			}
			base.InvokeAsync("StockThresholdInformation", new object[]
			{
				loginID
			}, this.StockThresholdInformationOperationCompleted, userState);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x000F691C File Offset: 0x000F4D1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnStockThresholdInformationOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._StockThresholdInformationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._StockThresholdInformationCompleted(this, new StockThresholdInformationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000F697C File Offset: 0x000F4D7C
		[SoapDocumentMethod("http://tempuri.org/SaveStockThreshold", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SaveStockThreshold(string customerId, string items)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			object[] array = base.Invoke("SaveStockThreshold", new object[]
			{
				customerId,
				items
			});
			return (bool)array[0];
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000F69C4 File Offset: 0x000F4DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockThresholdAsync(string customerId, string items)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveStockThresholdAsync(customerId, items, null);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000F69E0 File Offset: 0x000F4DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveStockThresholdAsync(string customerId, string items, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.SaveStockThresholdOperationCompleted == null)
			{
				this.SaveStockThresholdOperationCompleted = new SendOrPostCallback(this.OnSaveStockThresholdOperationCompleted);
			}
			base.InvokeAsync("SaveStockThreshold", new object[]
			{
				customerId,
				items
			}, this.SaveStockThresholdOperationCompleted, userState);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000F6A48 File Offset: 0x000F4E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSaveStockThresholdOperationCompleted(object arg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._SaveStockThresholdCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this._SaveStockThresholdCompleted(this, new SaveStockThresholdCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x000F6AA8 File Offset: 0x000F4EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void CancelAsync(object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.CancelAsync(userState);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000F6AC4 File Offset: 0x000F4EC4
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

		// Token: 0x04000858 RID: 2136
		private SendOrPostCallback SendNewOrderOperationCompleted;

		// Token: 0x04000859 RID: 2137
		private SendOrPostCallback SendCancelOrder_AfterCloseFwOperationCompleted;

		// Token: 0x0400085A RID: 2138
		private SendOrPostCallback SendCancelOrderOperationCompleted;

		// Token: 0x0400085B RID: 2139
		private SendOrPostCallback SendEditOrderOperationCompleted;

		// Token: 0x0400085C RID: 2140
		private SendOrPostCallback CountOrderCancelForDumpOperationCompleted;

		// Token: 0x0400085D RID: 2141
		private SendOrPostCallback ViewCustomerByStockForDumpOperationCompleted;

		// Token: 0x0400085E RID: 2142
		private SendOrPostCallback GetBrokerMarginVolumeOperationCompleted;

		// Token: 0x0400085F RID: 2143
		private SendOrPostCallback VerifyPincode2OperationCompleted;

		// Token: 0x04000860 RID: 2144
		private SendOrPostCallback ViewBAMessageOperationCompleted;

		// Token: 0x04000861 RID: 2145
		private SendOrPostCallback StockHistoryOperationCompleted;

		// Token: 0x04000862 RID: 2146
		private SendOrPostCallback StockChartOperationCompleted;

		// Token: 0x04000863 RID: 2147
		private SendOrPostCallback StockHistDataOperationCompleted;

		// Token: 0x04000864 RID: 2148
		private SendOrPostCallback LoadStockNicknameOperationCompleted;

		// Token: 0x04000865 RID: 2149
		private SendOrPostCallback SaveStockNicknameOperationCompleted;

		// Token: 0x04000866 RID: 2150
		private SendOrPostCallback DeleteStockNicknameOperationCompleted;

		// Token: 0x04000867 RID: 2151
		private SendOrPostCallback LoadStockNicknameExtraOperationCompleted;

		// Token: 0x04000868 RID: 2152
		private SendOrPostCallback SaveStockNicknameExtraOperationCompleted;

		// Token: 0x04000869 RID: 2153
		private SendOrPostCallback DeleteStockNicknameExtraOperationCompleted;

		// Token: 0x0400086A RID: 2154
		private SendOrPostCallback IntradayChartOperationCompleted;

		// Token: 0x0400086B RID: 2155
		private SendOrPostCallback IntradayIndexChartOperationCompleted;

		// Token: 0x0400086C RID: 2156
		private SendOrPostCallback GetChartImageOperationCompleted;

		// Token: 0x0400086D RID: 2157
		private SendOrPostCallback GetSetIndexChartImageOperationCompleted;

		// Token: 0x0400086E RID: 2158
		private SendOrPostCallback GetPortfolioStatAllStockOperationCompleted;

		// Token: 0x0400086F RID: 2159
		private SendOrPostCallback GetPortfolioStatByStockOperationCompleted;

		// Token: 0x04000870 RID: 2160
		private SendOrPostCallback SavePushAccountOperationCompleted;

		// Token: 0x04000871 RID: 2161
		private SendOrPostCallback SaveStockAlertOperationCompleted;

		// Token: 0x04000872 RID: 2162
		private SendOrPostCallback SavePortAlertOperationCompleted;

		// Token: 0x04000873 RID: 2163
		private SendOrPostCallback SendAutoTradeOperationCompleted;

		// Token: 0x04000874 RID: 2164
		private SendOrPostCallback StopOrderRegisterOperationCompleted;

		// Token: 0x04000875 RID: 2165
		private SendOrPostCallback StopOrderCheckDisclaimerOperationCompleted;

		// Token: 0x04000876 RID: 2166
		private SendOrPostCallback ViewAutoTradeTransOperationCompleted;

		// Token: 0x04000877 RID: 2167
		private SendOrPostCallback ViewAutoTradeDCAItemsOperationCompleted;

		// Token: 0x04000878 RID: 2168
		private SendOrPostCallback ViewAutoTradePzItemsOperationCompleted;

		// Token: 0x04000879 RID: 2169
		private SendOrPostCallback ViewAutoTradeFTSItemsOperationCompleted;

		// Token: 0x0400087A RID: 2170
		private SendOrPostCallback GetHolidayOperationCompleted;

		// Token: 0x0400087B RID: 2171
		private SendOrPostCallback SaveUserAlertOperationCompleted;

		// Token: 0x0400087C RID: 2172
		private SendOrPostCallback SaveUserAlert2OperationCompleted;

		// Token: 0x0400087D RID: 2173
		private SendOrPostCallback GetAlertLogOperationCompleted;

		// Token: 0x0400087E RID: 2174
		private SendOrPostCallback GetAlertLogByGroupOperationCompleted;

		// Token: 0x0400087F RID: 2175
		private SendOrPostCallback VerifyAlertManagerOperationCompleted;

		// Token: 0x04000880 RID: 2176
		private SendOrPostCallback GetUserAlertOperationCompleted;

		// Token: 0x04000881 RID: 2177
		private SendOrPostCallback GetStockAlertItemsOperationCompleted;

		// Token: 0x04000882 RID: 2178
		private SendOrPostCallback GetPortAlertItemsOperationCompleted;

		// Token: 0x04000883 RID: 2179
		private SendOrPostCallback NAVChartOperationCompleted;

		// Token: 0x04000884 RID: 2180
		private SendOrPostCallback NAVAdjustmentOperationCompleted;

		// Token: 0x04000885 RID: 2181
		private SendOrPostCallback GetDataForSmartClickOperationCompleted;

		// Token: 0x04000886 RID: 2182
		private SendOrPostCallback GetOrderFor1ClickOperationCompleted;

		// Token: 0x04000887 RID: 2183
		private SendOrPostCallback SaveSummaryMarketDataOperationCompleted;

		// Token: 0x04000888 RID: 2184
		private SendOrPostCallback GetStockIndicatorOperationCompleted;

		// Token: 0x04000889 RID: 2185
		private SendOrPostCallback SaveUserConfigOperationCompleted;

		// Token: 0x0400088A RID: 2186
		private SendOrPostCallback SaveUserConfigAllOperationCompleted;

		// Token: 0x0400088B RID: 2187
		private SendOrPostCallback GetPortEquityOperationCompleted;

		// Token: 0x0400088C RID: 2188
		private SendOrPostCallback SendHeartBeat2OperationCompleted;

		// Token: 0x0400088D RID: 2189
		private SendOrPostCallback SaveUserEfinForwardOperationCompleted;

		// Token: 0x0400088E RID: 2190
		private SendOrPostCallback LoadAllInformationOperationCompleted;

		// Token: 0x0400088F RID: 2191
		private SendOrPostCallback LoadAllInformationIsoddOperationCompleted;

		// Token: 0x04000890 RID: 2192
		private SendOrPostCallback LoadStockInformationOperationCompleted;

		// Token: 0x04000891 RID: 2193
		private SendOrPostCallback ReloadSETIndexInfoOperationCompleted;

		// Token: 0x04000892 RID: 2194
		private SendOrPostCallback LoadMarketInformationOperationCompleted;

		// Token: 0x04000893 RID: 2195
		private SendOrPostCallback LoadOddLotInformationOperationCompleted;

		// Token: 0x04000894 RID: 2196
		private SendOrPostCallback BoardcastMessageOperationCompleted;

		// Token: 0x04000895 RID: 2197
		private SendOrPostCallback SendPushMessageOperationCompleted;

		// Token: 0x04000896 RID: 2198
		private SendOrPostCallback BestBidOfferOperationCompleted;

		// Token: 0x04000897 RID: 2199
		private SendOrPostCallback BestOpenPriceOperationCompleted;

		// Token: 0x04000898 RID: 2200
		private SendOrPostCallback BestProjectedOperationCompleted;

		// Token: 0x04000899 RID: 2201
		private SendOrPostCallback IndustryStatOperationCompleted;

		// Token: 0x0400089A RID: 2202
		private SendOrPostCallback TopActiveOperationCompleted;

		// Token: 0x0400089B RID: 2203
		private SendOrPostCallback TopActiveBBOOperationCompleted;

		// Token: 0x0400089C RID: 2204
		private SendOrPostCallback TopActiveBBO_BenefitOperationCompleted;

		// Token: 0x0400089D RID: 2205
		private SendOrPostCallback TopActiveBBO_WarrantOperationCompleted;

		// Token: 0x0400089E RID: 2206
		private SendOrPostCallback TopActiveBBO_CMPROperationCompleted;

		// Token: 0x0400089F RID: 2207
		private SendOrPostCallback TopActiveBBO_MyPortOperationCompleted;

		// Token: 0x040008A0 RID: 2208
		private SendOrPostCallback GetMyPortSymbolListOperationCompleted;

		// Token: 0x040008A1 RID: 2209
		private SendOrPostCallback TopActiveBBO_DWOperationCompleted;

		// Token: 0x040008A2 RID: 2210
		private SendOrPostCallback TopActiveBBO_NewsOperationCompleted;

		// Token: 0x040008A3 RID: 2211
		private SendOrPostCallback TopActiveBBO_TurnOverOperationCompleted;

		// Token: 0x040008A4 RID: 2212
		private SendOrPostCallback TopActiveBBO_SectorOperationCompleted;

		// Token: 0x040008A5 RID: 2213
		private SendOrPostCallback InvestorTypeOperationCompleted;

		// Token: 0x040008A6 RID: 2214
		private SendOrPostCallback MarketIndicatorOperationCompleted;

		// Token: 0x040008A7 RID: 2215
		private SendOrPostCallback SaleByPriceOperationCompleted;

		// Token: 0x040008A8 RID: 2216
		private SendOrPostCallback SectorStatOperationCompleted;

		// Token: 0x040008A9 RID: 2217
		private SendOrPostCallback SectorStatForDumpOperationCompleted;

		// Token: 0x040008AA RID: 2218
		private SendOrPostCallback StockStatForDumpOperationCompleted;

		// Token: 0x040008AB RID: 2219
		private SendOrPostCallback GetUserConfigForDumpOperationCompleted;

		// Token: 0x040008AC RID: 2220
		private SendOrPostCallback SaveUserConfigForDumpOperationCompleted;

		// Token: 0x040008AD RID: 2221
		private SendOrPostCallback SaleByTime2OperationCompleted;

		// Token: 0x040008AE RID: 2222
		private SendOrPostCallback StockInPlayOperationCompleted;

		// Token: 0x040008AF RID: 2223
		private SendOrPostCallback StockByPricePageOperationCompleted;

		// Token: 0x040008B0 RID: 2224
		private SendOrPostCallback MarketStatusOperationCompleted;

		// Token: 0x040008B1 RID: 2225
		private SendOrPostCallback TopBBOOperationCompleted;

		// Token: 0x040008B2 RID: 2226
		private SendOrPostCallback TopBBOadOperationCompleted;

		// Token: 0x040008B3 RID: 2227
		private SendOrPostCallback ViewOddlotOperationCompleted;

		// Token: 0x040008B4 RID: 2228
		private SendOrPostCallback Get5BidOfferOperationCompleted;

		// Token: 0x040008B5 RID: 2229
		private SendOrPostCallback ViewOrderTransactionOperationCompleted;

		// Token: 0x040008B6 RID: 2230
		private SendOrPostCallback ViewOrderHistoryOperationCompleted;

		// Token: 0x040008B7 RID: 2231
		private SendOrPostCallback ViewOrdersForDumpOperationCompleted;

		// Token: 0x040008B8 RID: 2232
		private SendOrPostCallback ViewOrderByOrderNoOperationCompleted;

		// Token: 0x040008B9 RID: 2233
		private SendOrPostCallback ViewNewsHeaderOperationCompleted;

		// Token: 0x040008BA RID: 2234
		private SendOrPostCallback ViewNewsStoryOperationCompleted;

		// Token: 0x040008BB RID: 2235
		private SendOrPostCallback ViewCustomersInfoOperationCompleted;

		// Token: 0x040008BC RID: 2236
		private SendOrPostCallback ViewCustomerCreditOnSendBox_FreewillOperationCompleted;

		// Token: 0x040008BD RID: 2237
		private SendOrPostCallback ViewCustomerCreditOnSendBoxOperationCompleted;

		// Token: 0x040008BE RID: 2238
		private SendOrPostCallback GetSwitchAccountInfoOperationCompleted;

		// Token: 0x040008BF RID: 2239
		private SendOrPostCallback ViewCustomer_MobileReportAllOperationCompleted;

		// Token: 0x040008C0 RID: 2240
		private SendOrPostCallback ViewCustomer_OrdersConfirmsOperationCompleted;

		// Token: 0x040008C1 RID: 2241
		private SendOrPostCallback ViewCustomer_CreditPositionOperationCompleted;

		// Token: 0x040008C2 RID: 2242
		private SendOrPostCallback ViewCustomer_ProjectedProfitLossOperationCompleted;

		// Token: 0x040008C3 RID: 2243
		private SendOrPostCallback ViewCustomer_FScoreAnalysisOperationCompleted;

		// Token: 0x040008C4 RID: 2244
		private SendOrPostCallback ViewCustomer_BetaAnalysisOperationCompleted;

		// Token: 0x040008C5 RID: 2245
		private SendOrPostCallback ViewCustomer_RiskManagementOperationCompleted;

		// Token: 0x040008C6 RID: 2246
		private SendOrPostCallback ViewCustomer_RiskManagement_SaveValueOperationCompleted;

		// Token: 0x040008C7 RID: 2247
		private SendOrPostCallback ViewCustomer_RealizeProfitLossOperationCompleted;

		// Token: 0x040008C8 RID: 2248
		private SendOrPostCallback ViewCustomer_SummaryOperationCompleted;

		// Token: 0x040008C9 RID: 2249
		private SendOrPostCallback ViewCustomer_ConfirmSummaryOperationCompleted;

		// Token: 0x040008CA RID: 2250
		private SendOrPostCallback ViewCustomer_ConfirmOperationCompleted;

		// Token: 0x040008CB RID: 2251
		private SendOrPostCallback ViewCustomer_ConfirmByDealIDOperationCompleted;

		// Token: 0x040008CC RID: 2252
		private SendOrPostCallback ViewCustomer_ConfirmByStockOperationCompleted;

		// Token: 0x040008CD RID: 2253
		private SendOrPostCallback ViewOrderInfo_AfterCloseFwOperationCompleted;

		// Token: 0x040008CE RID: 2254
		private SendOrPostCallback ViewOrderDealDataOperationCompleted;

		// Token: 0x040008CF RID: 2255
		private SendOrPostCallback ViewOrderDealDataHistoryOperationCompleted;

		// Token: 0x040008D0 RID: 2256
		private SendOrPostCallback GetCometInfoOperationCompleted;

		// Token: 0x040008D1 RID: 2257
		private SendOrPostCallback GetTunnelConfigOperationCompleted;

		// Token: 0x040008D2 RID: 2258
		private SendOrPostCallback GetTunnelOperationCompleted;

		// Token: 0x040008D3 RID: 2259
		private SendOrPostCallback VerifyOrderOperationCompleted;

		// Token: 0x040008D4 RID: 2260
		private SendOrPostCallback VerifyOrderFwOperationCompleted;

		// Token: 0x040008D5 RID: 2261
		private SendOrPostCallback VerifyOrderMktOperationCompleted;

		// Token: 0x040008D6 RID: 2262
		private SendOrPostCallback GetMainInfoOperationCompleted;

		// Token: 0x040008D7 RID: 2263
		private SendOrPostCallback UserAuthenOperationCompleted;

		// Token: 0x040008D8 RID: 2264
		private SendOrPostCallback ClearEfinSessionOperationCompleted;

		// Token: 0x040008D9 RID: 2265
		private SendOrPostCallback GetUrlClientOperationCompleted;

		// Token: 0x040008DA RID: 2266
		private SendOrPostCallback LogoutOperationCompleted;

		// Token: 0x040008DB RID: 2267
		private SendOrPostCallback LogoutADOperationCompleted;

		// Token: 0x040008DC RID: 2268
		private SendOrPostCallback ChangeCustomerPasswordOperationCompleted;

		// Token: 0x040008DD RID: 2269
		private SendOrPostCallback ChangeTraderPasswordOperationCompleted;

		// Token: 0x040008DE RID: 2270
		private SendOrPostCallback StockThresholdInformationOperationCompleted;

		// Token: 0x040008DF RID: 2271
		private SendOrPostCallback SaveStockThresholdOperationCompleted;

		// Token: 0x040008E0 RID: 2272
		private bool useDefaultCredentialsSetExplicitly;
	}
}
