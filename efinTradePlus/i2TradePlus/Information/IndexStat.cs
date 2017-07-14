using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.Information
{
	// Token: 0x02000048 RID: 72
	public class IndexStat
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0003AB68 File Offset: 0x00038F68
		public List<IndexStat.IndexItem> Items
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

		// Token: 0x17000059 RID: 89
		public IndexStat.IndexItem this[string symbol]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.items.Find(delegate(IndexStat.IndexItem item)
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return item.Symbol == symbol;
				});
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0003ABDC File Offset: 0x00038FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexStat.IndexItem GetSector(int sectorNo)
		{
			return this.items.Find(delegate(IndexStat.IndexItem item)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return item.Number == sectorNo && item.Type == "S";
			});
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0003AC24 File Offset: 0x00039024
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexStat.IndexItem GetIndustry(int industryNo)
		{
			return this.items.Find(delegate(IndexStat.IndexItem item)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return item.Number == industryNo && item.Type == "I";
			});
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0003AC6C File Offset: 0x0003906C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.items.Clear();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0003AC8C File Offset: 0x0003908C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ResetData();
			this.items = null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0003ACAC File Offset: 0x000390AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexStat() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.items = new List<IndexStat.IndexItem>();
			
		}

		// Token: 0x040001E7 RID: 487
		private List<IndexStat.IndexItem> items;

		// Token: 0x02000049 RID: 73
		public class IndexItem
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000338 RID: 824 RVA: 0x0003ACD4 File Offset: 0x000390D4
			// (set) Token: 0x06000339 RID: 825 RVA: 0x0003AD00 File Offset: 0x00039100
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

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600033A RID: 826 RVA: 0x0003AD18 File Offset: 0x00039118
			// (set) Token: 0x0600033B RID: 827 RVA: 0x0003AD44 File Offset: 0x00039144
			public string Type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.type;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.type = value;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0003AD5C File Offset: 0x0003915C
			// (set) Token: 0x0600033D RID: 829 RVA: 0x0003AD88 File Offset: 0x00039188
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

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0003ADA0 File Offset: 0x000391A0
			// (set) Token: 0x0600033F RID: 831 RVA: 0x0003ADCC File Offset: 0x000391CC
			public string Fullname
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.fullName;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.fullName = value;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000340 RID: 832 RVA: 0x0003ADE4 File Offset: 0x000391E4
			// (set) Token: 0x06000341 RID: 833 RVA: 0x0003AE10 File Offset: 0x00039210
			public bool IsMainMarket
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.isMainMarket;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.isMainMarket = value;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0003AE28 File Offset: 0x00039228
			// (set) Token: 0x06000343 RID: 835 RVA: 0x0003AE54 File Offset: 0x00039254
			public decimal Prior
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.prior;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.prior = value;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0003AE6C File Offset: 0x0003926C
			// (set) Token: 0x06000345 RID: 837 RVA: 0x0003AE98 File Offset: 0x00039298
			public decimal LastIndex
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.lastIndex;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.lastIndex = value;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0003AEB0 File Offset: 0x000392B0
			// (set) Token: 0x06000347 RID: 839 RVA: 0x0003AEDC File Offset: 0x000392DC
			public decimal AccValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.accValue;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.accValue = value;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000348 RID: 840 RVA: 0x0003AEF4 File Offset: 0x000392F4
			// (set) Token: 0x06000349 RID: 841 RVA: 0x0003AF20 File Offset: 0x00039320
			public decimal IndexHigh
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.indexHigh;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.indexHigh = value;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600034A RID: 842 RVA: 0x0003AF38 File Offset: 0x00039338
			// (set) Token: 0x0600034B RID: 843 RVA: 0x0003AF64 File Offset: 0x00039364
			public decimal IndexLow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.indexLow;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.indexLow = value;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0003AF7C File Offset: 0x0003937C
			public decimal IndexChg
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					decimal result;
					if (this.prior > 0m && this.lastIndex > 0m)
					{
						result = this.lastIndex - this.prior;
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0003AFF4 File Offset: 0x000393F4
			public decimal IndexChgPct
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					decimal result;
					if (this.prior > 0m && this.lastIndex > 0m)
					{
						result = (this.lastIndex - this.prior) / this.prior * 100m;
					}
					else
					{
						result = 0m;
					}
					return result;
				}
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0003B084 File Offset: 0x00039484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IndexItem() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.type = string.Empty;
				this.isMainMarket = true;
				
			}

			// Token: 0x040001E8 RID: 488
			private int number;

			// Token: 0x040001E9 RID: 489
			private string type;

			// Token: 0x040001EA RID: 490
			private string symbol;

			// Token: 0x040001EB RID: 491
			private string fullName;

			// Token: 0x040001EC RID: 492
			private bool isMainMarket;

			// Token: 0x040001ED RID: 493
			private decimal prior;

			// Token: 0x040001EE RID: 494
			private decimal lastIndex;

			// Token: 0x040001EF RID: 495
			private decimal accValue;

			// Token: 0x040001F0 RID: 496
			private decimal indexHigh;

			// Token: 0x040001F1 RID: 497
			private decimal indexLow;
		}
	}
}
