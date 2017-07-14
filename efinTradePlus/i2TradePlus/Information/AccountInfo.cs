using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Information
{
	// Token: 0x020000AB RID: 171
	internal class AccountInfo
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0009D254 File Offset: 0x0009B654
		internal Dictionary<string, AccountInfo.ItemInfo> Items
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0009D280 File Offset: 0x0009B680
		public decimal TotalCommAndFee
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.CurrentCommRate + this.CurrentTradingFee + this.CurrentClearingFee;
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0009D2C0 File Offset: 0x0009B6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountInfo() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.CurrentAccount = string.Empty;
			this.CurrentAccountType = string.Empty;
			this.CurrInternetUser = string.Empty;
			this.InternetUser = string.Empty;
			this.InternetMutualUser = string.Empty;
			this.UserInternetInBroker = "Y";
			this.UserLists = string.Empty;
			this.InternetUserTFEX = string.Empty;
			this.CurrentCommRate = 0m;
			this.CurrentTradingFee = 0m;
			this.CurrentClearingFee = 0m;
			
			this.items = new Dictionary<string, AccountInfo.ItemInfo>();
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0009D370 File Offset: 0x0009B770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAccCanTrade(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				AccountInfo.ItemInfo itemInfo;
				if (this.items.TryGetValue(account, out itemInfo))
				{
					result = (itemInfo.CanTrade == "Y");
					return result;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			result = false;
			return result;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0009D3EC File Offset: 0x0009B7EC
		public bool IsCurrAccCreditBalance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.CurrentAccountType.Equals("B") || this.CurrentAccountType.Equals("T") || this.CurrentAccountType.Equals("L") || this.CurrentAccountType.Equals("M");
			}
		}

		// Token: 0x040004D6 RID: 1238
		private Dictionary<string, AccountInfo.ItemInfo> items;

		// Token: 0x040004D7 RID: 1239
		public string CurrentAccount;

		// Token: 0x040004D8 RID: 1240
		public string CurrentAccountType;

		// Token: 0x040004D9 RID: 1241
		public string CurrInternetUser;

		// Token: 0x040004DA RID: 1242
		public string InternetUser;

		// Token: 0x040004DB RID: 1243
		public string InternetMutualUser;

		// Token: 0x040004DC RID: 1244
		public string UserInternetInBroker;

		// Token: 0x040004DD RID: 1245
		public string UserLists;

		// Token: 0x040004DE RID: 1246
		public string InternetUserTFEX;

		// Token: 0x040004DF RID: 1247
		public decimal CurrentCommRate;

		// Token: 0x040004E0 RID: 1248
		public decimal CurrentTradingFee;

		// Token: 0x040004E1 RID: 1249
		public decimal CurrentClearingFee;

		// Token: 0x020000AC RID: 172
		public class ItemInfo
		{
			// Token: 0x06000814 RID: 2068 RVA: 0x0009D464 File Offset: 0x0009B864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ItemInfo() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.AccountType = string.Empty;
				this.CanTrade = "Y";
				this.PcFlag = string.Empty;
				this.Market = string.Empty;
				this.TraderId = string.Empty;
				
			}

			// Token: 0x040004E2 RID: 1250
			public string AccountType;

			// Token: 0x040004E3 RID: 1251
			public string CanTrade;

			// Token: 0x040004E4 RID: 1252
			public string PcFlag;

			// Token: 0x040004E5 RID: 1253
			public string Market;

			// Token: 0x040004E6 RID: 1254
			public string TraderId;
		}
	}
}
