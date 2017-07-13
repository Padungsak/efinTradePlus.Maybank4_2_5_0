using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.ITSNetBusinessWSTFEX;
using i2TradePlus.Templates;
using ITSNet.Common.BIZ.WebClient;

namespace i2TradePlus
{
	// Token: 0x0200007F RID: 127
	internal class ApplicationInfo
	{
		// Token: 0x060005D8 RID: 1496
		[DllImport("kernel32.dll")]
		public static extern bool Beep(int freq, int duration);

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0006643C File Offset: 0x0006483C
		public static string WORKING_ROOTPATH
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\i2Template";
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00066470 File Offset: 0x00064870
		public static AccountInfo AccInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.accInfo == null)
				{
					ApplicationInfo.accInfo = new AccountInfo();
				}
				return ApplicationInfo.accInfo;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000664B4 File Offset: 0x000648B4
		public static decimal UserCommVAT
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.UserCommRate / 100m + ApplicationInfo.UserCommRate / 100m * ApplicationInfo.UserVAT / 100m;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00066514 File Offset: 0x00064914
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0006653C File Offset: 0x0006493C
		public static string CurrentSymbol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.currentSymbol;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				try
				{
					if (ApplicationInfo.currentSymbol != value)
					{
						ApplicationInfo.currentSymbol = value;
						if (!ApplicationInfo.IsLockSendBox)
						{
							TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(value);
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000665B4 File Offset: 0x000649B4
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x000665DC File Offset: 0x000649DC
		public static string CurrStockInMktWatch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.currStockInMktWatch;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.currStockInMktWatch = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000665F4 File Offset: 0x000649F4
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0006661C File Offset: 0x00064A1C
		public static string MarketState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.marketState;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.marketState = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00066634 File Offset: 0x00064A34
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0006665C File Offset: 0x00064A5C
		public static int MarketSession
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.marketSession;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.marketSession = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00066674 File Offset: 0x00064A74
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0006669C File Offset: 0x00064A9C
		public static DateTime MarketTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.marketTime;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.marketTime = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000666B4 File Offset: 0x00064AB4
		public static string[] StockAutoCompStringArr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.stockAutoCompStringArr == null && ApplicationInfo.StockAutoComp != null)
				{
					ApplicationInfo.stockAutoCompStringArr = new string[ApplicationInfo.StockAutoComp.Count];
					ApplicationInfo.StockAutoComp.CopyTo(ApplicationInfo.stockAutoCompStringArr, 0);
				}
				return ApplicationInfo.stockAutoCompStringArr;
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00066724 File Offset: 0x00064B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CanReceiveMessage(string customerAccount)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return ApplicationInfo.AccInfo.Items.ContainsKey(customerAccount);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0006676C File Offset: 0x00064B6C
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00066794 File Offset: 0x00064B94
		public static List<TunnelInfo> TunnelHosts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.tunnelHosts;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.tunnelHosts = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x000667AC File Offset: 0x00064BAC
		public static i2TradePlus.ITSNetBusinessWS.Service WebService
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webService == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.EquityService);
						ApplicationInfo.webService = (i2TradePlus.ITSNetBusinessWS.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webService;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0006681C File Offset: 0x00064C1C
		public static i2TradePlus.ITSNetBusinessWS.Service WebOrderService
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webOrderService == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.OrderService);
						ApplicationInfo.webOrderService = (i2TradePlus.ITSNetBusinessWS.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webOrderService;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0006688C File Offset: 0x00064C8C
		public static i2TradePlus.ITSNetBusinessWS.Service WebAlertService
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webAlertService == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.AlertService);
						ApplicationInfo.webAlertService = (i2TradePlus.ITSNetBusinessWS.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webAlertService;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000668FC File Offset: 0x00064CFC
		public static i2TradePlus.ITSNetBusinessWS.Service WebMainService
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webMainService == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.MainService);
						ApplicationInfo.webMainService = (i2TradePlus.ITSNetBusinessWS.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webMainService;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0006696C File Offset: 0x00064D6C
		public static i2TradePlus.ITSNetBusinessWSTFEX.Service WebServiceTFEX
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webServiceTFEX == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.TfexService);
						ApplicationInfo.webServiceTFEX = (i2TradePlus.ITSNetBusinessWSTFEX.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webServiceTFEX;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000669DC File Offset: 0x00064DDC
		public static i2TradePlus.ITSNetBusinessWSTFEX.Service WebMainTfexService
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.webMainTfexService == null)
				{
					try
					{
						SoapHttpClientProtocol soapHttpClientProtocol = new WebServiceFactory().Create(ITSNetWS.MainTfexService);
						ApplicationInfo.webMainTfexService = (i2TradePlus.ITSNetBusinessWSTFEX.Service)soapHttpClientProtocol;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				return ApplicationInfo.webMainTfexService;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00066A4C File Offset: 0x00064E4C
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00066A74 File Offset: 0x00064E74
		public static StockList StockInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo._stockInfo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo._stockInfo = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00066A8C File Offset: 0x00064E8C
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00066AB4 File Offset: 0x00064EB4
		public static SeriesList SeriesInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo._seriesInfo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo._seriesInfo = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00066ACC File Offset: 0x00064ECC
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00066AF4 File Offset: 0x00064EF4
		public static TFEXIndex IndexInfoTfex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.indexInfoTfex;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.indexInfoTfex = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00066B0C File Offset: 0x00064F0C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00066B34 File Offset: 0x00064F34
		public static UnderlyingInfo UnderlyingInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo._underlyingInfo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo._underlyingInfo = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00066B4C File Offset: 0x00064F4C
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00066BBC File Offset: 0x00064FBC
		public static string[] MultiAutoCompStringArr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.multiAutoCompStringArr == null && ApplicationInfo.MultiAutoComp != null)
				{
					ApplicationInfo.multiAutoCompStringArr = new string[ApplicationInfo.MultiAutoComp.Count];
					ApplicationInfo.MultiAutoComp.CopyTo(ApplicationInfo.multiAutoCompStringArr, 0);
				}
				return ApplicationInfo.multiAutoCompStringArr;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.multiAutoCompStringArr = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00066BD4 File Offset: 0x00064FD4
		public static string[] SeriesAutoCompStringArr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo.seriesAutoCompStringArr == null && ApplicationInfo.SeriesAutoComp != null)
				{
					ApplicationInfo.seriesAutoCompStringArr = new string[ApplicationInfo.SeriesAutoComp.Count];
					ApplicationInfo.SeriesAutoComp.CopyTo(ApplicationInfo.seriesAutoCompStringArr, 0);
				}
				return ApplicationInfo.seriesAutoCompStringArr;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00066C44 File Offset: 0x00065044
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00066C6C File Offset: 0x0006506C
		public static IndexStat IndexStatInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo._indexStatInfo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo._indexStatInfo = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00066C84 File Offset: 0x00065084
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00066CAC File Offset: 0x000650AC
		public static string UrlSyncHandler
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return ApplicationInfo.urlSyncHandler;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.urlSyncHandler = value;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00066CC4 File Offset: 0x000650C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddOrderNoToAutoRefreshList(string sOrderNo, int actionType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAutoGetOrderInfo)
				{
					lock (((ICollection)ApplicationInfo.AutoGetOrderNoList).SyncRoot)
					{
						if (actionType == 1)
						{
							if (ApplicationInfo.SupportFreewill)
							{
								ApplicationInfo.AutoGetOrderNoList.Add("R" + sOrderNo, DateTime.Now);
							}
							else
							{
								ApplicationInfo.AutoGetOrderNoList.Add(sOrderNo, DateTime.Now);
							}
						}
						else if (actionType == 2)
						{
							ApplicationInfo.AutoGetOrderNoList.Add(sOrderNo, DateTime.Now);
						}
						else if (actionType == 3)
						{
							ApplicationInfo.AutoGetOrderNoList.Add("F" + sOrderNo, DateTime.Now);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00066DE0 File Offset: 0x000651E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveOrderNoFromAutoRefreshList(string sOrderNo, string refOrdNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				lock (((ICollection)ApplicationInfo.AutoGetOrderNoList).SyncRoot)
				{
					if (sOrderNo != string.Empty && ApplicationInfo.AutoGetOrderNoList.ContainsKey(sOrderNo))
					{
						ApplicationInfo.AutoGetOrderNoList.Remove(sOrderNo);
					}
					if (refOrdNo != string.Empty && ApplicationInfo.AutoGetOrderNoList.ContainsKey(refOrdNo))
					{
						ApplicationInfo.AutoGetOrderNoList.Remove(refOrdNo);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00066EBC File Offset: 0x000652BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddOrderNoToAutoRefreshList_TFEX(string sOrderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAutoGetOrderInfo)
				{
					lock (ApplicationInfo.AutoGetOrderNoList_TFEX)
					{
						if (ApplicationInfo.AutoGetOrderNoList_TFEX.ContainsKey(sOrderNo))
						{
							ApplicationInfo.AutoGetOrderNoList_TFEX.Remove(sOrderNo);
						}
						ApplicationInfo.AutoGetOrderNoList_TFEX.Add(sOrderNo, DateTime.Now);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00066F60 File Offset: 0x00065360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveOrderNoFromAutoRefreshList_TFEX(string sOrderNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.AutoGetOrderNoList_TFEX.ContainsKey(sOrderNo))
				{
					lock (ApplicationInfo.AutoGetOrderNoList_TFEX)
					{
						ApplicationInfo.AutoGetOrderNoList_TFEX.Remove(sOrderNo);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00066FE4 File Offset: 0x000653E4
		public static string IP
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (ApplicationInfo._ip == string.Empty)
				{
					try
					{
						IPHostEntry hostEntry = Dns.GetHostEntry(Environment.MachineName.ToString());
						IPAddress[] addressList = hostEntry.AddressList;
						for (int i = 0; i < addressList.Length; i++)
						{
							if (!addressList[i].IsIPv6LinkLocal && !addressList[i].IsIPv6Multicast && !addressList[i].IsIPv6SiteLocal && addressList[i].AddressFamily != AddressFamily.InterNetworkV6)
							{
								ApplicationInfo._ip = addressList[i].ToString();
							}
						}
					}
					catch
					{
						ApplicationInfo._ip = "None";
					}
				}
				return ApplicationInfo._ip;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000670D8 File Offset: 0x000654D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTemplatePathByUser()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return ApplicationInfo.WORKING_ROOTPATH + "\\PlusTemplates\\" + ApplicationInfo.UserLoginID;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00067114 File Offset: 0x00065514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckFormCanShowByLoginMode(Type formType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return ApplicationInfo.UserLoginMode == "T" || ApplicationInfo.UserLoginMode == "C";
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00067178 File Offset: 0x00065578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetupUsers(string users, char spliter)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string[] array = users.Split(new char[]
				{
					spliter
				});
				if (array.Length > 0)
				{
					int num = 0;
					if (ApplicationInfo.IsOpenFromWeb)
					{
						num = 1;
					}
					for (int i = num; i < array.Length; i++)
					{
						string[] array2 = array[i].ToString().Split(new char[]
						{
							':'
						});
						string key = string.Empty;
						AccountInfo.ItemInfo itemInfo = new AccountInfo.ItemInfo();
						if (array2.Length > 1)
						{
							key = array2[1];
							itemInfo.Market = array2[0];
						}
						else
						{
							key = array2[0];
							itemInfo.Market = "E";
						}
						if (array2.Length > 2)
						{
							itemInfo.CanTrade = array2[2];
						}
						else
						{
							itemInfo.CanTrade = "Y";
						}
						if (itemInfo.Market == "E" || (itemInfo.Market == "T" && ApplicationInfo.IsSupportTfex))
						{
							ApplicationInfo.AccInfo.Items.Add(key, itemInfo);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00067310 File Offset: 0x00065710
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTermicalId()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return "S";
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0006733C File Offset: 0x0006573C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSession()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			if (ApplicationInfo.BrokerId == 4)
			{
				result = ApplicationInfo.KE_Session;
			}
			else if (ApplicationInfo.BrokerId == 2)
			{
				result = ApplicationInfo.KTZ_Session;
			}
			else if (ApplicationInfo.BrokerId == 8)
			{
				result = ApplicationInfo.ASP_Ticket;
			}
			else if (ApplicationInfo.BrokerId == 17)
			{
				result = ApplicationInfo.FSS_Session;
			}
			else if (ApplicationInfo.BrokerId == 15)
			{
				result = ApplicationInfo.TNS_Session;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000673F8 File Offset: 0x000657F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ApplicationInfo.SendNewOrderResult SendNewOrder(string symbol, string side, long volume, string price, long publishVol, string condition, int ttf, string deposit, bool isAutoStopLoss)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfo.SendNewOrderResult sendNewOrderResult = new ApplicationInfo.SendNewOrderResult();
			sendNewOrderResult.IsAutoStopLoss = isAutoStopLoss;
			try
			{
				string message = SendNewOrderMessage.Pack(symbol, side, volume, price, ApplicationInfo.AccInfo.CurrentAccount, publishVol, condition, ttf.ToString(), ApplicationInfo.AccInfo.CurrInternetUser, deposit, ApplicationInfo.GetSession(), "", ApplicationInfo.IP, ApplicationInfo.GetTermicalId(), ApplicationInfo.AuthenKey);
				string data = ApplicationInfo.WebOrderService.SendNewOrder(message);
				using (DataSet dataSet = new DataSet())
				{
					MyDataHelper.StringToDataSet(data, dataSet);
					if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
					{
						long.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out sendNewOrderResult.OrderNo);
						sendNewOrderResult.ResultMessage = dataSet.Tables["Results"].Rows[0]["message"].ToString().Trim();
						if (ApplicationInfo.SupportFreewill)
						{
							sendNewOrderResult.IsFwOfflineOrder = (sendNewOrderResult.ResultMessage == "ok_offline");
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				sendNewOrderResult.OrderNo = -1L;
				sendNewOrderResult.ResultMessage = ex.Message;
			}
			return sendNewOrderResult;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000675F0 File Offset: 0x000659F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckPinTimeout()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (ApplicationInfo.UserMaxPincodeTimeout > 0)
			{
				TimeSpan timeSpan = DateTime.Now.Subtract(ApplicationInfo.UserPincodeLastAccess);
				double num = (double)ApplicationInfo.UserMaxPincodeTimeout - timeSpan.TotalSeconds;
				result = (num < 0.0 && !string.IsNullOrEmpty(ApplicationInfo.UserPincodeLastEntry));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600060B RID: 1547 RVA: 0x00067680 File Offset: 0x00065A80
		// (remove) Token: 0x0600060C RID: 1548 RVA: 0x000676A8 File Offset: 0x00065AA8
		public static event ApplicationInfo.OnPincodeChangedCompleteHandler OnPincodeChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.OnPincodeChanged = (ApplicationInfo.OnPincodeChangedCompleteHandler)Delegate.Combine(ApplicationInfo.OnPincodeChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfo.OnPincodeChanged = (ApplicationInfo.OnPincodeChangedCompleteHandler)Delegate.Remove(ApplicationInfo.OnPincodeChanged, value);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000676D0 File Offset: 0x00065AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool VerifyPincode(string pincodeEntry, ref string verifyPinResultStr)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			bool result;
			try
			{
				if (pincodeEntry == string.Empty)
				{
					verifyPinResultStr = "Pin is empty!!!";
					result = false;
					return result;
				}
				if (ApplicationInfo.UserPincodeLastEntry != pincodeEntry)
				{
					ApplicationInfo.UserPincodeLastEntry = pincodeEntry;
					if (ApplicationInfo.OnPincodeChanged != null)
					{
						ApplicationInfo.OnPincodeChanged();
					}
				}
				if (ApplicationInfo.UserPincode != string.Empty && pincodeEntry == ApplicationInfo.UserPincode)
				{
					if (ApplicationInfo.UserMaxPincodeTimeout > 0)
					{
						if (ApplicationInfo.CheckPinTimeout())
						{
							verifyPinResultStr = ApplicationInfo.PINCODE_TIMEOUT;
							flag = false;
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					verifyPinResultStr = ApplicationInfo.WebMainService.VerifyPincode2(ApplicationInfo.UserLoginID, ApplicationInfo.UserPincodeLastEntry, ApplicationInfo.GetSession(), ApplicationInfo.KTZ_custMapKey);
					if (verifyPinResultStr == "ok")
					{
						flag = true;
					}
				}
				if (flag)
				{
					ApplicationInfo.UserPincodeLastAccess = DateTime.Now;
					ApplicationInfo.UserPincode = ApplicationInfo.UserPincodeLastEntry;
					ApplicationInfo.UserPincodeWrongCount = 0;
				}
				else
				{
					ApplicationInfo.UserPincodeWrongCount++;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			result = flag;
			return result;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00067860 File Offset: 0x00065C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetFavListByPage(int favPage, int maxRecord, bool isTfexSigleQuote, ref string setList, ref string tfexList)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				setList = string.Empty;
				tfexList = string.Empty;
				foreach (string current in ApplicationInfo.FavStockList[favPage])
				{
					if (current != string.Empty)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[current];
						if (stockInformation.Number > 0)
						{
							setList += "," + stockInformation.Number;
						}
						else if (ApplicationInfo.IsSupportTfex)
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[current];
							if (seriesInformation.Symbol != string.Empty)
							{
								if (isTfexSigleQuote)
								{
									tfexList = tfexList + (",'" + seriesInformation.Symbol) + "'";
								}
								else
								{
									tfexList += "," + seriesInformation.Symbol;
								}
							}
						}
					}
				}
				if (setList != string.Empty)
				{
					setList = setList.Substring(1);
				}
				if (tfexList != string.Empty)
				{
					tfexList = tfexList.Substring(1);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00067A44 File Offset: 0x00065E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetFavSymbolListByPage(int favPage, int maxRecord)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			try
			{
				string text = string.Empty;
				foreach (string current in ApplicationInfo.FavStockList[favPage])
				{
					if (current != string.Empty)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[current];
						if (stockInformation.Number > 0)
						{
							text += "," + stockInformation.Symbol;
						}
					}
				}
				if (text != string.Empty)
				{
					text = text.Substring(1);
				}
				result = text;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00067B4C File Offset: 0x00065F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InitFavStock(string[] fav)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.FavStockList = new Dictionary<int, List<string>>();
				ApplicationInfo.FavStockList.Add(1, new List<string>());
				ApplicationInfo.FavStockList.Add(2, new List<string>());
				ApplicationInfo.FavStockList.Add(3, new List<string>());
				ApplicationInfo.FavStockList.Add(4, new List<string>());
				ApplicationInfo.FavStockList.Add(5, new List<string>());
				for (int i = 0; i < ApplicationInfo.FavStockPerPage; i++)
				{
					ApplicationInfo.FavStockList[1].Add(string.Empty);
					ApplicationInfo.FavStockList[2].Add(string.Empty);
					ApplicationInfo.FavStockList[3].Add(string.Empty);
					ApplicationInfo.FavStockList[4].Add(string.Empty);
					ApplicationInfo.FavStockList[5].Add(string.Empty);
				}
				if (fav != null)
				{
					for (int j = 1; j <= 5; j++)
					{
						string[] array = fav[j - 1].Split(new char[]
						{
							';'
						});
						for (int i = 0; i < array.Length; i++)
						{
							ApplicationInfo.FavStockList[j][i] = array[i];
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00067CF4 File Offset: 0x000660F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetFullNameBroker(int brokerID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = string.Empty;
			string result;
			try
			{
				if (ApplicationInfo.BrokerId == 7)
				{
					text = "AIRA Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 8)
				{
					text = "ASIA PLUS Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 10)
				{
					text = "Asia Wealth Securities Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 3)
				{
					text = "RHB OSK SECURITIES (THAILAND) PUBLIC COMPANY LIMITED.";
				}
				else if (ApplicationInfo.BrokerId == 11)
				{
					text = "CIMB Securities (Thailand) Co.,Ltd.";
				}
				else if (ApplicationInfo.BrokerId == 1)
				{
					text = "CAPITAL NOMURA Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 4)
				{
					text = "Maybank Kim Eng Securities (Thailand) Plc.";
				}
				else if (ApplicationInfo.BrokerId == 12)
				{
					text = "Yuanta Securities Thailand Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 2)
				{
					text = "KT ZMICO Securities Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 13)
				{
					text = "Land and House Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 14)
				{
					text = "AEC Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 15)
				{
					text = "Thanachart Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 16)
				{
					text = "Globlex Securities Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 17)
				{
					text = "Finansia Syrus Securities Public Company Limited.";
				}
				else if (ApplicationInfo.BrokerId == 9)
				{
					text = "KTB Securities (Thailand) Company Limited.";
				}
				else
				{
					if (ApplicationInfo.BrokerId != 18)
					{
						result = "";
						return result;
					}
					text = "UOB KayHian Securities (Thailand) Public Company Limited.";
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			result = text;
			return result;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00067F2C File Offset: 0x0006632C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAutoTradeSupport(int type)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int num = ApplicationInfo.AutoTradeType & type;
			return num > 0;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00067F68 File Offset: 0x00066368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplicationInfo() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor();
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00067F84 File Offset: 0x00066384
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ApplicationInfo()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			ApplicationInfo.UserLoginID = string.Empty;
			ApplicationInfo.IsEquityAccount = false;
			ApplicationInfo.IsOpenFromWeb = false;
			ApplicationInfo.IsNewPortStyle = false;
			ApplicationInfo.UserLoginMode = "I";
			ApplicationInfo.UserSessionID = string.Empty;
			ApplicationInfo.UserPincode = string.Empty;
			ApplicationInfo.UserPincodeLastEntry = string.Empty;
			ApplicationInfo.UserPincodeLastAccess = DateTime.MinValue;
			ApplicationInfo.UserMaxPincodeTimeout = 300;
			ApplicationInfo.UserPincodeWrongCount = 0;
			ApplicationInfo.UserMaxRetryPincode = 3;
			ApplicationInfo.AuthenKey = string.Empty;
			ApplicationInfo.UserVAT = 0m;
			ApplicationInfo.UserCommRate = 0m;
			ApplicationInfo.UserEfin = string.Empty;
			ApplicationInfo.UserMarginRate = 50;
			ApplicationInfo.NewsHomeLink = "http://www.i2trade.com/NewPortalPage.aspx";
			ApplicationInfo.StockFocusHomeLink = "http://www.set.or.th/set/commonslookup.do";
			ApplicationInfo.NewsSymbolLink = "http://www.set.or.th/set/companynews.do?symbol=XXXXX&language=th&country=TH";
			ApplicationInfo.StockFocusSymbolLink = "http://www.set.or.th/set/companyprofile.do?symbol=XXXXX&language=th&country=TH";
			ApplicationInfo.EserviceServer = string.Empty;
			ApplicationInfo.IsSupportEservice = false;
			ApplicationInfo.SupportPM = false;
			ApplicationInfo.UPDATE_VERSION = "UPDATE_VERSION";
			ApplicationInfo.Grade_Server = string.Empty;
			ApplicationInfo.KE_Session = string.Empty;
			ApplicationInfo.KE_AuthenUrl = string.Empty;
			ApplicationInfo.KE_LOCAL = string.Empty;
			ApplicationInfo.KTZ_Session = string.Empty;
			ApplicationInfo.KTZ_custMapKey = string.Empty;
			ApplicationInfo.ASP_Ticket = string.Empty;
			ApplicationInfo.FSS_Session = string.Empty;
			ApplicationInfo.TNS_Session = string.Empty;
			ApplicationInfo.YUANTA_Session = string.Empty;
			ApplicationInfo.Isi2infoLink2 = false;
			ApplicationInfo.IsAutoGetOrderInfo = false;
			ApplicationInfo.AutoGetOrderInfoInterval = 0;
			ApplicationInfo.IsOrderBoxFocus = false;
			ApplicationInfo.SupportOrderTimes = true;
			ApplicationInfo.SupportFreewill = false;
			ApplicationInfo.FrontSystemTFEX = string.Empty;
			ApplicationInfo.FrontSystem = string.Empty;
			ApplicationInfo.IsUseProxy = false;
			ApplicationInfo.ProxyPassword = string.Empty;
			ApplicationInfo.IsFeedsStarted = false;
			ApplicationInfo.IsScreen125 = false;
			ApplicationInfo.IsResumeState = false;
			ApplicationInfo.HBInterval = 60000;
			ApplicationInfo.IsLockSendBox = false;
			ApplicationInfo.currentSymbol = string.Empty;
			ApplicationInfo.currStockInMktWatch = string.Empty;
			ApplicationInfo.marketState = string.Empty;
			ApplicationInfo.marketTime = DateTime.MinValue;
			ApplicationInfo.MinPasswordLength = 1;
			ApplicationInfo.MinPincodeLength = 4;
			ApplicationInfo.StockAutoComp = null;
			ApplicationInfo.IsLoadInformation = false;
			ApplicationInfo.IsAreadyLogin = false;
			ApplicationInfo.BrokerId = 0;
			ApplicationInfo.IsRiskActive = true;
			ApplicationInfo.SuuportSBL = "N";
			ApplicationInfo.SupportCollateral = "N";
			ApplicationInfo.SuuportSplash = "Y";
			ApplicationInfo.SupportNAV = false;
			ApplicationInfo.SupportNod = false;
			ApplicationInfo.PullInterval = 1000;
			ApplicationInfo.PCCanEditorder = "N";
			ApplicationInfo.PCCanEditorderTFEX = "N";
			ApplicationInfo.IsSupportTfex = false;
			ApplicationInfo.IsSupportTPBlinkColor = false;
			ApplicationInfo.SupportBatchOrder = "N";
			ApplicationInfo.NewsSymbol = string.Empty;
			ApplicationInfo.AlertOpen = false;
			ApplicationInfo.AlertAutoPopup = true;
			ApplicationInfo.AlertSound = false;
			ApplicationInfo.IsSupportEfinChart = false;
			ApplicationInfo.UrlEfinChart = string.Empty;
			ApplicationInfo.UrlEfinFinance = string.Empty;
			ApplicationInfo.UrlEfinNews = string.Empty;
			ApplicationInfo.UrlEfinSession = string.Empty;
			ApplicationInfo.AutoTradeFromWeb = false;
			ApplicationInfo.AutoTradeType = 0;
			ApplicationInfo.IsAutoTradeAccepted = false;
			ApplicationInfo.IsFrontSoftStyle = false;
			ApplicationInfo.IsSupportAutoTradeTFEX = false;
			ApplicationInfo.IsPushMode = true;
			ApplicationInfo.TunnelCounter = 0;
			ApplicationInfo.tunnelHosts = null;
			ApplicationInfo.WebMainUrl = string.Empty;
			ApplicationInfo.WebMainTfexUrl = string.Empty;
			ApplicationInfo.WebUrl = string.Empty;
			ApplicationInfo.WebOrderUrl = string.Empty;
			ApplicationInfo.WebAlertUrl = string.Empty;
			ApplicationInfo.WebTfexUrl = string.Empty;
			ApplicationInfo.webService = null;
			ApplicationInfo.webOrderService = null;
			ApplicationInfo.webAlertService = null;
			ApplicationInfo.webMainService = null;
			ApplicationInfo.webServiceTFEX = null;
			ApplicationInfo.webMainTfexService = null;
			ApplicationInfo.CanRecvSpace = false;
			ApplicationInfo._stockInfo = new StockList();
			ApplicationInfo._seriesInfo = new SeriesList();
			ApplicationInfo.indexInfoTfex = new TFEXIndex();
			ApplicationInfo._underlyingInfo = new UnderlyingInfo();
			ApplicationInfo.MultiAutoComp = null;
			ApplicationInfo.SeriesAutoComp = null;
			ApplicationInfo._indexStatInfo = new IndexStat();
			ApplicationInfo.urlSyncHandler = string.Empty;
			ApplicationInfo.FavStockPerPage = 15;
			ApplicationInfo.FavStockChanged = false;
			ApplicationInfo.FavStockList = null;
			ApplicationInfo.TickerStockList = new List<string>();
			ApplicationInfo.AutoGetOrderNoList = new Dictionary<string, DateTime>();
			ApplicationInfo.AutoGetOrderNoList_TFEX = new Dictionary<string, DateTime>();
			ApplicationInfo.DWParentStockList = new List<string>();
			ApplicationInfo._ip = string.Empty;
			ApplicationInfo.PINCODE_TIMEOUT = "PINCODE_TIMEOUT";
		}

		// Token: 0x04000344 RID: 836
		private static AccountInfo accInfo;

		// Token: 0x04000345 RID: 837
		public static string UserLoginID;

		// Token: 0x04000346 RID: 838
		public static bool IsEquityAccount;

		// Token: 0x04000347 RID: 839
		public static bool IsOpenFromWeb;

		// Token: 0x04000348 RID: 840
		public static bool IsNewPortStyle;

		// Token: 0x04000349 RID: 841
		public static string UserLoginMode;

		// Token: 0x0400034A RID: 842
		public static string UserSessionID;

		// Token: 0x0400034B RID: 843
		public static string UserPincode;

		// Token: 0x0400034C RID: 844
		public static string UserPincodeLastEntry;

		// Token: 0x0400034D RID: 845
		private static DateTime UserPincodeLastAccess;

		// Token: 0x0400034E RID: 846
		public static int UserMaxPincodeTimeout;

		// Token: 0x0400034F RID: 847
		public static int UserPincodeWrongCount;

		// Token: 0x04000350 RID: 848
		public static int UserMaxRetryPincode;

		// Token: 0x04000351 RID: 849
		public static string AuthenKey;

		// Token: 0x04000352 RID: 850
		public static decimal UserVAT;

		// Token: 0x04000353 RID: 851
		public static decimal UserCommRate;

		// Token: 0x04000354 RID: 852
		public static string UserEfin;

		// Token: 0x04000355 RID: 853
		public static int UserMarginRate;

		// Token: 0x04000356 RID: 854
		public static string NewsHomeLink;

		// Token: 0x04000357 RID: 855
		public static string StockFocusHomeLink;

		// Token: 0x04000358 RID: 856
		public static string NewsSymbolLink;

		// Token: 0x04000359 RID: 857
		public static string StockFocusSymbolLink;

		// Token: 0x0400035A RID: 858
		public static string EserviceServer;

		// Token: 0x0400035B RID: 859
		public static bool IsSupportEservice;

		// Token: 0x0400035C RID: 860
		public static bool SupportPM;

		// Token: 0x0400035D RID: 861
		public static string UPDATE_VERSION;

		// Token: 0x0400035E RID: 862
		public static string Grade_Server;

		// Token: 0x0400035F RID: 863
		public static string KE_Session;

		// Token: 0x04000360 RID: 864
		public static string KE_AuthenUrl;

		// Token: 0x04000361 RID: 865
		public static string KE_LOCAL;

		// Token: 0x04000362 RID: 866
		public static string KTZ_Session;

		// Token: 0x04000363 RID: 867
		public static string KTZ_custMapKey;

		// Token: 0x04000364 RID: 868
		public static string ASP_Ticket;

		// Token: 0x04000365 RID: 869
		public static string FSS_Session;

		// Token: 0x04000366 RID: 870
		public static string TNS_Session;

		// Token: 0x04000367 RID: 871
		public static string YUANTA_Session;

		// Token: 0x04000368 RID: 872
		public static bool Isi2infoLink2;

		// Token: 0x04000369 RID: 873
		public static bool IsAutoGetOrderInfo;

		// Token: 0x0400036A RID: 874
		public static int AutoGetOrderInfoInterval;

		// Token: 0x0400036B RID: 875
		public static bool IsOrderBoxFocus;

		// Token: 0x0400036C RID: 876
		public static bool SupportOrderTimes;

		// Token: 0x0400036D RID: 877
		public static bool SupportFreewill;

		// Token: 0x0400036E RID: 878
		public static string FrontSystemTFEX;

		// Token: 0x0400036F RID: 879
		public static string FrontSystem;

		// Token: 0x04000370 RID: 880
		public static bool IsUseProxy;

		// Token: 0x04000371 RID: 881
		public static string ProxyPassword;

		// Token: 0x04000372 RID: 882
		public static bool IsFeedsStarted;

		// Token: 0x04000373 RID: 883
		public static bool IsScreen125;

		// Token: 0x04000374 RID: 884
		public static bool IsResumeState;

		// Token: 0x04000375 RID: 885
		public static int HBInterval;

		// Token: 0x04000376 RID: 886
		public static bool IsLockSendBox;

		// Token: 0x04000377 RID: 887
		private static string currentSymbol;

		// Token: 0x04000378 RID: 888
		private static string currStockInMktWatch;

		// Token: 0x04000379 RID: 889
		private static string marketState;

		// Token: 0x0400037A RID: 890
		private static int marketSession;

		// Token: 0x0400037B RID: 891
		private static DateTime marketTime;

		// Token: 0x0400037C RID: 892
		public static int MinPasswordLength;

		// Token: 0x0400037D RID: 893
		public static int MinPincodeLength;

		// Token: 0x0400037E RID: 894
		public static AutoCompleteStringCollection StockAutoComp;

		// Token: 0x0400037F RID: 895
		private static string[] stockAutoCompStringArr;

		// Token: 0x04000380 RID: 896
		public static bool IsLoadInformation;

		// Token: 0x04000381 RID: 897
		public static bool IsAreadyLogin;

		// Token: 0x04000382 RID: 898
		public static int BrokerId;

		// Token: 0x04000383 RID: 899
		public static bool IsRiskActive;

		// Token: 0x04000384 RID: 900
		public static string SuuportSBL;

		// Token: 0x04000385 RID: 901
		public static string SupportCollateral;

		// Token: 0x04000386 RID: 902
		public static string SuuportSplash;

		// Token: 0x04000387 RID: 903
		public static bool SupportNAV;

		// Token: 0x04000388 RID: 904
		public static bool SupportNod;

		// Token: 0x04000389 RID: 905
		public static int PullInterval;

		// Token: 0x0400038A RID: 906
		public static string PCCanEditorder;

		// Token: 0x0400038B RID: 907
		public static string PCCanEditorderTFEX;

		// Token: 0x0400038C RID: 908
		public static bool IsSupportTfex;

		// Token: 0x0400038D RID: 909
		public static bool IsSupportTPBlinkColor;

		// Token: 0x0400038E RID: 910
		public static string SupportBatchOrder;

		// Token: 0x0400038F RID: 911
		public static string NewsSymbol;

		// Token: 0x04000390 RID: 912
		public static bool AlertOpen;

		// Token: 0x04000391 RID: 913
		public static bool AlertAutoPopup;

		// Token: 0x04000392 RID: 914
		public static bool AlertSound;

		// Token: 0x04000393 RID: 915
		public static bool IsSupportEfinChart;

		// Token: 0x04000394 RID: 916
		public static string UrlEfinChart;

		// Token: 0x04000395 RID: 917
		public static string UrlEfinFinance;

		// Token: 0x04000396 RID: 918
		public static string UrlEfinNews;

		// Token: 0x04000397 RID: 919
		public static string UrlEfinSession;

		// Token: 0x04000398 RID: 920
		public static bool AutoTradeFromWeb;

		// Token: 0x04000399 RID: 921
		public static int AutoTradeType;

		// Token: 0x0400039A RID: 922
		public static bool IsAutoTradeAccepted;

		// Token: 0x0400039B RID: 923
		public static bool IsFrontSoftStyle;

		// Token: 0x0400039C RID: 924
		public static bool IsSupportAutoTradeTFEX;

		// Token: 0x0400039D RID: 925
		public static bool IsPushMode;

		// Token: 0x0400039E RID: 926
		public static int TunnelCounter;

		// Token: 0x0400039F RID: 927
		private static List<TunnelInfo> tunnelHosts;

		// Token: 0x040003A0 RID: 928
		public static string WebMainUrl;

		// Token: 0x040003A1 RID: 929
		public static string WebMainTfexUrl;

		// Token: 0x040003A2 RID: 930
		public static string WebUrl;

		// Token: 0x040003A3 RID: 931
		public static string WebOrderUrl;

		// Token: 0x040003A4 RID: 932
		public static string WebAlertUrl;

		// Token: 0x040003A5 RID: 933
		public static string WebTfexUrl;

		// Token: 0x040003A6 RID: 934
		private static i2TradePlus.ITSNetBusinessWS.Service webService;

		// Token: 0x040003A7 RID: 935
		private static i2TradePlus.ITSNetBusinessWS.Service webOrderService;

		// Token: 0x040003A8 RID: 936
		private static i2TradePlus.ITSNetBusinessWS.Service webAlertService;

		// Token: 0x040003A9 RID: 937
		private static i2TradePlus.ITSNetBusinessWS.Service webMainService;

		// Token: 0x040003AA RID: 938
		private static i2TradePlus.ITSNetBusinessWSTFEX.Service webServiceTFEX;

		// Token: 0x040003AB RID: 939
		private static i2TradePlus.ITSNetBusinessWSTFEX.Service webMainTfexService;

		// Token: 0x040003AC RID: 940
		public static bool CanRecvSpace;

		// Token: 0x040003AD RID: 941
		private static StockList _stockInfo;

		// Token: 0x040003AE RID: 942
		private static SeriesList _seriesInfo;

		// Token: 0x040003AF RID: 943
		private static TFEXIndex indexInfoTfex;

		// Token: 0x040003B0 RID: 944
		private static UnderlyingInfo _underlyingInfo;

		// Token: 0x040003B1 RID: 945
		public static AutoCompleteStringCollection MultiAutoComp;

		// Token: 0x040003B2 RID: 946
		private static string[] multiAutoCompStringArr;

		// Token: 0x040003B3 RID: 947
		public static AutoCompleteStringCollection SeriesAutoComp;

		// Token: 0x040003B4 RID: 948
		private static string[] seriesAutoCompStringArr;

		// Token: 0x040003B5 RID: 949
		private static IndexStat _indexStatInfo;

		// Token: 0x040003B6 RID: 950
		private static string urlSyncHandler;

		// Token: 0x040003B7 RID: 951
		public static int FavStockPerPage;

		// Token: 0x040003B8 RID: 952
		public static bool FavStockChanged;

		// Token: 0x040003B9 RID: 953
		public static Dictionary<int, List<string>> FavStockList;

		// Token: 0x040003BA RID: 954
		public static List<string> TickerStockList;

		// Token: 0x040003BB RID: 955
		public static Dictionary<string, DateTime> AutoGetOrderNoList;

		// Token: 0x040003BC RID: 956
		public static Dictionary<string, DateTime> AutoGetOrderNoList_TFEX;

		// Token: 0x040003BD RID: 957
		public static List<string> DWParentStockList;

		// Token: 0x040003BE RID: 958
		private static string _ip;

		// Token: 0x040003BF RID: 959
		public static string PINCODE_TIMEOUT;

		// Token: 0x02000080 RID: 128
		public class SendNewOrderResult
		{
			// Token: 0x06000615 RID: 1557 RVA: 0x00068378 File Offset: 0x00066778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SendNewOrderResult() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.IsFwOfflineOrder = false;
				this.IsAutoStopLoss = false;
				base..ctor();
			}

			// Token: 0x040003C1 RID: 961
			public long OrderNo;

			// Token: 0x040003C2 RID: 962
			public string ResultMessage;

			// Token: 0x040003C3 RID: 963
			public bool IsFwOfflineOrder;

			// Token: 0x040003C4 RID: 964
			public bool IsAutoStopLoss;
		}

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000617 RID: 1559
		public delegate void OnPincodeChangedCompleteHandler();
	}
}
