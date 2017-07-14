using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.FixForm;

namespace i2TradePlus
{
	// Token: 0x020000A0 RID: 160
	internal class MainFixedTemplate
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0008E8F4 File Offset: 0x0008CCF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MainFixedTemplate() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0008E914 File Offset: 0x0008CD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<MainFixedTemplate.ControlClient> GetFixedTemplate(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> result;
			if (templateName == "Portfolio")
			{
				result = MainFixedTemplate.Portfolio();
			}
			else if (templateName == "View Order")
			{
				result = MainFixedTemplate.ViewOrder();
			}
			else if (templateName == "My List")
			{
				result = MainFixedTemplate.MarketWatch();
			}
			else if (templateName == "Bids")
			{
				result = MainFixedTemplate.TopBBOs();
			}
			else if (templateName == "Market Information")
			{
				result = MainFixedTemplate.MarketInfo();
			}
			else if (templateName == "Graph")
			{
				result = MainFixedTemplate.StockHistory();
			}
			else if (templateName == "Finance")
			{
				result = MainFixedTemplate.StockHistory();
			}
			else if (templateName == "News")
			{
				result = MainFixedTemplate.StockHistory();
			}
			else if (templateName == "SET News")
			{
				result = MainFixedTemplate.NewsCenter();
			}
			else if (templateName == "Batch Order")
			{
				result = MainFixedTemplate.BatchOrder();
			}
			else if (templateName == "Stock in Play" || templateName == "Sale by Price" || templateName == "Sale by Time" || templateName == "View Oddlot")
			{
				result = MainFixedTemplate.StockSummary();
			}
			else if (templateName == "Ranking")
			{
				result = MainFixedTemplate.StockRanking("");
			}
			else if (templateName == "AutoTrade")
			{
				result = MainFixedTemplate.AutoTrade();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0008EB14 File Offset: 0x0008CF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> NewsCenter()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new List<MainFixedTemplate.ControlClient>
			{
				new MainFixedTemplate.ControlClient(typeof(frmBrowser), DockStyle.Fill, new Dictionary<string, object>())
			};
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0008EB5C File Offset: 0x0008CF5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> BatchOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new List<MainFixedTemplate.ControlClient>
			{
				new MainFixedTemplate.ControlClient(typeof(frmBatchOrder), DockStyle.Fill, new Dictionary<string, object>())
			};
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0008EBA4 File Offset: 0x0008CFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> Portfolio()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmPortfolio), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0008EBEC File Offset: 0x0008CFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> StockThreshold()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmRiskControl), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0008EC34 File Offset: 0x0008D034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> MarketInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmMarketInfo), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0008EC7C File Offset: 0x0008D07C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> ViewOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmViewOrder), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0008ECC4 File Offset: 0x0008D0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> MarketWatch()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("DefaultStock", "BBL");
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmMarketWatch), DockStyle.Fill, dictionary));
			return list;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0008ED20 File Offset: 0x0008D120
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> StockHistory()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("DefaultStock", "BBL");
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmStockChart), DockStyle.Fill, dictionary));
			return list;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0008ED7C File Offset: 0x0008D17C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> TopBBOs()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmTopBBOs), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0008EDC4 File Offset: 0x0008D1C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> StockSummary()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("DefaultStock", "BBL");
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmStockSummary), DockStyle.Fill, dictionary));
			return list;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0008EE20 File Offset: 0x0008D220
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> StockRanking(string page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (page != string.Empty)
			{
				dictionary.Add("Page", page);
			}
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmStockRanking), DockStyle.Fill, dictionary));
			return list;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0008EE8C File Offset: 0x0008D28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<MainFixedTemplate.ControlClient> AutoTrade()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<MainFixedTemplate.ControlClient> list = new List<MainFixedTemplate.ControlClient>();
			Dictionary<string, object> property = new Dictionary<string, object>();
			list.Add(new MainFixedTemplate.ControlClient(typeof(frmAutoTrade), DockStyle.Fill, property));
			return list;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0008EED4 File Offset: 0x0008D2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<MainFixedTemplate.TemplateProperty> GetFixedTemplateName()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (MainFixedTemplate.templateNameList == null)
			{
				MainFixedTemplate.templateNameList = new List<MainFixedTemplate.TemplateProperty>();
			}
			MainFixedTemplate.templateNameList.Clear();
			MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("Bids", 112));
			MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("My List", 113));
			if (!ApplicationInfo.SupportFreewill)
			{
				MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("Graph", 114));
			}
			MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("Ranking", 115));
			MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("Market Information", 116));
			MainFixedTemplate.templateNameList.Add(new MainFixedTemplate.TemplateProperty("SET News", 118));
			return MainFixedTemplate.templateNameList;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0008EFBC File Offset: 0x0008D3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<MainFixedTemplate.TemplateProperty> GetOrderTemplateName()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (MainFixedTemplate.orderTemplateNameList == null)
			{
				MainFixedTemplate.orderTemplateNameList = new List<MainFixedTemplate.TemplateProperty>();
			}
			MainFixedTemplate.orderTemplateNameList.Clear();
			if (ApplicationInfo.UserLoginMode != "I")
			{
				MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("View Order", 117));
				MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("Buy Order", 144));
				MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("Sell Order", 109));
				if (ApplicationInfo.SuuportSBL == "Y")
				{
					MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("Short Sell Order", 111));
					MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("Cover Buy Order", 106));
				}
				MainFixedTemplate.orderTemplateNameList.Add(new MainFixedTemplate.TemplateProperty("Portfolio", 119));
			}
			return MainFixedTemplate.orderTemplateNameList;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0008F0D0 File Offset: 0x0008D4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MainFixedTemplate()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			MainFixedTemplate.templateNameList = null;
			MainFixedTemplate.orderTemplateNameList = null;
		}

		// Token: 0x04000479 RID: 1145
		private static List<MainFixedTemplate.TemplateProperty> templateNameList;

		// Token: 0x0400047A RID: 1146
		private static List<MainFixedTemplate.TemplateProperty> orderTemplateNameList;

		// Token: 0x020000A1 RID: 161
		public class ControlClient
		{
			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0008F0F4 File Offset: 0x0008D4F4
			internal Type ControlType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.controlType;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0008F120 File Offset: 0x0008D520
			internal DockStyle ControlDock
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.controlDock;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0008F14C File Offset: 0x0008D54C
			internal Dictionary<string, object> Property
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.property;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x0008F178 File Offset: 0x0008D578
			internal int FormIndex
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.formIndex;
				}
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x0008F1A4 File Offset: 0x0008D5A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ControlClient(Type controlType, DockStyle controlDock, Dictionary<string, object> property) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.property = null;
				this.formIndex = 0;
				
				this.controlType = controlType;
				this.formIndex = 0;
				this.controlDock = controlDock;
				this.property = property;
			}

			// Token: 0x0400047B RID: 1147
			private Type controlType;

			// Token: 0x0400047C RID: 1148
			private DockStyle controlDock;

			// Token: 0x0400047D RID: 1149
			private Dictionary<string, object> property;

			// Token: 0x0400047E RID: 1150
			private int formIndex;
		}

		// Token: 0x020000A2 RID: 162
		public class TemplateProperty
		{
			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x0008F1F8 File Offset: 0x0008D5F8
			internal string TempateName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.tempateName;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060007AD RID: 1965 RVA: 0x0008F224 File Offset: 0x0008D624
			// (set) Token: 0x060007AE RID: 1966 RVA: 0x0008F250 File Offset: 0x0008D650
			internal int Hotkey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.hotkey;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.hotkey = value;
				}
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x0008F268 File Offset: 0x0008D668
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateProperty(string templateName, int hotkey) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.tempateName = string.Empty;
				
				this.tempateName = templateName;
				this.hotkey = hotkey;
			}

			// Token: 0x0400047F RID: 1151
			private string tempateName;

			// Token: 0x04000480 RID: 1152
			private int hotkey;
		}
	}
}
