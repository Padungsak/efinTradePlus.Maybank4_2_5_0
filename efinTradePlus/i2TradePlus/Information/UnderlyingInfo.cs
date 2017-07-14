using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Information
{
	// Token: 0x0200021B RID: 539
	internal class UnderlyingInfo
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000F9F48 File Offset: 0x000F8348
		public Dictionary<int, UnderlyingInfo.UnderlyingList> Items
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x000F9F74 File Offset: 0x000F8374
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

		// Token: 0x06001316 RID: 4886 RVA: 0x000F9FA0 File Offset: 0x000F83A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddItem(UnderlyingInfo.UnderlyingList info)
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

		// Token: 0x1700024D RID: 589
		public UnderlyingInfo.UnderlyingList this[string indexName]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UnderlyingInfo.UnderlyingList result;
				try
				{
					if (this.itemsKeySymbol.ContainsKey(indexName))
					{
						result = this[this.itemsKeySymbol[indexName]];
					}
					else
					{
						result = new UnderlyingInfo.UnderlyingList
						{
							Symbol = string.Empty
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

		// Token: 0x1700024E RID: 590
		public UnderlyingInfo.UnderlyingList this[int orderBookId]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UnderlyingInfo.UnderlyingList result;
				try
				{
					if (this.items.ContainsKey(orderBookId))
					{
						result = this.items[orderBookId];
					}
					else
					{
						result = new UnderlyingInfo.UnderlyingList
						{
							Symbol = string.Empty
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

		// Token: 0x06001319 RID: 4889 RVA: 0x000FA114 File Offset: 0x000F8514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.items.Clear();
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000FA134 File Offset: 0x000F8534
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

		// Token: 0x0600131B RID: 4891 RVA: 0x000FA160 File Offset: 0x000F8560
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnderlyingInfo() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.items = new Dictionary<int, UnderlyingInfo.UnderlyingList>();
			this.itemsKeySymbol = new Dictionary<string, int>();
			
		}

		// Token: 0x040009EE RID: 2542
		private Dictionary<int, UnderlyingInfo.UnderlyingList> items;

		// Token: 0x040009EF RID: 2543
		private Dictionary<string, int> itemsKeySymbol;

		// Token: 0x0200021C RID: 540
		public class UnderlyingList
		{
			// Token: 0x1700024F RID: 591
			// (get) Token: 0x0600131C RID: 4892 RVA: 0x000FA194 File Offset: 0x000F8594
			// (set) Token: 0x0600131D RID: 4893 RVA: 0x000FA1C0 File Offset: 0x000F85C0
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

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x0600131E RID: 4894 RVA: 0x000FA1D8 File Offset: 0x000F85D8
			// (set) Token: 0x0600131F RID: 4895 RVA: 0x000FA204 File Offset: 0x000F8604
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

			// Token: 0x06001320 RID: 4896 RVA: 0x000FA21C File Offset: 0x000F861C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UnderlyingList() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.symbol = string.Empty;
				
			}

			// Token: 0x040009F0 RID: 2544
			private int orderBookId;

			// Token: 0x040009F1 RID: 2545
			private string symbol;
		}
	}
}
