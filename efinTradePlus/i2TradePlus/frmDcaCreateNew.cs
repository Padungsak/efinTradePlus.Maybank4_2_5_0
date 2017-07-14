using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.AutoTradeMessage;
using STIControl;
using STIControl.ExpandTableGrid;

namespace i2TradePlus
{
	// Token: 0x020000EB RID: 235
	public class frmDcaCreateNew : Form
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x000C9744 File Offset: 0x000C7B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmDcaCreateNew(List<string> holidays) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.bgwSendOrder = null;
			this._holidays = null;
			this._commandDca = null;
			this._frmConfirm = null;
			this.components = null;
			
			this.InitializeComponent();
			try
			{
				this._holidays = holidays;
				if (this.cbDcaStock.AutoCompleteCustomSource != null)
				{
					if (this.cbDcaStock.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.StockAutoComp != null)
					{
						this.cbDcaStock.AutoCompleteMode = AutoCompleteMode.Suggest;
						this.cbDcaStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
						this.cbDcaStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
					}
				}
				this.bgwSendOrder = new BackgroundWorker();
				this.bgwSendOrder.WorkerReportsProgress = true;
				this.bgwSendOrder.DoWork += new DoWorkEventHandler(this.bgwSendOrder_DoWork);
				this.bgwSendOrder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSendOrder_RunWorkerCompleted);
				this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
			}
			catch (Exception ex)
			{
				this.ShowError("frmDcaCreateNew", ex);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000C9894 File Offset: 0x000C7C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnDcaSimlulate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				DateTime value = this.dateTimePicker1.Value;
				DateTime value2 = this.dateTimePicker2.Value;
				if (this.cbDcaStock.Text == string.Empty)
				{
					this.ShowMessageBox("Invalid symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbDcaStock);
				}
				else
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbDcaStock.Text];
					if (stockInformation.Number <= 0)
					{
						this.ShowMessageBox("Invalid symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbDcaStock);
					}
					else
					{
						long num;
						long.TryParse(this.tbDcaBudget.Text.Replace(",", ""), out num);
						if (num <= 0L)
						{
							this.ShowMessageBox("Invalid budget!!!", frmOrderFormConfirm.OpenStyle.Error, this.tbDcaBudget);
						}
						else if (value.ToShortDateString() == DateTime.Now.ToShortDateString())
						{
							this.ShowMessageBox("Start date is tomorrow onwards.", frmOrderFormConfirm.OpenStyle.Error, this.dateTimePicker1);
						}
						else if (value < DateTime.Now)
						{
							this.ShowMessageBox("Start date is tomorrow onwards.", frmOrderFormConfirm.OpenStyle.Error, this.dateTimePicker1);
						}
						else if (value2 <= value)
						{
							this.ShowMessageBox("Invalid end date!!!", frmOrderFormConfirm.OpenStyle.Error, this.dateTimePicker2);
						}
						else
						{
							if (this.cbDcaTiming.Text.ToLower() == "every day")
							{
								DateTime dateTime = this.getNextDate(value);
								List<DateTime> list = new List<DateTime>();
								while (dateTime <= value2)
								{
									list.Add(dateTime);
									dateTime = dateTime.AddDays(1.0);
									dateTime = this.getNextDate(dateTime);
								}
								if (list.Count <= 0)
								{
									this.ShowMessageBox("Can not create command Please check the terms", frmOrderFormConfirm.OpenStyle.Error, null);
									return;
								}
								decimal num2 = (list.Count > 0) ? (num / (long)list.Count) : 0L;
								this.gridDcaSimm.Rows = list.Count;
								int i = 0;
								foreach (DateTime current in list)
								{
									RecordItem recordItem = this.gridDcaSimm.Records(i);
									recordItem.Fields("no").Text = i + 1;
									recordItem.Fields("date").Text = current.ToString("dd MMM yy");
									recordItem.Fields("tmp_date").Text = current.ToString("yyyyMMdd");
									recordItem.Fields("budget").Text = num2.ToString();
									i++;
								}
								list.Clear();
								this.gridDcaSimm.Redraw();
							}
							else if (this.cbDcaTiming.Text.ToLower() == "every week")
							{
								DateTime dateTime = value;
								DayOfWeek dayOfWeek = DayOfWeek.Sunday;
								string text = this.cbDcaTiming2.Text.ToLower().Trim();
								if (text != null)
								{
									if (!(text == "monday"))
									{
										if (!(text == "tuesday"))
										{
											if (!(text == "wednesday"))
											{
												if (!(text == "thursday"))
												{
													if (text == "friday")
													{
														dayOfWeek = DayOfWeek.Friday;
													}
												}
												else
												{
													dayOfWeek = DayOfWeek.Thursday;
												}
											}
											else
											{
												dayOfWeek = DayOfWeek.Wednesday;
											}
										}
										else
										{
											dayOfWeek = DayOfWeek.Tuesday;
										}
									}
									else
									{
										dayOfWeek = DayOfWeek.Monday;
									}
								}
								dateTime = this.getNextWeek(dateTime, dayOfWeek);
								List<DateTime> list = new List<DateTime>();
								while (dateTime <= value2)
								{
									list.Add(dateTime);
									dateTime = dateTime.AddDays(1.0);
									dateTime = this.getNextWeek(dateTime, dayOfWeek);
									if (dateTime > value2)
									{
										break;
									}
								}
								if (list.Count <= 0)
								{
									this.ShowMessageBox("Can not create command Please check the terms", frmOrderFormConfirm.OpenStyle.Error, null);
									return;
								}
								decimal num2 = (list.Count > 0) ? (num / (long)list.Count) : 0L;
								this.gridDcaSimm.Rows = list.Count;
								int i = 0;
								foreach (DateTime current in list)
								{
									RecordItem recordItem = this.gridDcaSimm.Records(i);
									recordItem.Fields("no").Text = i + 1;
									recordItem.Fields("date").Text = current.ToString("dd MMM yy");
									recordItem.Fields("tmp_date").Text = current.ToString("yyyyMMdd");
									recordItem.Fields("budget").Text = num2.ToString();
									i++;
								}
								list.Clear();
								this.gridDcaSimm.Redraw();
							}
							else if (this.cbDcaTiming.Text.ToLower() == "every month")
							{
								DateTime dateTime = value;
								int dayOfMonth;
								int.TryParse(this.cbDcaTiming2.Text, out dayOfMonth);
								int num3 = dateTime.Month;
								int num4 = dateTime.Year;
								dateTime = this.getNextMonth(dateTime, num3, num4, dayOfMonth);
								List<DateTime> list = new List<DateTime>();
								while (dateTime <= value2)
								{
									list.Add(dateTime);
									num3++;
									if (num3 > 12)
									{
										num3 = 1;
										num4++;
									}
									dateTime = dateTime.AddDays(1.0);
									dateTime = this.getNextMonth(dateTime, num3, num4, dayOfMonth);
									if (dateTime > value2)
									{
										break;
									}
								}
								if (list.Count <= 0)
								{
									this.ShowMessageBox("Can not create command Please check the terms", frmOrderFormConfirm.OpenStyle.Error, null);
									return;
								}
								decimal num2 = (list.Count > 0) ? (num / (long)list.Count) : 0L;
								this.gridDcaSimm.Rows = list.Count;
								int i = 0;
								foreach (DateTime current in list)
								{
									RecordItem recordItem = this.gridDcaSimm.Records(i);
									recordItem.Fields("no").Text = i + 1;
									recordItem.Fields("date").Text = current.ToString("dd MMM yy");
									recordItem.Fields("tmp_date").Text = current.ToString("yyyyMMdd");
									recordItem.Fields("budget").Text = num2.ToString();
									i++;
								}
								list.Clear();
								this.gridDcaSimm.Redraw();
							}
							decimal priceLimit;
							if (!decimal.TryParse(this.tbPriceLimit.Text.Replace(",", ""), out priceLimit))
							{
								this.ShowMessageBox("Invalid price limit!!!", frmOrderFormConfirm.OpenStyle.Error, this.tbPriceLimit);
							}
							else
							{
								string text2 = this.cbDcaStock.Text;
								if (text2 == string.Empty)
								{
									this.ShowMessageBox("Invalid order symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbDcaStock);
								}
								else
								{
									stockInformation = ApplicationInfo.StockInfo[text2];
									if (stockInformation.Number <= 0)
									{
										this.ShowMessageBox("Invalid order symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbDcaStock);
									}
									else if (num <= 0L)
									{
										this.ShowMessageBox("Invalid budget!", frmOrderFormConfirm.OpenStyle.Error, this.tbDcaBudget);
									}
									else if (value == DateTime.MinValue || value2 == DateTime.MinValue)
									{
										this.ShowMessageBox("Invalid date!", frmOrderFormConfirm.OpenStyle.Error, this.dateTimePicker1);
									}
									else if (this.gridDcaSimm.Rows <= 0)
									{
										this.ShowMessageBox("Transaction not found!", frmOrderFormConfirm.OpenStyle.Error, this.dateTimePicker2);
									}
									else
									{
										this._commandDca = new AutoTradeDCACommand();
										this._commandDca.UserId = ApplicationInfo.UserLoginID;
										this._commandDca.Account = ApplicationInfo.AccInfo.CurrentAccount;
										this._commandDca.CustType = ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag;
										this._commandDca.Symbol = text2;
										this._commandDca.CommandType = "ADD";
										this._commandDca.Budget = num;
										this._commandDca.PriceLimit = priceLimit;
										CultureInfo cultureInfo = new CultureInfo("en-US");
										this._commandDca.StartDate = value.ToString("yyyyMMdd");
										this._commandDca.EndDate = value2.ToString("yyyyMMdd");
										if (this.cbDcaTiming.Text.ToLower().IndexOf("day") > 0)
										{
											this._commandDca.Period = "D";
										}
										else if (this.cbDcaTiming.Text.ToLower().IndexOf("week") > 0)
										{
											this._commandDca.Period = "W";
										}
										else if (this.cbDcaTiming.Text.ToLower().IndexOf("month") > 0)
										{
											this._commandDca.Period = "M";
										}
										this._commandDca.Items = new List<AutoTradeDCAItem>();
										for (int i = 0; i < this.gridDcaSimm.Rows; i++)
										{
											RecordItem recordItem = this.gridDcaSimm.Records(i);
											long.TryParse(recordItem.Fields("budget").Text.ToString().Replace(",", ""), out num);
											if (num <= 0L)
											{
												this.ShowMessageBox("The budget is not enough!", frmOrderFormConfirm.OpenStyle.Error, this.tbDcaBudget);
												break;
											}
											AutoTradeDCAItem item = new AutoTradeDCAItem(i + 1, recordItem.Fields("tmp_date").Text.ToString(), num, this._commandDca.Account, this._commandDca.CustType);
											this._commandDca.Items.Add(item);
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btn3Simlulate_Click", ex);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000CA4E4 File Offset: 0x000C88E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTime getNextDate(DateTime startDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DateTime result;
			try
			{
				DateTime dateTime = startDate;
				bool flag = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
				bool flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				while (flag || flag2)
				{
					dateTime = dateTime.AddDays(1.0);
					flag = (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday);
					flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				}
				result = dateTime;
			}
			catch (Exception ex)
			{
				this.ShowError("getNextDate", ex);
				throw ex;
			}
			return result;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000CA5CC File Offset: 0x000C89CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTime getNextWeek(DateTime startDate, DayOfWeek dayOfWeek)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DateTime result;
			try
			{
				DateTime dateTime = startDate;
				while (dateTime.DayOfWeek != dayOfWeek)
				{
					dateTime = dateTime.AddDays(1.0);
				}
				bool flag = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
				bool flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				while (flag || flag2)
				{
					dateTime = dateTime.AddDays(1.0);
					flag = (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday);
					flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				}
				result = dateTime;
			}
			catch (Exception ex)
			{
				this.ShowError("getNextWeek", ex);
				throw ex;
			}
			return result;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000CA6E0 File Offset: 0x000C8AE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTime getNextMonth(DateTime startDate, int month, int year, int dayOfMonth)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DateTime result;
			try
			{
				DateTime dateTime = startDate;
				while (dateTime.Day != dayOfMonth)
				{
					if (dateTime.Year * 100 + dateTime.Month > year * 100 + month)
					{
						break;
					}
					dateTime = dateTime.AddDays(1.0);
				}
				bool flag = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
				bool flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				while (flag || flag2)
				{
					dateTime = dateTime.AddDays(1.0);
					flag = (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday);
					flag2 = this._holidays.Contains(dateTime.ToString("yyyyMMdd"));
				}
				result = dateTime;
			}
			catch (Exception ex)
			{
				this.ShowError("getNextWeek", ex);
				throw ex;
			}
			return result;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000CA830 File Offset: 0x000C8C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageBox(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmDcaCreateNew.ShowMessageBoxCallBack(this.ShowMessageBox), new object[]
				{
					message,
					openStyle,
					lastFocusOjb
				});
			}
			else
			{
				try
				{
					this._lastFocusOjb = lastFocusOjb;
					if (this._frmConfirm != null)
					{
						if (!this._frmConfirm.IsDisposed)
						{
							this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = this;
					this._frmConfirm.Location = new Point((this._frmConfirm.Parent.Width - this._frmConfirm.Width) / 2, (this._frmConfirm.Parent.Height - this._frmConfirm.Height) / 2);
					this._frmConfirm.TopMost = true;
					this._frmConfirm.Show();
					this._frmConfirm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowMessageInFormConfirm", ex);
				}
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000CA9EC File Offset: 0x000C8DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowOrderFormConfirm(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmDcaCreateNew.ShowOrderFormConfirmCallBack(this.ShowOrderFormConfirm), new object[]
				{
					message,
					orderParam,
					openStyle
				});
			}
			else
			{
				try
				{
					if (this._frmConfirm != null)
					{
						if (!this._frmConfirm.IsDisposed)
						{
							this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle, this.tbPin.Text.Trim());
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.OssMessage = string.Empty;
					this._frmConfirm.StockThreshold = string.Empty;
					this._frmConfirm.OrderParam = orderParam;
					this._frmConfirm.Parent = this;
					this._frmConfirm.Location = new Point((this._frmConfirm.Parent.Width - this._frmConfirm.Width) / 2, (this._frmConfirm.Parent.Height - this._frmConfirm.Height) / 2);
					this._frmConfirm.TopMost = true;
					this._frmConfirm.Show();
					this._frmConfirm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowMessageInFormConfirm", ex);
				}
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000CABE0 File Offset: 0x000C8FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.Focus();
				if (ApplicationInfo.IsEquityAccount)
				{
					frmOrderFormConfirm.OpenStyle openFormStyle = ((frmOrderFormConfirm)sender).OpenFormStyle;
					if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
					{
						DialogResult result = ((frmOrderFormConfirm)sender).Result;
						if (result == DialogResult.OK)
						{
							if (!this.bgwSendOrder.IsBusy)
							{
								this.bgwSendOrder.RunWorkerAsync();
							}
							else
							{
								this.ShowMessageBox("The system is not ready yet.", frmOrderFormConfirm.OpenStyle.Error, null);
							}
						}
						else
						{
							this.btnSendOrder.Enabled = true;
						}
					}
					else if (this._lastFocusOjb != null)
					{
						this._lastFocusOjb.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000CACE4 File Offset: 0x000C90E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			try
			{
				string text = this.tbPin.Text.Trim();
				AutoTradeMain autoTradeMain = new AutoTradeMain();
				autoTradeMain.Pack("DCA", this._commandDca);
				result = ApplicationInfo.WebAlertService.SendAutoTrade(autoTradeMain.ToMessage());
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_DoWork", ex);
				result = ex.Message;
			}
			e.Result = result;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000CAD80 File Offset: 0x000C9180
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					string data = e.Result.ToString();
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(data, dataSet);
						if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
						{
							if (dataSet.Tables["Results"].Rows[0]["message"].ToString() == "ok")
							{
								base.DialogResult = DialogResult.OK;
								base.Close();
							}
							else
							{
								this.ShowMessageBox(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
							}
						}
						dataSet.Clear();
					}
				}
				else
				{
					this.ShowMessageBox(e.Result.ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000CAF28 File Offset: 0x000C9328
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000CAF5C File Offset: 0x000C935C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbDcaStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Return)
				{
					switch (keyCode)
					{
					case Keys.End:
					case Keys.Home:
					case Keys.Left:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_E0;
					case Keys.Up:
						goto IL_E0;
					case Keys.Right:
						break;
					default:
						goto IL_E0;
					}
				}
				if (this.cbDcaStock.Text.Trim() != string.Empty)
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbDcaStock.Text.Trim()];
					if (stockInformation.Number > 0)
					{
						this.dateTimePicker1.Focus();
					}
					else
					{
						this.cbDcaStock.Focus();
						this.cbDcaStock.SelectAll();
					}
				}
				e.SuppressKeyPress = true;
				IL_E0:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbStock_KeyDown", ex);
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000CB078 File Offset: 0x000C9478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbDcaBudget_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbDcaBudget.Text.Trim() != string.Empty)
				{
					if (!Regex.IsMatch(this.tbDcaBudget.Text.Replace(",", ""), "^[-+]?\\d+\\.?\\d*$"))
					{
						this.tbDcaBudget.Text = this.tbDcaBudget.Text.Substring(0, this.tbDcaBudget.Text.Length - 1);
						this.tbDcaBudget.Select(this.tbDcaBudget.Text.Length, 0);
					}
					else
					{
						decimal num = Convert.ToInt64(this.tbDcaBudget.Text.Replace(",", ""));
						this.tbDcaBudget.Text = num.ToString("#,###");
						this.tbDcaBudget.Select(this.tbDcaBudget.Text.Length, 0);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tb3Budget_TextChanged", ex);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000CB1D0 File Offset: 0x000C95D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbDcaTiming_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbDcaTiming.Text.ToLower() == "every day")
				{
					this.cbDcaTiming2.Enabled = false;
					this.cbDcaTiming2.SelectedIndex = -1;
				}
				else if (this.cbDcaTiming.Text.ToLower() == "every week")
				{
					this.cbDcaTiming2.Enabled = true;
					this.cbDcaTiming2.Items.Clear();
					this.cbDcaTiming2.Items.Add("Monday");
					this.cbDcaTiming2.Items.Add("Tuesday");
					this.cbDcaTiming2.Items.Add("Wednesday");
					this.cbDcaTiming2.Items.Add("Thursday");
					this.cbDcaTiming2.Items.Add("Friday");
				}
				else if (this.cbDcaTiming.Text.ToLower() == "every month")
				{
					this.cbDcaTiming2.Enabled = true;
					this.cbDcaTiming2.Items.Clear();
					for (int i = 1; i <= 31; i++)
					{
						this.cbDcaTiming2.Items.Add(i.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cb3Timing_SelectedIndexChanged", ex);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000CB39C File Offset: 0x000C979C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000CB3B4 File Offset: 0x000C97B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSendOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._commandDca == null)
				{
					this.ShowMessageBox("Simulate data before sending!!!", frmOrderFormConfirm.OpenStyle.Error, this.cbDcaStock);
				}
				else
				{
					string orderParam = string.Concat(new string[]
					{
						"Dollar Cost Average :",
						" Account : ",
						ApplicationInfo.AccInfo.CurrentAccount,
						"\nStock : ‘",
						this._commandDca.Symbol,
						"’",
						"\nBudget : ",
						FormatUtil.VolumeFormat(this._commandDca.Budget, true)
					});
					this.ShowOrderFormConfirm("Confirm to send?", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSendOrder_Click", ex);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x000CB4A4 File Offset: 0x000C98A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbDcaStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
			}
			catch (Exception ex)
			{
				this.ShowError("cbDcaStock_KeyPress", ex);
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000CB50C File Offset: 0x000C990C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbDcaBudget_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return)
			{
				this.cbDcaTiming.Focus();
				this.cbDcaTiming.SelectAll();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000CB564 File Offset: 0x000C9964
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000CB5B4 File Offset: 0x000C99B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
			this.label9 = new Label();
			this.cbDcaTiming2 = new ComboBox();
			this.lb3Stock = new Label();
			this.cbDcaStock = new ComboBox();
			this.cbDcaTiming = new ComboBox();
			this.lb3ToDate = new Label();
			this.lb3StartDate = new Label();
			this.lb3Timing = new Label();
			this.dateTimePicker2 = new DateTimePicker();
			this.tbDcaBudget = new TextBox();
			this.dateTimePicker1 = new DateTimePicker();
			this.lb3Budget = new Label();
			this.gridDcaSimm = new ExpandGrid();
			this.btnDcaSimlulate = new Button();
			this.btnSendOrder = new Button();
			this.tbPin = new TextBox();
			this.lbPin = new Label();
			this.btnPzClose = new Button();
			this.label1 = new Label();
			this.lbPriceLimit = new Label();
			this.tbPriceLimit = new TextBox();
			base.SuspendLayout();
			this.label9.AutoSize = true;
			this.label9.BackColor = Color.FromArgb(64, 64, 64);
			this.label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 222);
			this.label9.ForeColor = Color.LightGray;
			this.label9.Location = new Point(18, 9);
			this.label9.Name = "label9";
			this.label9.Padding = new Padding(3);
			this.label9.Size = new Size(167, 19);
			this.label9.TabIndex = 133;
			this.label9.Tag = "-1";
			this.label9.Text = "Create Dollar Cost Average";
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.cbDcaTiming2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbDcaTiming2.FormattingEnabled = true;
			this.cbDcaTiming2.Location = new Point(90, 176);
			this.cbDcaTiming2.Name = "cbDcaTiming2";
			this.cbDcaTiming2.Size = new Size(95, 21);
			this.cbDcaTiming2.TabIndex = 135;
			this.lb3Stock.AutoSize = true;
			this.lb3Stock.ForeColor = Color.LightGray;
			this.lb3Stock.Location = new Point(40, 49);
			this.lb3Stock.Margin = new Padding(2, 0, 2, 0);
			this.lb3Stock.Name = "lb3Stock";
			this.lb3Stock.Size = new Size(41, 13);
			this.lb3Stock.TabIndex = 131;
			this.lb3Stock.Text = "Symbol";
			this.lb3Stock.TextAlign = ContentAlignment.MiddleLeft;
			this.cbDcaStock.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbDcaStock.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbDcaStock.BackColor = Color.FromArgb(224, 224, 224);
			this.cbDcaStock.FlatStyle = FlatStyle.Popup;
			this.cbDcaStock.ForeColor = Color.Black;
			this.cbDcaStock.FormattingEnabled = true;
			this.cbDcaStock.Location = new Point(89, 46);
			this.cbDcaStock.MaxLength = 20;
			this.cbDcaStock.Name = "cbDcaStock";
			this.cbDcaStock.Size = new Size(95, 21);
			this.cbDcaStock.TabIndex = 130;
			this.cbDcaStock.KeyPress += new KeyPressEventHandler(this.cbDcaStock_KeyPress);
			this.cbDcaStock.KeyDown += new KeyEventHandler(this.cbDcaStock_KeyDown);
			this.cbDcaTiming.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbDcaTiming.FormattingEnabled = true;
			this.cbDcaTiming.Items.AddRange(new object[]
			{
				"Every Day",
				"Every Week",
				"Every Month"
			});
			this.cbDcaTiming.Location = new Point(90, 149);
			this.cbDcaTiming.Name = "cbDcaTiming";
			this.cbDcaTiming.Size = new Size(95, 21);
			this.cbDcaTiming.TabIndex = 134;
			this.cbDcaTiming.SelectedIndexChanged += new EventHandler(this.cbDcaTiming_SelectedIndexChanged);
			this.lb3ToDate.AutoSize = true;
			this.lb3ToDate.ForeColor = Color.Gainsboro;
			this.lb3ToDate.Location = new Point(29, 103);
			this.lb3ToDate.Margin = new Padding(2, 0, 2, 0);
			this.lb3ToDate.Name = "lb3ToDate";
			this.lb3ToDate.Size = new Size(52, 13);
			this.lb3ToDate.TabIndex = 120;
			this.lb3ToDate.Text = "End Date";
			this.lb3ToDate.TextAlign = ContentAlignment.MiddleLeft;
			this.lb3StartDate.AutoSize = true;
			this.lb3StartDate.ForeColor = Color.Gainsboro;
			this.lb3StartDate.Location = new Point(26, 77);
			this.lb3StartDate.Margin = new Padding(2, 0, 2, 0);
			this.lb3StartDate.Name = "lb3StartDate";
			this.lb3StartDate.Size = new Size(55, 13);
			this.lb3StartDate.TabIndex = 109;
			this.lb3StartDate.Text = "Start Date";
			this.lb3StartDate.TextAlign = ContentAlignment.MiddleLeft;
			this.lb3Timing.AutoSize = true;
			this.lb3Timing.ForeColor = Color.LightGray;
			this.lb3Timing.Location = new Point(43, 153);
			this.lb3Timing.Margin = new Padding(2, 0, 2, 0);
			this.lb3Timing.Name = "lb3Timing";
			this.lb3Timing.Size = new Size(38, 13);
			this.lb3Timing.TabIndex = 127;
			this.lb3Timing.Text = "Timing";
			this.lb3Timing.TextAlign = ContentAlignment.MiddleLeft;
			this.dateTimePicker2.Format = DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new Point(89, 99);
			this.dateTimePicker2.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker2.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new Size(95, 20);
			this.dateTimePicker2.TabIndex = 132;
			this.tbDcaBudget.BackColor = Color.FromArgb(224, 224, 224);
			this.tbDcaBudget.BorderStyle = BorderStyle.FixedSingle;
			this.tbDcaBudget.Location = new Point(90, 123);
			this.tbDcaBudget.Margin = new Padding(2, 3, 2, 3);
			this.tbDcaBudget.MaxLength = 10;
			this.tbDcaBudget.Name = "tbDcaBudget";
			this.tbDcaBudget.Size = new Size(95, 20);
			this.tbDcaBudget.TabIndex = 133;
			this.tbDcaBudget.TextChanged += new EventHandler(this.tbDcaBudget_TextChanged);
			this.tbDcaBudget.KeyDown += new KeyEventHandler(this.tbDcaBudget_KeyDown);
			this.dateTimePicker1.Format = DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new Point(90, 73);
			this.dateTimePicker1.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new Size(95, 20);
			this.dateTimePicker1.TabIndex = 131;
			this.lb3Budget.AutoSize = true;
			this.lb3Budget.ForeColor = Color.LightGray;
			this.lb3Budget.Location = new Point(40, 127);
			this.lb3Budget.Margin = new Padding(2, 0, 2, 0);
			this.lb3Budget.Name = "lb3Budget";
			this.lb3Budget.Size = new Size(41, 13);
			this.lb3Budget.TabIndex = 11;
			this.lb3Budget.Text = "Budget";
			this.lb3Budget.TextAlign = ContentAlignment.MiddleLeft;
			this.gridDcaSimm.AllowDrop = true;
			this.gridDcaSimm.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridDcaSimm.BackColor = Color.FromArgb(20, 20, 20);
			this.gridDcaSimm.CanBlink = true;
			this.gridDcaSimm.CanDrag = false;
			this.gridDcaSimm.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "No.";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 20;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "date";
			columnItem2.Text = "Date";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 40;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "budget";
			columnItem3.Text = "Budget";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 40;
			columnItem4.Alignment = StringAlignment.Near;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "tmp_date";
			columnItem4.Text = "None";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = false;
			columnItem4.Width = 10;
			this.gridDcaSimm.Columns.Add(columnItem);
			this.gridDcaSimm.Columns.Add(columnItem2);
			this.gridDcaSimm.Columns.Add(columnItem3);
			this.gridDcaSimm.Columns.Add(columnItem4);
			this.gridDcaSimm.CurrentScroll = 0;
			this.gridDcaSimm.FocusItemIndex = -1;
			this.gridDcaSimm.ForeColor = Color.Black;
			this.gridDcaSimm.GridColor = Color.FromArgb(50, 50, 50);
			this.gridDcaSimm.HeaderPctHeight = 100f;
			this.gridDcaSimm.IsAutoRepaint = true;
			this.gridDcaSimm.IsDrawGrid = true;
			this.gridDcaSimm.IsDrawHeader = true;
			this.gridDcaSimm.IsScrollable = true;
			this.gridDcaSimm.Location = new Point(211, 9);
			this.gridDcaSimm.MainColumn = "";
			this.gridDcaSimm.Name = "gridDcaSimm";
			this.gridDcaSimm.Rows = 0;
			this.gridDcaSimm.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridDcaSimm.RowSelectType = 0;
			this.gridDcaSimm.Size = new Size(493, 287);
			this.gridDcaSimm.SortColumnName = "";
			this.gridDcaSimm.SortType = SortType.Desc;
			this.gridDcaSimm.TabIndex = 135;
			this.btnDcaSimlulate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnDcaSimlulate.BackColor = Color.Transparent;
			this.btnDcaSimlulate.Cursor = Cursors.Hand;
			this.btnDcaSimlulate.FlatAppearance.BorderColor = Color.DimGray;
			this.btnDcaSimlulate.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnDcaSimlulate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnDcaSimlulate.FlatStyle = FlatStyle.Flat;
			this.btnDcaSimlulate.ForeColor = Color.LightGray;
			this.btnDcaSimlulate.Image = Resources.side_noside;
			this.btnDcaSimlulate.Location = new Point(46, 300);
			this.btnDcaSimlulate.Name = "btnDcaSimlulate";
			this.btnDcaSimlulate.Size = new Size(71, 22);
			this.btnDcaSimlulate.TabIndex = 134;
			this.btnDcaSimlulate.TabStop = false;
			this.btnDcaSimlulate.Text = "Simulate";
			this.btnDcaSimlulate.UseVisualStyleBackColor = false;
			this.btnDcaSimlulate.Click += new EventHandler(this.btnDcaSimlulate_Click);
			this.btnSendOrder.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnSendOrder.AutoEllipsis = true;
			this.btnSendOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSendOrder.BackColor = Color.Transparent;
			this.btnSendOrder.Cursor = Cursors.Hand;
			this.btnSendOrder.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSendOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSendOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSendOrder.FlatStyle = FlatStyle.Flat;
			this.btnSendOrder.ForeColor = Color.WhiteSmoke;
			this.btnSendOrder.Image = Resources.side_noside;
			this.btnSendOrder.Location = new Point(585, 305);
			this.btnSendOrder.MaximumSize = new Size(65, 22);
			this.btnSendOrder.Name = "btnSendOrder";
			this.btnSendOrder.Size = new Size(57, 22);
			this.btnSendOrder.TabIndex = 149;
			this.btnSendOrder.TabStop = false;
			this.btnSendOrder.Text = "Send";
			this.btnSendOrder.UseVisualStyleBackColor = false;
			this.btnSendOrder.Click += new EventHandler(this.btnSendOrder_Click);
			this.tbPin.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.tbPin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPin.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPin.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPin.BorderStyle = BorderStyle.FixedSingle;
			this.tbPin.CharacterCasing = CharacterCasing.Upper;
			this.tbPin.Location = new Point(523, 306);
			this.tbPin.Margin = new Padding(2, 3, 2, 3);
			this.tbPin.MaxLength = 10;
			this.tbPin.Name = "tbPin";
			this.tbPin.PasswordChar = '*';
			this.tbPin.Size = new Size(55, 20);
			this.tbPin.TabIndex = 147;
			this.lbPin.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.lbPin.AutoSize = true;
			this.lbPin.ForeColor = Color.LightGray;
			this.lbPin.Location = new Point(494, 310);
			this.lbPin.Margin = new Padding(2, 0, 2, 0);
			this.lbPin.Name = "lbPin";
			this.lbPin.Size = new Size(25, 13);
			this.lbPin.TabIndex = 148;
			this.lbPin.Text = "PIN";
			this.lbPin.TextAlign = ContentAlignment.MiddleLeft;
			this.btnPzClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnPzClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzClose.BackColor = Color.Transparent;
			this.btnPzClose.Cursor = Cursors.Hand;
			this.btnPzClose.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzClose.FlatStyle = FlatStyle.Flat;
			this.btnPzClose.ForeColor = Color.LightGray;
			this.btnPzClose.Image = Resources.side_noside;
			this.btnPzClose.Location = new Point(648, 305);
			this.btnPzClose.Name = "btnPzClose";
			this.btnPzClose.Size = new Size(57, 22);
			this.btnPzClose.TabIndex = 146;
			this.btnPzClose.TabStop = false;
			this.btnPzClose.Text = "Cancel";
			this.btnPzClose.UseVisualStyleBackColor = false;
			this.btnPzClose.Click += new EventHandler(this.btnPzClose_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.Yellow;
			this.label1.Location = new Point(40, 205);
			this.label1.Margin = new Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(38, 13);
			this.label1.TabIndex = 150;
			this.label1.Text = "Option";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.lbPriceLimit.AutoSize = true;
			this.lbPriceLimit.ForeColor = Color.LightGray;
			this.lbPriceLimit.Location = new Point(23, 233);
			this.lbPriceLimit.Margin = new Padding(2, 0, 2, 0);
			this.lbPriceLimit.Name = "lbPriceLimit";
			this.lbPriceLimit.Size = new Size(58, 13);
			this.lbPriceLimit.TabIndex = 151;
			this.lbPriceLimit.Text = "Price Limit ";
			this.lbPriceLimit.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPriceLimit.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPriceLimit.BorderStyle = BorderStyle.FixedSingle;
			this.tbPriceLimit.Location = new Point(89, 229);
			this.tbPriceLimit.Margin = new Padding(2, 3, 2, 3);
			this.tbPriceLimit.MaxLength = 10;
			this.tbPriceLimit.Name = "tbPriceLimit";
			this.tbPriceLimit.Size = new Size(95, 20);
			this.tbPriceLimit.TabIndex = 152;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(714, 334);
			base.Controls.Add(this.lbPriceLimit);
			base.Controls.Add(this.tbPriceLimit);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnSendOrder);
			base.Controls.Add(this.tbPin);
			base.Controls.Add(this.lbPin);
			base.Controls.Add(this.btnPzClose);
			base.Controls.Add(this.gridDcaSimm);
			base.Controls.Add(this.btnDcaSimlulate);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.lb3Budget);
			base.Controls.Add(this.cbDcaTiming2);
			base.Controls.Add(this.dateTimePicker1);
			base.Controls.Add(this.lb3Stock);
			base.Controls.Add(this.tbDcaBudget);
			base.Controls.Add(this.cbDcaStock);
			base.Controls.Add(this.dateTimePicker2);
			base.Controls.Add(this.cbDcaTiming);
			base.Controls.Add(this.lb3Timing);
			base.Controls.Add(this.lb3ToDate);
			base.Controls.Add(this.lb3StartDate);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmDcaCreateNew";
			this.Text = "frmDcaCreateNew";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000736 RID: 1846
		private BackgroundWorker bgwSendOrder;

		// Token: 0x04000737 RID: 1847
		private List<string> _holidays;

		// Token: 0x04000738 RID: 1848
		private AutoTradeDCACommand _commandDca;

		// Token: 0x04000739 RID: 1849
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x0400073A RID: 1850
		private Control _lastFocusOjb;

		// Token: 0x0400073B RID: 1851
		private IContainer components;

		// Token: 0x0400073C RID: 1852
		private Button btnDcaSimlulate;

		// Token: 0x0400073D RID: 1853
		private Label label9;

		// Token: 0x0400073E RID: 1854
		private ComboBox cbDcaTiming2;

		// Token: 0x0400073F RID: 1855
		private Label lb3Stock;

		// Token: 0x04000740 RID: 1856
		private ComboBox cbDcaStock;

		// Token: 0x04000741 RID: 1857
		private ComboBox cbDcaTiming;

		// Token: 0x04000742 RID: 1858
		private Label lb3ToDate;

		// Token: 0x04000743 RID: 1859
		private Label lb3StartDate;

		// Token: 0x04000744 RID: 1860
		private Label lb3Timing;

		// Token: 0x04000745 RID: 1861
		private DateTimePicker dateTimePicker2;

		// Token: 0x04000746 RID: 1862
		private TextBox tbDcaBudget;

		// Token: 0x04000747 RID: 1863
		private DateTimePicker dateTimePicker1;

		// Token: 0x04000748 RID: 1864
		private Label lb3Budget;

		// Token: 0x04000749 RID: 1865
		private ExpandGrid gridDcaSimm;

		// Token: 0x0400074A RID: 1866
		private Button btnSendOrder;

		// Token: 0x0400074B RID: 1867
		private TextBox tbPin;

		// Token: 0x0400074C RID: 1868
		private Label lbPin;

		// Token: 0x0400074D RID: 1869
		private Button btnPzClose;

		// Token: 0x0400074E RID: 1870
		private Label label1;

		// Token: 0x0400074F RID: 1871
		private Label lbPriceLimit;

		// Token: 0x04000750 RID: 1872
		private TextBox tbPriceLimit;

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x06000B28 RID: 2856
		private delegate void ShowMessageBoxCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x06000B2C RID: 2860
		private delegate void ShowOrderFormConfirmCallBack(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
