using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.MyDataSet;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using ITSNet.Common.BIZ.RealtimeMessage.TFEX;

namespace i2TradePlus
{
	// Token: 0x02000227 RID: 551
	internal class AlertManager : IRealtimeMessage
	{
		// Token: 0x140000CC RID: 204
		// (add) Token: 0x0600141B RID: 5147 RVA: 0x0010E1A8 File Offset: 0x0010C5A8
		// (remove) Token: 0x0600141C RID: 5148 RVA: 0x0010E1D0 File Offset: 0x0010C5D0
		internal event AlertManager.OnAlertHandler OnAlert
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnAlert = (AlertManager.OnAlertHandler)Delegate.Combine(this.OnAlert, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnAlert = (AlertManager.OnAlertHandler)Delegate.Remove(this.OnAlert, value);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0010E1F8 File Offset: 0x0010C5F8
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0010E23C File Offset: 0x0010C63C
		internal static AlertManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (AlertManager.instance == null)
				{
					AlertManager.instance = new AlertManager();
				}
				return AlertManager.instance;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				AlertManager.instance = value;
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0010E254 File Offset: 0x0010C654
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AlertManager() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.symbols = null;
			this._bcMessages = new Queue<AlertManager.AlertBcItem>();
			this.isMonitoring = false;
			
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0010E28C File Offset: 0x0010C68C
		internal Dictionary<string, AlertItemCollection> Symbols
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.symbols == null)
				{
					this.symbols = new Dictionary<string, AlertItemCollection>();
				}
				return this.symbols;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0010E2D4 File Offset: 0x0010C6D4
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0010E300 File Offset: 0x0010C700
		internal bool IsMonitoring
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isMonitoring;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isMonitoring = value;
				if (value)
				{
					Thread thread = new Thread(new ThreadStart(this.MessageMonitoring));
					thread.Start();
				}
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0010E34C File Offset: 0x0010C74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddItem(LSAccumulate msgLS, string symbol, decimal changePrice, decimal changePricePct, long boardLot)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IsMonitoring)
			{
				lock (((ICollection)this._bcMessages).SyncRoot)
				{
					this._bcMessages.Enqueue(new AlertManager.AlertBcItem(msgLS.MessageType, msgLS.LastPrice, msgLS.Volume, symbol, changePrice, changePricePct, boardLot));
				}
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0010E3D4 File Offset: 0x0010C7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddItem(TPMessage msgTP, string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IsMonitoring)
			{
				lock (((ICollection)this._bcMessages).SyncRoot)
				{
					this._bcMessages.Enqueue(new AlertManager.AlertBcItem(msgTP.MessageType, symbol, msgTP.Side, msgTP.Price1));
				}
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0010E458 File Offset: 0x0010C858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddItem(LSMessageTFEX msgLS, string symbol, decimal changePrice, decimal changePricePct, long boardLot)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IsMonitoring)
			{
				lock (((ICollection)this._bcMessages).SyncRoot)
				{
					this._bcMessages.Enqueue(new AlertManager.AlertBcItem("L+", msgLS.Price, (long)msgLS.Vol, symbol, changePrice, changePricePct, boardLot));
				}
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0010E4E0 File Offset: 0x0010C8E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string GetOrderFilePath()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return ApplicationInfo.WORKING_ROOTPATH + "\\AlertOption\\" + ApplicationInfo.UserLoginID + "\\AlertOrder.xml";
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0010E520 File Offset: 0x0010C920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.symbols == null)
				{
					this.symbols = new Dictionary<string, AlertItemCollection>();
				}
				else
				{
					this.symbols.Clear();
				}
				AlertCustomerExpressionDS alertCustomerExpressionDS = new AlertCustomerExpressionDS();
				string orderFilePath = this.GetOrderFilePath();
				if (File.Exists(orderFilePath))
				{
					alertCustomerExpressionDS.ReadXml(orderFilePath);
					this.ImportFromXML(alertCustomerExpressionDS);
				}
				alertCustomerExpressionDS.Clear();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return true;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0010E5CC File Offset: 0x0010C9CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ImportFromXML(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ds.Tables[0].Rows.Count > 0)
				{
					lock (this.symbols)
					{
						string key = string.Empty;
						try
						{
							bool flag = ds.Tables[0].Columns.Contains("AlertTime");
							bool flag2 = ds.Tables[0].Columns.Contains("AlertValue");
							for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
							{
								key = ds.Tables[0].Rows[i]["Symbol"].ToString();
								if (!this.symbols.ContainsKey(key))
								{
									this.symbols.Add(key, new AlertItemCollection());
								}
								AlertItem alertItem = new AlertItem();
								alertItem.Symbol = ds.Tables[0].Rows[i]["Symbol"].ToString();
								alertItem.Field = ds.Tables[0].Rows[i]["ColumnsAlert"].ToString();
								alertItem.Operator = ds.Tables[0].Rows[i]["Operator"].ToString();
								alertItem.Value = ds.Tables[0].Rows[i]["Values"].ToString();
								alertItem.IsReaded = false;
								if (flag && !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["AlertTime"].ToString()))
								{
									alertItem.AlertTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["AlertTime"].ToString());
								}
								else
								{
									alertItem.AlertTime = DateTime.MinValue;
								}
								if (flag2 && !string.IsNullOrEmpty(ds.Tables[0].Rows[i]["AlertValue"].ToString()))
								{
									alertItem.ValueMessageRealtime = ds.Tables[0].Rows[i]["AlertValue"].ToString();
								}
								else
								{
									alertItem.ValueMessageRealtime = string.Empty;
								}
								this.symbols[alertItem.Symbol].Add(alertItem);
							}
						}
						catch (Exception ex)
						{
							throw ex;
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0010E93C File Offset: 0x0010CD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string ExportToXML()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			throw new NotImplementedException();
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0010E960 File Offset: 0x0010CD60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveXML()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string orderFilePath = AlertManager.Instance.GetOrderFilePath();
				AlertCustomerExpressionDS alertCustomerExpressionDS = new AlertCustomerExpressionDS();
				if (!Directory.Exists(ApplicationInfo.WORKING_ROOTPATH + "\\AlertOption\\" + ApplicationInfo.UserLoginID))
				{
					Directory.CreateDirectory(ApplicationInfo.WORKING_ROOTPATH + "\\AlertOption\\" + ApplicationInfo.UserLoginID);
				}
				foreach (KeyValuePair<string, AlertItemCollection> current in AlertManager.Instance.Symbols)
				{
					foreach (AlertItem current2 in current.Value)
					{
						DataRow dataRow = alertCustomerExpressionDS.AlertCollection.NewRow();
						dataRow["Symbol"] = current2.Symbol;
						dataRow["ColumnsAlert"] = current2.Field;
						dataRow["Operator"] = current2.Operator;
						dataRow["Values"] = current2.Value;
						dataRow["AlertTime"] = current2.AlertTime.ToString();
						dataRow["AlertValue"] = current2.ValueMessageRealtime;
						alertCustomerExpressionDS.AlertCollection.Rows.Add(dataRow);
					}
				}
				if (alertCustomerExpressionDS.AlertCollection != null)
				{
					alertCustomerExpressionDS.WriteXml(orderFilePath);
				}
				alertCustomerExpressionDS = null;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0010EB6C File Offset: 0x0010CF6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MessageMonitoring()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			while (this.isMonitoring)
			{
				int i = 0;
				lock (((ICollection)this._bcMessages).SyncRoot)
				{
					i = this._bcMessages.Count;
				}
				while (i > 0)
				{
					try
					{
						AlertManager.AlertBcItem alertBcItem;
						lock (((ICollection)this._bcMessages).SyncRoot)
						{
							alertBcItem = this._bcMessages.Dequeue();
						}
						i--;
						if (alertBcItem.Symbol != null)
						{
							AlertItemCollection alertItemCollection = null;
							if (this.symbols.TryGetValue(alertBcItem.Symbol, out alertItemCollection))
							{
								foreach (AlertItem current in alertItemCollection)
								{
									bool flag = false;
									if (current.AlertTime == DateTime.MinValue)
									{
										if (alertBcItem.MessageType == "L+")
										{
											string text = current.Field.ToLower();
											if (text != null)
											{
												if (!(text == "lastprice"))
												{
													if (text == "%change")
													{
														if (this.ConditionCompare(current, alertBcItem.ChangePricePct))
														{
															current.ValueMessageRealtime = Math.Round(alertBcItem.ChangePricePct, 4).ToString();
															flag = true;
														}
													}
												}
												else if (this.ConditionCompare(current, alertBcItem.LastPrice))
												{
													current.ValueMessageRealtime = alertBcItem.LastPrice.ToString();
													flag = true;
												}
											}
										}
									}
									if (flag)
									{
										bool flag2 = false;
										if (!current.IsReaded)
										{
											current.IsReaded = true;
											current.AlertTime = DateTime.Now;
											flag2 = true;
										}
										if (flag2 && this.OnAlert != null)
										{
											this.OnAlert(new AlertItem(current));
										}
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						ExceptionManager.Show(new ErrorItem(DateTime.Now, "AlertManager", "MessageMonitoring", ex.Message, ex.ToString()));
					}
					if (!this.isMonitoring)
					{
						break;
					}
				}
				Thread.Sleep(30);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0010EEB0 File Offset: 0x0010D2B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConditionCompare(AlertItem alertItem, decimal itemValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			decimal d;
			decimal.TryParse(alertItem.Value, out d);
			if (alertItem.Operator == "=")
			{
				result = (Math.Round(itemValue, 4) == Math.Round(d, 4));
			}
			else if (alertItem.Operator == ">=")
			{
				result = (Math.Round(itemValue, 4) >= Math.Round(d, 4));
			}
			else if (alertItem.Operator == "<=")
			{
				result = (Math.Round(itemValue, 4) <= Math.Round(d, 4));
			}
			return result;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0010EF78 File Offset: 0x0010D378
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConditionCompare(AlertItem alertItem, int itemValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			int num;
			int.TryParse(alertItem.Value, out num);
			if (alertItem.Operator == "=")
			{
				result = (itemValue == num);
			}
			else if (alertItem.Operator == ">=")
			{
				result = (itemValue >= num);
			}
			else if (alertItem.Operator == "<=")
			{
				result = (itemValue <= num);
			}
			return result;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0010F01C File Offset: 0x0010D41C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConditionCompare(AlertItem alertItem, long itemValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			long num;
			long.TryParse(alertItem.Value, out num);
			if (alertItem.Operator == "=")
			{
				result = (itemValue == num);
			}
			else if (alertItem.Operator == ">=")
			{
				result = (itemValue >= num);
			}
			else if (alertItem.Operator == "<=")
			{
				result = (itemValue <= num);
			}
			return result;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0010F0C0 File Offset: 0x0010D4C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool IsMessageForAlertMonitor(IBroadcastMessage item)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string empty = string.Empty;
			return this.IsMessageForAlertMonitor(item, out empty);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0010F0F4 File Offset: 0x0010D4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool IsMessageForAlertMonitor(IBroadcastMessage item, out string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			string text = string.Empty;
			bool result;
			if (item == null)
			{
				symbol = text;
				result = flag;
			}
			else
			{
				string messageType = item.MessageType;
				if (messageType != null)
				{
					if (!(messageType == "L+"))
					{
						if (messageType == "PD")
						{
							text = ApplicationInfo.StockInfo[(item as PDMessage).SecurityNumber].Symbol;
							flag = true;
						}
					}
					else
					{
						text = ApplicationInfo.StockInfo[(item as LSAccumulate).SecurityNumber].Symbol;
						flag = true;
					}
				}
				symbol = text;
				result = flag;
			}
			return result;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0010F1BC File Offset: 0x0010D5BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void MarkUnReadAll()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.symbols != null)
			{
				foreach (KeyValuePair<string, AlertItemCollection> current in this.symbols)
				{
					foreach (AlertItem current2 in current.Value)
					{
						current2.IsReaded = false;
					}
				}
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0010F290 File Offset: 0x0010D690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void MarkUnRead(string symbol, AlertItem item)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			AlertItemCollection alertItemCollection = null;
			if (this.symbols.TryGetValue(symbol, out alertItemCollection))
			{
				if (alertItemCollection.Contains(item))
				{
					item.IsReaded = false;
				}
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0010F2E4 File Offset: 0x0010D6E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (messageType == "L+")
					{
						if (ApplicationInfo.AlertOpen)
						{
							this.AddItem((LSAccumulate)message, realtimeStockInfo.Symbol, realtimeStockInfo.ChangePrice, realtimeStockInfo.ChangePricePct, (long)realtimeStockInfo.BoardLot);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0010F380 File Offset: 0x0010D780
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (messageType == "LS")
					{
						if (ApplicationInfo.AlertOpen)
						{
							this.AddItem((LSMessageTFEX)message, realtimeSeriesInfo.Symbol, realtimeSeriesInfo.ChangePrice, realtimeSeriesInfo.ChangePricePct, 1L);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0010F418 File Offset: 0x0010D818
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlertManager()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			AlertManager.instance = null;
		}

		// Token: 0x04000A84 RID: 2692
		private static AlertManager instance;

		// Token: 0x04000A85 RID: 2693
		private Dictionary<string, AlertItemCollection> symbols;

		// Token: 0x04000A86 RID: 2694
		private Queue<AlertManager.AlertBcItem> _bcMessages;

		// Token: 0x04000A87 RID: 2695
		private bool isMonitoring;

		// Token: 0x02000228 RID: 552
		// (Invoke) Token: 0x06001437 RID: 5175
		internal delegate void OnAlertHandler(AlertItem e);

		// Token: 0x02000229 RID: 553
		private struct AlertBcItem
		{
			// Token: 0x0600143A RID: 5178 RVA: 0x0010F434 File Offset: 0x0010D834
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AlertBcItem(string messageType, decimal lastPrice, long volume, string symbol, decimal changePrice, decimal changePricePct, long boardLot)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.MessageType = messageType;
				this.LastPrice = lastPrice;
				this.Volume = volume * boardLot;
				this.Symbol = symbol;
				this.ChangePrice = changePrice;
				this.ChangePricePct = changePricePct;
				this.Side = string.Empty;
				this.BidPrice = 0m;
				this.OfferPrice = 0m;
			}

			// Token: 0x0600143B RID: 5179 RVA: 0x0010F4A8 File Offset: 0x0010D8A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AlertBcItem(string messageType, string symbol, string side, decimal price1)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.MessageType = messageType;
				this.BidPrice = 0m;
				this.OfferPrice = 0m;
				this.Side = side;
				if (side == "B")
				{
					this.BidPrice = price1;
				}
				else if (side == "S")
				{
					this.OfferPrice = price1;
				}
				this.Symbol = symbol;
				this.LastPrice = 0m;
				this.Volume = 0L;
				this.ChangePrice = 0m;
				this.ChangePricePct = 0m;
			}

			// Token: 0x04000A88 RID: 2696
			internal string MessageType;

			// Token: 0x04000A89 RID: 2697
			internal string Symbol;

			// Token: 0x04000A8A RID: 2698
			internal decimal LastPrice;

			// Token: 0x04000A8B RID: 2699
			internal long Volume;

			// Token: 0x04000A8C RID: 2700
			internal decimal ChangePrice;

			// Token: 0x04000A8D RID: 2701
			internal decimal ChangePricePct;

			// Token: 0x04000A8E RID: 2702
			internal string Side;

			// Token: 0x04000A8F RID: 2703
			internal decimal BidPrice;

			// Token: 0x04000A90 RID: 2704
			internal decimal OfferPrice;
		}
	}
}
