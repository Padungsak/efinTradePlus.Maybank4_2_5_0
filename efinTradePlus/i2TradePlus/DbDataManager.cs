using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using STIControl.i2Chart.Finance;
using STIControl.i2Chart.Finance.DataProvider;

namespace i2TradePlus
{
	// Token: 0x02000237 RID: 567
	public class DbDataManager : DataManagerBase
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x001206E0 File Offset: 0x0011EAE0
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0012070C File Offset: 0x0011EB0C
		public DataSet Tds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tds;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.tds = value;
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00120724 File Offset: 0x0011EB24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DbDataManager(DataCycleBase cycle) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.cycle = DataCycleBase.DAY;
			this.tds = null;
			
			this.cycle = cycle;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00120758 File Offset: 0x0011EB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IDataProvider GetData(string Code, int Count)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			CommonDataProvider data = this.GetData(Code);
			IDataProvider result;
			if (data != null)
			{
				data.SetStringData("Code", Code);
				result = data;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x001207A4 File Offset: 0x0011EBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private CommonDataProvider GetData(string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			CommonDataProvider result;
			try
			{
				int num = 0;
				string b = "NAV";
				if (symbol == b || symbol == "SET")
				{
					DataTable dataTable = this.tds.Tables["TABLE"];
					num = dataTable.Rows.Count;
					double[] array = new double[num];
					double[] array2 = new double[num];
					double[] array3 = new double[num];
					double[] array4 = new double[num];
					double[] array5 = new double[num];
					double[] array6 = new double[num];
					double[] array7 = new double[num];
					DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
					NumberFormatInfo invariantInfo2 = NumberFormatInfo.InvariantInfo;
					double num2 = 0.0;
					for (int i = 0; i < num; i++)
					{
						DataRow dataRow = dataTable.Rows[i];
						string text = dataRow["sDate"].ToString();
						DateTime dateTime;
						DateTime.TryParse(string.Concat(new string[]
						{
							text.Substring(0, 4),
							"/",
							text.Substring(4, 2),
							"/",
							text.Substring(6, 2)
						}), out dateTime);
						if (symbol == b)
						{
							double.TryParse(dataRow["nmrNav"].ToString(), out num2);
						}
						else
						{
							double.TryParse(dataRow["nmrIndexVal"].ToString(), out num2);
						}
						array6[i] = dateTime.ToOADate();
						array2[i] = double.Parse(num2.ToString(), invariantInfo2);
						array3[i] = double.Parse(num2.ToString(), invariantInfo2);
						array4[i] = double.Parse(num2.ToString(), invariantInfo2);
						array[i] = double.Parse(num2.ToString(), invariantInfo2);
						array5[i] = 0.0;
						array7[i] = double.Parse(num2.ToString(), invariantInfo2);
					}
					CommonDataProvider commonDataProvider = new CommonDataProvider(this);
					commonDataProvider.DataCycle.CycleBase = DataCycleBase.TICK;
					commonDataProvider.LoadBinary(new double[][]
					{
						array2,
						array3,
						array4,
						array,
						array5,
						array6
					});
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
					if (array2.Length > 0)
					{
						commonDataProvider.Prior = array2[0];
					}
					commonDataProvider.Ceiling = (double)stockInformation.Ceiling;
					commonDataProvider.Floor = (double)stockInformation.Floor;
					result = commonDataProvider;
					return result;
				}
				if (this.tds.Tables.Contains("TABLE"))
				{
					if (this.tds.Tables["TABLE"].Rows.Count > 0)
					{
						num = this.tds.Tables["TABLE"].Rows.Count;
					}
					string text2 = string.Empty;
					decimal num3 = 0m;
					decimal num4 = 0m;
					decimal num5 = 0m;
					decimal num6 = 0m;
					decimal num7 = 0m;
					int num8 = 0;
					bool flag = false;
					if (num > 0 && this.tds.Tables.Contains("INFO") && this.tds.Tables["INFO"].Rows.Count > 0)
					{
						text2 = this.tds.Tables["INFO"].Rows[0]["dtLastUpd"].ToString();
						if (this.tds.Tables["TABLE"].Rows[0]["sDate"].ToString() != text2)
						{
							num++;
							flag = true;
							decimal.TryParse(this.tds.Tables["INFO"].Rows[0]["open_price1"].ToString(), out num3);
							decimal.TryParse(this.tds.Tables["INFO"].Rows[0]["last_sale_price"].ToString(), out num4);
							decimal.TryParse(this.tds.Tables["INFO"].Rows[0]["high_price"].ToString(), out num5);
							decimal.TryParse(this.tds.Tables["INFO"].Rows[0]["low_price"].ToString(), out num6);
							decimal.TryParse(this.tds.Tables["INFO"].Rows[0]["accvolume"].ToString(), out num7);
						}
					}
					double[] array = new double[num];
					double[] array2 = new double[num];
					double[] array3 = new double[num];
					double[] array4 = new double[num];
					double[] array5 = new double[num];
					double[] array6 = new double[num];
					double[] array7 = new double[num];
					DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
					NumberFormatInfo invariantInfo2 = NumberFormatInfo.InvariantInfo;
					if (flag)
					{
						DateTime dateTime;
						DateTime.TryParse(string.Concat(new string[]
						{
							text2.Substring(0, 4),
							"/",
							text2.Substring(4, 2),
							"/",
							text2.Substring(6, 2)
						}), out dateTime);
						double num9 = double.Parse(num4.ToString(), invariantInfo2);
						array6[num - 1] = dateTime.ToOADate();
						array2[num - 1] = double.Parse(num3.ToString(), invariantInfo2);
						array3[num - 1] = double.Parse(num5.ToString(), invariantInfo2);
						array4[num - 1] = double.Parse(num6.ToString(), invariantInfo2);
						array[num - 1] = num9;
						array5[num - 1] = double.Parse(num7.ToString(), invariantInfo2);
						array7[num - 1] = num9;
					}
					int count = this.tds.Tables["TABLE"].Rows.Count;
					for (int i = count - 1; i > -1; i--)
					{
						DataRow dataRow = this.tds.Tables["TABLE"].Rows[i];
						string text = dataRow["sDate"].ToString();
						DateTime dateTime;
						DateTime.TryParse(string.Concat(new string[]
						{
							text.Substring(0, 4),
							"/",
							text.Substring(4, 2),
							"/",
							text.Substring(6, 2)
						}), out dateTime);
						double num9 = double.Parse(dataRow["nmrClosingPrice"].ToString(), invariantInfo2);
						array6[num8] = dateTime.ToOADate();
						array2[num8] = double.Parse(dataRow["nmrOpenPrice1"].ToString(), invariantInfo2);
						array3[num8] = double.Parse(dataRow["nmrHighPrice"].ToString(), invariantInfo2);
						array4[num8] = double.Parse(dataRow["nmrLowPrice"].ToString(), invariantInfo2);
						array[num8] = num9;
						array5[num8] = double.Parse(dataRow["nmrDlVol"].ToString(), invariantInfo2);
						array7[num8] = num9;
						num8++;
					}
					CommonDataProvider commonDataProvider = new CommonDataProvider(this);
					commonDataProvider.DataCycle.CycleBase = DataCycleBase.TICK;
					commonDataProvider.LoadBinary(new double[][]
					{
						array2,
						array3,
						array4,
						array,
						array5,
						array6
					});
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
					commonDataProvider.Prior = 0.0;
					commonDataProvider.Ceiling = (double)stockInformation.Ceiling;
					commonDataProvider.Floor = (double)stockInformation.Floor;
					result = commonDataProvider;
					return result;
				}
			}
			catch
			{
			}
			result = CommonDataProvider.Empty;
			return result;
		}

		// Token: 0x04000B44 RID: 2884
		private DataCycleBase cycle;

		// Token: 0x04000B45 RID: 2885
		private DataSet tds;
	}
}
