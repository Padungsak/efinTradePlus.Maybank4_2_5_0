using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
	// Token: 0x020000A5 RID: 165
	public class frmFTSCreateNew : Form
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x00097B68 File Offset: 0x00095F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmFTSCreateNew()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.bgwSendOrder = null;
			this._stockInfo = null;
			this._showSide = "B";
			this._frmConfirm = null;
			this._buyCreditLimit = 0m;
			this._portStockEquity = 0m;
			this._onhand = 0L;
			this._objLastActive = null;
			this.bgwGetEquity = null;
			this.bgwReloadCredit = null;
			this._tdsCredit = null;
			this._commRate = 0.20m;
			this._VAT = 7m;
			this._giveUpPct = 0m;
			this._loss = 0m;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
			if (!base.DesignMode)
			{
				this._showSide = "B";
				this.bgwGetEquity = new BackgroundWorker();
				this.bgwGetEquity.WorkerReportsProgress = true;
				this.bgwGetEquity.DoWork += new DoWorkEventHandler(this.bgwGetEquity_DoWork);
				this.bgwGetEquity.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwGetEquity_RunWorkerCompleted);
				this.bgwReloadCredit = new BackgroundWorker();
				this.bgwReloadCredit.WorkerReportsProgress = true;
				this.bgwReloadCredit.DoWork += new DoWorkEventHandler(this.bgwReloadCredit_DoWork);
				this.bgwReloadCredit.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadCredit_RunWorkerCompleted);
				this.bgwSendOrder = new BackgroundWorker();
				this.bgwSendOrder.WorkerReportsProgress = true;
				this.bgwSendOrder.DoWork += new DoWorkEventHandler(this.bgwSendOrder_DoWork);
				this.bgwSendOrder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSendOrder_RunWorkerCompleted);
				if (this.cbMMStock.AutoCompleteCustomSource != null)
				{
					if (this.cbMMStock.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.StockAutoComp != null)
					{
						this.cbMMStock.AutoCompleteMode = AutoCompleteMode.Suggest;
						this.cbMMStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
						if (ApplicationInfo.IsSupportTfex)
						{
							this.cbMMStock.AutoCompleteCustomSource = ApplicationInfo.MultiAutoComp;
						}
						else
						{
							this.cbMMStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
						}
					}
				}
				this.cbCondition.Items.Clear();
				this.cbCondition.Items.Add("Last >");
				this.cbCondition.Items.Add("Last < SMA(Day)");
				this.cbCondition.Items.Add("Last < Break Low (Day)");
				this.tbCommRate.Text = ApplicationInfo.UserCommRate.ToString();
				this.tbVAT.Text = ApplicationInfo.UserVAT.ToString();
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00097E38 File Offset: 0x00096238
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelAutoTradeMM_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender == this.cbMMStock)
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
							goto IL_2A4;
						case Keys.Up:
							goto IL_2A4;
						case Keys.Right:
							break;
						default:
							goto IL_2A4;
						}
					}
					if (this.cbMMStock.Text.Trim() != string.Empty)
					{
						if (ApplicationInfo.IsEquityAccount)
						{
							StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbMMStock.Text.Trim()];
							if (stockInformation.Number > 0)
							{
								this._stockInfo = stockInformation;
								ApplicationInfo.CurrentSymbol = this._stockInfo.Symbol;
								if (!this.cbMMStock.Items.Contains(this._stockInfo.Symbol))
								{
									this.cbMMStock.Items.Add(this._stockInfo.Symbol);
								}
								if (this.cbMMPrice.Text == string.Empty)
								{
									if (Settings.Default.BSBoxDefaultPrice == 1)
									{
										this.cbMMPrice.Text = ((this._stockInfo.LastSalePrice > 0m) ? Utilities.PriceFormat(this._stockInfo.LastSalePrice) : Utilities.PriceFormat(this._stockInfo.PriorPrice));
									}
									else if (Settings.Default.BSBoxDefaultPrice == 2)
									{
										if (this._showSide == "B")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._stockInfo.OfferPrice1);
										}
										else if (this._showSide == "S")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._stockInfo.BidPrice1);
										}
									}
								}
								this.cbMMPrice.Focus();
							}
							else
							{
								this.cbMMStock.Text = ((this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
								this.cbMMStock.Focus();
								this.cbMMStock.SelectAll();
							}
						}
					}
					e.SuppressKeyPress = true;
					IL_2A4:;
				}
				else if (sender == this.cbMMPrice)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.cbMMStock.Focus();
							e.SuppressKeyPress = true;
							goto IL_417;
						case Keys.Up:
							this.cbMMPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbMMPrice, true));
							this.cbMMPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_417;
						case Keys.Right:
							break;
						case Keys.Down:
							this.cbMMPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbMMPrice, false));
							this.cbMMPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_417;
						default:
							goto IL_417;
						}
					}
					if (ApplicationInfo.IsEquityAccount)
					{
						if (this.IsValidPrice(this.cbMMPrice.Text, true, this.cbMMPrice))
						{
							if (this._showSide == "B" || this._showSide == "H")
							{
								this.tbMMStopPrice.Focus();
							}
							else
							{
								this.tbMMGiveUp.Focus();
							}
							this.calculateMMVolume();
						}
					}
					e.SuppressKeyPress = true;
					IL_417:;
				}
				else if (sender == this.tbMMStopPrice)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.cbMMPrice.Focus();
							e.SuppressKeyPress = true;
							goto IL_533;
						case Keys.Up:
							this.tbMMStopPrice.Text = Utilities.PriceFormat(this.GetPrice(this.tbMMStopPrice, true));
							this.tbMMStopPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_533;
						case Keys.Right:
							break;
						case Keys.Down:
							this.tbMMStopPrice.Text = Utilities.PriceFormat(this.GetPrice(this.tbMMStopPrice, false));
							this.tbMMStopPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_533;
						default:
							goto IL_533;
						}
					}
					if (this.IsValidPrice(this.tbMMStopPrice.Text, true, this.tbMMStopPrice))
					{
						this.calculateMMVolume();
						this.tbMMGiveUp.Focus();
					}
					e.SuppressKeyPress = true;
					IL_533:;
				}
				else if (sender == this.tbMMGiveUp)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.tbMMStopPrice.Focus();
							e.SuppressKeyPress = true;
							break;
						case Keys.Up:
							e.SuppressKeyPress = true;
							break;
						case Keys.Right:
							e.SuppressKeyPress = true;
							break;
						case Keys.Down:
							e.SuppressKeyPress = true;
							break;
						}
					}
					else
					{
						if (FormatUtil.Isnumeric(this.tbMMGiveUp.Text))
						{
						}
						e.SuppressKeyPress = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("panelAutoTradeMM_KeyDown", ex);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00098464 File Offset: 0x00096864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetPrice(object objPrice, bool isIncrease)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal num = 0m;
			try
			{
				string stockSymbol = string.Empty;
				string s = string.Empty;
				if (objPrice == this.cbMMPrice)
				{
					stockSymbol = this.cbMMStock.Text.Trim().ToUpper();
					s = this.cbMMPrice.Text;
				}
				else if (objPrice == this.tbMMStopPrice)
				{
					stockSymbol = this.cbMMStock.Text.Trim().ToUpper();
					s = this.tbMMStopPrice.Text;
				}
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol];
				if (stockInformation != null && stockInformation.Number > 0)
				{
					if (decimal.TryParse(s, out num))
					{
						if (isIncrease)
						{
							num += Utilities.GetNextSpreadUp(stockInformation, num);
							if (num > stockInformation.Ceiling)
							{
								num = stockInformation.Ceiling;
							}
						}
						else
						{
							num -= Utilities.GetNextSpreadDown(stockInformation, num);
							if (num < stockInformation.Floor)
							{
								num = stockInformation.Floor;
							}
						}
					}
					else if (num == 0m && stockInformation != null)
					{
						num = stockInformation.PriorPrice;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0009862C File Offset: 0x00096A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice(string price, bool IsShowMessage, Control control)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				if (price != null)
				{
					if (price == "ATO" || price == "ATC" || price == "MP" || price == "MO" || price == "ML")
					{
						result = true;
						return result;
					}
				}
				if (!FormatUtil.Isnumeric(price))
				{
					if (IsShowMessage)
					{
						this.ShowMessageInFormConfirm("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
					}
					result = false;
					return result;
				}
				int num = price.IndexOf('.');
				string text = string.Empty;
				if (num > -1)
				{
					text = price.Substring(num + 1);
					if (text.Length < 2)
					{
						if (ApplicationInfo.BrokerId != 11)
						{
							if (IsShowMessage)
							{
								this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
							}
							result = false;
							return result;
						}
					}
					else if (text.Length > 2)
					{
						if (IsShowMessage)
						{
							this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
						}
						result = false;
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000987EC File Offset: 0x00096BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastObject)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._objLastActive = lastObject;
			this.ShowMessageInFormConfirm(message, openStyle);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00098810 File Offset: 0x00096C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmFTSCreateNew.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
				{
					message,
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
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = base.Parent.Parent;
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

		// Token: 0x060007F4 RID: 2036 RVA: 0x000989CC File Offset: 0x00096DCC
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
				frmOrderFormConfirm.OpenStyle openFormStyle = ((frmOrderFormConfirm)sender).OpenFormStyle;
				DialogResult result = ((frmOrderFormConfirm)sender).Result;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmBox)
					{
						if (result == DialogResult.OK)
						{
							if (!this.bgwSendOrder.IsBusy)
							{
								this.bgwSendOrder.RunWorkerAsync();
							}
							else
							{
								this.ShowMessageInFormConfirm("The system is not ready yet.", frmOrderFormConfirm.OpenStyle.Error);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00098AA0 File Offset: 0x00096EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00098AD4 File Offset: 0x00096ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbMMStock_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("cbStock_KeyPress", ex);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00098B3C File Offset: 0x00096F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				((Control)sender).BackColor = Color.Yellow;
				((Control)sender).ForeColor = Color.Black;
				if (sender.GetType() == typeof(TextBox))
				{
					((TextBox)sender).SelectAll();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Enter", ex);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00098BD4 File Offset: 0x00096FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(CheckBox))
				{
					((Control)sender).BackColor = Color.Transparent;
					((Control)sender).ForeColor = Color.White;
				}
				else if (sender.GetType() == typeof(ComboBox))
				{
					((Control)sender).BackColor = Color.FromArgb(224, 224, 224);
					((Control)sender).ForeColor = Color.Black;
				}
				else
				{
					((Control)sender).BackColor = Color.FromArgb(224, 224, 224);
					((Control)sender).ForeColor = Color.Black;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Leave", ex);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00098CEC File Offset: 0x000970EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbMMPrice_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbMMPrice.Text.Trim() != string.Empty)
				{
					if (this._showSide == "B")
					{
						if (!Regex.IsMatch(this.cbMMPrice.Text, "^[-+]?\\d+\\.?\\d*$"))
						{
							this.cbMMPrice.Text = this.cbMMPrice.Text.Substring(0, this.cbMMPrice.Text.Length - 1);
							this.cbMMPrice.Select(this.cbMMPrice.Text.Length, 0);
						}
						else
						{
							this.calculateMMVolume();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbMMPrice_TextChanged", ex);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00098DF8 File Offset: 0x000971F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbMMStopPrice_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbMMStopPrice.Text.Trim() != string.Empty)
				{
					if (!Regex.IsMatch(this.tbMMStopPrice.Text, "^[-+]?\\d+\\.?\\d*$"))
					{
						this.tbMMStopPrice.Text = this.tbMMStopPrice.Text.Substring(0, this.tbMMStopPrice.Text.Length - 1);
						this.tbMMStopPrice.Select(this.tbMMStopPrice.Text.Length, 0);
					}
					else
					{
						this.calculateMMVolume();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbMMStopPrice_TextChanged", ex);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00098EE0 File Offset: 0x000972E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbMMGiveUp_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbMMGiveUp.Text.Trim() != string.Empty)
				{
					if (!Regex.IsMatch(this.tbMMGiveUp.Text, "^[-+]?\\d+\\.?\\d*$"))
					{
						this.tbMMGiveUp.Text = this.tbMMGiveUp.Text.Substring(0, this.tbMMGiveUp.Text.Length - 1);
						this.tbMMGiveUp.Select(this.tbMMGiveUp.Text.Length, 0);
					}
					else
					{
						this.calculateMMVolume();
					}
				}
				else
				{
					this.calculateMMVolume();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbMMGiveUp_TextChanged", ex);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00098FD4 File Offset: 0x000973D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetEquity_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string result = string.Empty;
				if (ApplicationInfo.IsEquityAccount)
				{
					result = ApplicationInfo.WebOrderService.GetPortEquity(ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.AccInfo.CurrentAccountType);
				}
				else
				{
					result = string.Empty;
				}
				e.Result = result;
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetEquity_DoWork", ex);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00099064 File Offset: 0x00097464
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetEquity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
						{
							int num = -1;
							int.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out num);
							if (num == 0)
							{
								decimal.TryParse(dataSet.Tables["Results"].Rows[0]["message"].ToString(), out this._portStockEquity);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetEquity_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000991D8 File Offset: 0x000975D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadCredit_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
				{
					string text = string.Empty;
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.SupportFreewill)
						{
							text = ApplicationInfo.WebOrderService.ViewCustomerCreditOnSendBox_Freewill(ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.AccInfo.CurrentAccountType, (this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
						}
						else
						{
							text = ApplicationInfo.WebOrderService.ViewCustomerCreditOnSendBox(ApplicationInfo.AccInfo.CurrentAccount, (this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
						}
					}
					if (this._tdsCredit != null)
					{
						this._tdsCredit.Clear();
						this._tdsCredit = null;
					}
					this._tdsCredit = new DataSet();
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this._tdsCredit);
					}
				}
				else
				{
					this.ShowError("RequestWebData", new Exception("Current Account is null"));
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0009934C File Offset: 0x0009774C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadCredit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					this._buyCreditLimit = 0m;
					if (this._tdsCredit != null && this._tdsCredit.Tables.Contains("CUSTOMER_CREDIT") && this._tdsCredit.Tables["CUSTOMER_CREDIT"].Rows.Count > 0)
					{
						DataRow dataRow = this._tdsCredit.Tables["CUSTOMER_CREDIT"].Rows[0];
						if (dataRow.Table.Columns.Contains("buy_credit_limit"))
						{
							decimal.TryParse(dataRow["buy_credit_limit"].ToString(), out this._buyCreditLimit);
						}
					}
					else
					{
						this._buyCreditLimit = 0m;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0009947C File Offset: 0x0009787C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmFTSCreateNew_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.bgwGetEquity.IsBusy)
				{
					this.bgwGetEquity.RunWorkerAsync();
				}
				if (!this.bgwReloadCredit.IsBusy)
				{
					this.bgwReloadCredit.RunWorkerAsync();
				}
				this.cbMMStock.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("frmFTSCreateNew_Shown", ex);
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00099510 File Offset: 0x00097910
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00099528 File Offset: 0x00097928
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calculateMMVolume()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this._showSide == "B" || this._showSide == "H")
					{
						decimal num = 0m;
						decimal num2 = 0m;
						decimal num3 = 0m;
						decimal.TryParse(this.tbMMStopPrice.Text, out num);
						decimal.TryParse(this.tbMMGiveUp.Text, out num2);
						decimal.TryParse(this.cbMMPrice.Text, out num3);
						long num4 = 0L;
						decimal d = 0m;
						if (num2 > 0m)
						{
							d = this._portStockEquity * num2 / 100m;
							if (this._showSide == "B")
							{
								if (num3 > num)
								{
									num4 = (long)(d / (num3 - num));
								}
							}
							else if (num > num3)
							{
								num4 = (long)(d / (num - num3));
							}
							if (num4 > 0L)
							{
								decimal d2 = num4 * num3;
								decimal userCommVAT = ApplicationInfo.UserCommVAT;
								d2 += d2 * userCommVAT;
								if (d2 > this._buyCreditLimit)
								{
									d2 = this._buyCreditLimit - this._buyCreditLimit * userCommVAT;
									num4 = (long)(d2 / num3);
								}
								num4 -= num4 % (long)this._stockInfo.BoardLot;
								d = num4 * Math.Abs(num3 - num);
							}
							else
							{
								num4 = 0L;
								d = 0m;
							}
						}
						this.tbMMTotalLoss.Text = d.ToString("#,##0");
						this.tbMMVolume.Text = num4.ToString("#,##0");
					}
					else if (this._showSide == "S" || this._showSide == "C")
					{
						long num4 = 0L;
						decimal num5 = 0m;
						if (decimal.TryParse(this.tbMMGiveUp.Text, out num5))
						{
							if (num5 > 100m)
							{
								num5 = 100m;
								this.tbMMGiveUp.Text = "100";
								this.tbMMGiveUp.SelectAll();
							}
							num4 = (long)(this._onhand * num5 / 100m);
							num4 -= num4 % (long)this._stockInfo.BoardLot;
						}
						this.tbMMVolume.Text = num4.ToString("#,##0");
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("calculateMMVolume", ex);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000998AC File Offset: 0x00097CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSimulate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int rows;
				int.TryParse(this.tbTime.Text, out rows);
				this.gridSimm.Rows = rows;
				decimal.TryParse(this.cbMMPrice.Text, out this._buyPrice);
				long.TryParse(this.tbMMVolume.Text.Replace(",", ""), out this._volume);
				decimal.TryParse(this.tbMMStopPrice.Text, out this._stopPrice);
				decimal.TryParse(this.tbCommRate.Text, out this._commRate);
				decimal.TryParse(this.tbVAT.Text, out this._VAT);
				decimal.TryParse(this.tbMMGiveUp.Text, out this._giveUpPct);
				decimal.TryParse(this.tbMMTotalLoss.Text, out this._loss);
				this.SetValueToGraid(0, "Last >", 0, 0.5m, this._buyPrice, 10m, this._stopPrice);
				this.SetValueToGraid(1, "Last >", 0, 1m, this._buyPrice, 20m, this._stopPrice);
				this.SetValueToGraid(2, "Last >", 0, 1.5m, this._buyPrice, 20m, this._stopPrice + (this._buyPrice - this._stopPrice) / 2m);
				this.SetValueToGraid(3, "Last >", 0, 2m, 0m, 30m, this._buyPrice);
				this.SetValueToGraid(4, "Last < SMA(Day)", 10, 2.5m, 0m, 20m, this._buyPrice + (this._buyPrice - this._stopPrice) / 2m);
				this.gridSimm.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("btnSimulate_Click", ex);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00099AF4 File Offset: 0x00097EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetValueToGraid(int rowIndex, string fieldCond, int period, decimal takeXRatio, decimal repurchasePrice, decimal takeVolPct, decimal stopPrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.gridSimm.Records(rowIndex);
				if (fieldCond == "Last < SMA(Day)")
				{
					recordItem.Fields("field_type").Text = "SMA";
					recordItem.Fields("operator_type").Text = 2;
					recordItem.Fields("period").Text = period;
				}
				else if (fieldCond == "Last < Break Low (Day)")
				{
					recordItem.Fields("field_type").Text = "LLV";
					recordItem.Fields("operator_type").Text = 2;
					recordItem.Fields("period").Text = period;
				}
				else
				{
					recordItem.Fields("field_type").Text = "LAST";
					recordItem.Fields("operator_type").Text = 3;
					recordItem.Fields("period").Text = period;
				}
				decimal d = this._buyPrice - this._stopPrice;
				decimal num = this._buyPrice + d * takeXRatio;
				recordItem.Fields("take_price_ratio").Text = takeXRatio;
				recordItem.Fields("take_price").Text = FormatUtil.PriceFormat(num);
				recordItem.Fields("take_vol_pct").Text = takeVolPct;
				long num2 = (long)(this._volume * takeVolPct / 100m);
				num2 -= num2 % (long)this._stockInfo.BoardLot;
				recordItem.Fields("take_vol").Text = FormatUtil.ValueFormat(num2, true);
				recordItem.Fields("repurchase_price").Text = repurchasePrice;
				if (repurchasePrice > 0m)
				{
					recordItem.Fields("repurchase_cond").Text = "Last <" + " " + FormatUtil.PriceFormat(repurchasePrice) + "@";
				}
				else
				{
					recordItem.Fields("repurchase_cond").Text = "-";
				}
				recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(stopPrice);
				recordItem.Fields("take_condition").Text = string.Concat(new object[]
				{
					"PL ratio ",
					takeXRatio,
					", ",
					fieldCond,
					(period > 0) ? (" (" + period + ")") : (" " + num + "@"),
					", Vol  ",
					FormatUtil.ValueFormat(num2, true),
					" (",
					takeVolPct,
					"%)"
				});
			}
			catch (Exception ex)
			{
				this.ShowError("SetValueToGraid", ex);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00099E74 File Offset: 0x00098274
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSend_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._command = new AutoTradeFTSCommand();
				this._command.Account = ApplicationInfo.AccInfo.CurrentAccount;
				this._command.CustType = ApplicationInfo.AccInfo.CurrentAccountType;
				this._command.UserId = ApplicationInfo.AccInfo.CurrInternetUser;
				this._command.Symbol = this._stockInfo.Symbol;
				this._command.BuyPrice = this._buyPrice;
				this._command.CommRate = this._commRate;
				this._command.VAT = this._VAT;
				this._command.GiveUpPct = this._giveUpPct;
				this._command.Loss = this._loss;
				this._command.StopPrice = this._stopPrice;
				this._command.RequestVol = this._volume;
				this._command.CommandType = "ADD";
				this._command.Items = new List<AutoTradeFTSItem>();
				AutoTradeFTSItem autoTradeFTSItem = new AutoTradeFTSItem();
				autoTradeFTSItem.FieldType = "LAST";
				autoTradeFTSItem.OperatorType = 4;
				autoTradeFTSItem.ItemNo = 0;
				autoTradeFTSItem.RepurchasePrice = this._buyPrice;
				autoTradeFTSItem.TakeProfitPrice = 0m;
				autoTradeFTSItem.TakeProfitVolume = this._volume;
				autoTradeFTSItem.OnHand = this._volume;
				autoTradeFTSItem.IsActive = true;
				this._command.Items.Add(autoTradeFTSItem);
				for (int i = 0; i < this.gridSimm.Rows; i++)
				{
					RecordItem recordItem = this.gridSimm.Records(i);
					autoTradeFTSItem = new AutoTradeFTSItem();
					autoTradeFTSItem.ItemNo = i + 1;
					autoTradeFTSItem.FieldType = recordItem.Fields("field_type").Text.ToString();
					autoTradeFTSItem.OperatorType = Convert.ToInt32(recordItem.Fields("operator_type").Text.ToString());
					autoTradeFTSItem.FieldPeriod = Convert.ToInt32(recordItem.Fields("period").Text.ToString());
					autoTradeFTSItem.RepurchasePrice = Convert.ToDecimal(recordItem.Fields("repurchase_price").Text.ToString());
					autoTradeFTSItem.OnHand = 0L;
					autoTradeFTSItem.TakeProfitPriceRatio = Convert.ToDecimal(recordItem.Fields("take_price_ratio").Text.ToString());
					autoTradeFTSItem.TakeProfitPrice = Convert.ToDecimal(recordItem.Fields("take_price").Text.ToString());
					autoTradeFTSItem.TakeProfitVolumePct = Convert.ToDecimal(recordItem.Fields("take_vol_pct").Text.ToString());
					autoTradeFTSItem.TakeProfitVolume = Convert.ToInt64(recordItem.Fields("take_vol").Text.ToString().Replace(",", ""));
					autoTradeFTSItem.IsTraillingActive = false;
					autoTradeFTSItem.StopPrice = Convert.ToDecimal(recordItem.Fields("stop_price").Text.ToString());
					autoTradeFTSItem.IsActive = false;
					this._command.Items.Add(autoTradeFTSItem);
				}
				if (this._command == null)
				{
					this.ShowMessageInFormConfirm("Simulate data before sending!!!", frmOrderFormConfirm.OpenStyle.Error, this.cbMMStock);
				}
				else
				{
					string str = string.Concat(new string[]
					{
						"Follow Trend Statigist :",
						" Account : ",
						ApplicationInfo.AccInfo.CurrentAccount,
						"\nStock : ‘",
						this._command.Symbol,
						"’"
					});
					this.ShowMessageInFormConfirm("Confirm to send?\r\n" + str, frmOrderFormConfirm.OpenStyle.ConfirmBox, this.cbMMStock);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSend_Click", ex);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0009A258 File Offset: 0x00098658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gridSimm_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
					RecordItem recordItem = this.gridSimm.Records(e.RowIndex);
					if (recordItem.Fields("field_type").Text.ToString() == "SMA")
					{
						this.cbCondition.Text = "Last < SMA(Day)";
					}
					else if (recordItem.Fields("field_type").Text.ToString() == "LLV")
					{
						this.cbCondition.Text = "Last < Break Low (Day)";
					}
					else if (recordItem.Fields("field_type").Text.ToString() == "LAST")
					{
						if (recordItem.Fields("operator_type").Text.ToString() == 3.ToString())
						{
							this.cbCondition.Text = "Last >";
						}
						else if (recordItem.Fields("operator_type").Text.ToString() == 4.ToString())
						{
							this.cbCondition.Text = "Last <";
						}
					}
					this.tbStopPrice.Text = recordItem.Fields("stop_price").Text.ToString();
					this.tbRepurchasePrice.Text = recordItem.Fields("repurchase_price").Text.ToString();
					this.tbTakePriceRatio.Text = recordItem.Fields("take_price_ratio").Text.ToString();
					this.tbTakePrice.Text = recordItem.Fields("take_price").Text.ToString();
					this.tbTakeVolPct.Text = recordItem.Fields("take_vol_pct").Text.ToString();
					this.tbTakeVol.Text = recordItem.Fields("take_vol").Text.ToString();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("gridSimm_TableMouseClick", ex);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0009A4C4 File Offset: 0x000988C4
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
				AutoTradeMain autoTradeMain = new AutoTradeMain();
				autoTradeMain.Pack("FTS", this._command);
				result = ApplicationInfo.WebAlertService.SendAutoTrade(autoTradeMain.ToMessage());
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_DoWork", ex);
				result = ex.Message;
			}
			e.Result = result;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0009A550 File Offset: 0x00098950
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
								this.ShowMessageInFormConfirm(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
							}
						}
						dataSet.Clear();
					}
				}
				else
				{
					this.ShowMessageInFormConfirm(e.Result.ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0009A6F4 File Offset: 0x00098AF4
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

		// Token: 0x0600080A RID: 2058 RVA: 0x0009A744 File Offset: 0x00098B44
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
			ColumnItem columnItem5 = new ColumnItem();
			ColumnItem columnItem6 = new ColumnItem();
			ColumnItem columnItem7 = new ColumnItem();
			ColumnItem columnItem8 = new ColumnItem();
			ColumnItem columnItem9 = new ColumnItem();
			ColumnItem columnItem10 = new ColumnItem();
			ColumnItem columnItem11 = new ColumnItem();
			ColumnItem columnItem12 = new ColumnItem();
			this.tbMMStopPrice = new TextBox();
			this.cbMMPrice = new TextBox();
			this.lbMMPrice = new Label();
			this.lbMMTotalLoss = new Label();
			this.tbMMTotalLoss = new TextBox();
			this.lbMMGiveUp = new Label();
			this.tbMMGiveUp = new TextBox();
			this.lbMMStopPrice = new Label();
			this.cbMMStock = new ComboBox();
			this.lbMMStock = new Label();
			this.lbMMVolume = new Label();
			this.tbMMVolume = new TextBox();
			this.label1 = new Label();
			this.tbCommRate = new TextBox();
			this.label2 = new Label();
			this.tbVAT = new TextBox();
			this.btnSimulate = new Button();
			this.panel1 = new Panel();
			this.button1 = new Button();
			this.tbRepurchasePrice = new TextBox();
			this.label9 = new Label();
			this.groupBox1 = new GroupBox();
			this.label6 = new Label();
			this.tbTakeVolPct = new TextBox();
			this.label7 = new Label();
			this.tbTakePrice = new TextBox();
			this.tbTakeVol = new TextBox();
			this.tbTakePriceRatio = new TextBox();
			this.tbStopPrice = new TextBox();
			this.label5 = new Label();
			this.cbCondition = new ComboBox();
			this.label3 = new Label();
			this.label10 = new Label();
			this.tbTime = new TextBox();
			this.panel2 = new Panel();
			this.btnClose = new Button();
			this.btnSend = new Button();
			this.gridSimm = new ExpandGrid();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.tbMMStopPrice.AllowDrop = true;
			this.tbMMStopPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbMMStopPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMStopPrice.Location = new Point(320, 7);
			this.tbMMStopPrice.Margin = new Padding(2, 3, 2, 3);
			this.tbMMStopPrice.MaxLength = 10;
			this.tbMMStopPrice.Name = "tbMMStopPrice";
			this.tbMMStopPrice.Size = new Size(63, 20);
			this.tbMMStopPrice.TabIndex = 136;
			this.tbMMStopPrice.TextChanged += new EventHandler(this.tbMMStopPrice_TextChanged);
			this.tbMMStopPrice.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.tbMMStopPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbMMStopPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbMMPrice.AllowDrop = true;
			this.cbMMPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.cbMMPrice.BorderStyle = BorderStyle.FixedSingle;
			this.cbMMPrice.ForeColor = Color.Black;
			this.cbMMPrice.Location = new Point(188, 7);
			this.cbMMPrice.Name = "cbMMPrice";
			this.cbMMPrice.Size = new Size(64, 20);
			this.cbMMPrice.TabIndex = 134;
			this.cbMMPrice.TextChanged += new EventHandler(this.cbMMPrice_TextChanged);
			this.cbMMPrice.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.cbMMPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbMMPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbMMPrice.AutoSize = true;
			this.lbMMPrice.ForeColor = Color.WhiteSmoke;
			this.lbMMPrice.Location = new Point(156, 11);
			this.lbMMPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbMMPrice.Name = "lbMMPrice";
			this.lbMMPrice.Size = new Size(31, 13);
			this.lbMMPrice.TabIndex = 135;
			this.lbMMPrice.Text = "Price";
			this.lbMMPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.lbMMTotalLoss.AutoSize = true;
			this.lbMMTotalLoss.ForeColor = Color.LightGray;
			this.lbMMTotalLoss.Location = new Point(260, 36);
			this.lbMMTotalLoss.Margin = new Padding(2, 0, 2, 0);
			this.lbMMTotalLoss.Name = "lbMMTotalLoss";
			this.lbMMTotalLoss.Size = new Size(57, 13);
			this.lbMMTotalLoss.TabIndex = 133;
			this.lbMMTotalLoss.Text = "Loss(Baht)";
			this.lbMMTotalLoss.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMTotalLoss.AllowDrop = true;
			this.tbMMTotalLoss.BackColor = Color.FromArgb(64, 64, 64);
			this.tbMMTotalLoss.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMTotalLoss.ForeColor = Color.FromArgb(255, 128, 128);
			this.tbMMTotalLoss.Location = new Point(320, 32);
			this.tbMMTotalLoss.Margin = new Padding(2, 3, 2, 3);
			this.tbMMTotalLoss.MaxLength = 10;
			this.tbMMTotalLoss.Name = "tbMMTotalLoss";
			this.tbMMTotalLoss.ReadOnly = true;
			this.tbMMTotalLoss.Size = new Size(63, 20);
			this.tbMMTotalLoss.TabIndex = 132;
			this.tbMMTotalLoss.Text = "0";
			this.tbMMTotalLoss.TextAlign = HorizontalAlignment.Center;
			this.lbMMGiveUp.AutoSize = true;
			this.lbMMGiveUp.ForeColor = Color.LightGray;
			this.lbMMGiveUp.Location = new Point(392, 11);
			this.lbMMGiveUp.Margin = new Padding(2, 0, 2, 0);
			this.lbMMGiveUp.Name = "lbMMGiveUp";
			this.lbMMGiveUp.Size = new Size(52, 13);
			this.lbMMGiveUp.TabIndex = 131;
			this.lbMMGiveUp.Text = "%Give up";
			this.lbMMGiveUp.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMGiveUp.AllowDrop = true;
			this.tbMMGiveUp.BackColor = Color.FromArgb(224, 224, 224);
			this.tbMMGiveUp.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMGiveUp.Location = new Point(445, 7);
			this.tbMMGiveUp.Margin = new Padding(2, 3, 2, 3);
			this.tbMMGiveUp.MaxLength = 10;
			this.tbMMGiveUp.Name = "tbMMGiveUp";
			this.tbMMGiveUp.Size = new Size(42, 20);
			this.tbMMGiveUp.TabIndex = 130;
			this.tbMMGiveUp.TextChanged += new EventHandler(this.tbMMGiveUp_TextChanged);
			this.tbMMGiveUp.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.tbMMGiveUp.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbMMGiveUp.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbMMStopPrice.AutoSize = true;
			this.lbMMStopPrice.ForeColor = Color.WhiteSmoke;
			this.lbMMStopPrice.Location = new Point(261, 11);
			this.lbMMStopPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbMMStopPrice.Name = "lbMMStopPrice";
			this.lbMMStopPrice.Size = new Size(56, 13);
			this.lbMMStopPrice.TabIndex = 129;
			this.lbMMStopPrice.Text = "Stop Price";
			this.lbMMStopPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.cbMMStock.AllowDrop = true;
			this.cbMMStock.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbMMStock.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbMMStock.BackColor = Color.FromArgb(224, 224, 224);
			this.cbMMStock.FlatStyle = FlatStyle.Popup;
			this.cbMMStock.ForeColor = Color.Black;
			this.cbMMStock.FormattingEnabled = true;
			this.cbMMStock.Location = new Point(57, 7);
			this.cbMMStock.MaxLength = 20;
			this.cbMMStock.Name = "cbMMStock";
			this.cbMMStock.Size = new Size(90, 21);
			this.cbMMStock.TabIndex = 125;
			this.cbMMStock.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbMMStock.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbMMStock.KeyPress += new KeyPressEventHandler(this.cbMMStock_KeyPress);
			this.cbMMStock.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.lbMMStock.AutoSize = true;
			this.lbMMStock.ForeColor = Color.LightGray;
			this.lbMMStock.Location = new Point(13, 11);
			this.lbMMStock.Margin = new Padding(2, 0, 2, 0);
			this.lbMMStock.Name = "lbMMStock";
			this.lbMMStock.Size = new Size(41, 13);
			this.lbMMStock.TabIndex = 128;
			this.lbMMStock.Text = "Symbol";
			this.lbMMStock.TextAlign = ContentAlignment.MiddleLeft;
			this.lbMMVolume.AutoSize = true;
			this.lbMMVolume.ForeColor = Color.LightGray;
			this.lbMMVolume.Location = new Point(12, 36);
			this.lbMMVolume.Margin = new Padding(2, 0, 2, 0);
			this.lbMMVolume.Name = "lbMMVolume";
			this.lbMMVolume.Size = new Size(42, 13);
			this.lbMMVolume.TabIndex = 127;
			this.lbMMVolume.Text = "Volume";
			this.lbMMVolume.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMVolume.AllowDrop = true;
			this.tbMMVolume.BackColor = Color.FromArgb(64, 64, 64);
			this.tbMMVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMVolume.ForeColor = Color.Cyan;
			this.tbMMVolume.Location = new Point(57, 32);
			this.tbMMVolume.Margin = new Padding(2, 3, 2, 3);
			this.tbMMVolume.MaxLength = 10;
			this.tbMMVolume.Name = "tbMMVolume";
			this.tbMMVolume.ReadOnly = true;
			this.tbMMVolume.Size = new Size(90, 20);
			this.tbMMVolume.TabIndex = 126;
			this.tbMMVolume.Text = "0";
			this.tbMMVolume.TextAlign = HorizontalAlignment.Center;
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.LightGray;
			this.label1.Location = new Point(89, 16);
			this.label1.Margin = new Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(62, 13);
			this.label1.TabIndex = 139;
			this.label1.Text = "Comm Rate";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.tbCommRate.AllowDrop = true;
			this.tbCommRate.BackColor = Color.FromArgb(60, 60, 60);
			this.tbCommRate.BorderStyle = BorderStyle.FixedSingle;
			this.tbCommRate.ForeColor = Color.Yellow;
			this.tbCommRate.Location = new Point(153, 12);
			this.tbCommRate.Margin = new Padding(2, 3, 2, 3);
			this.tbCommRate.MaxLength = 10;
			this.tbCommRate.Name = "tbCommRate";
			this.tbCommRate.ReadOnly = true;
			this.tbCommRate.Size = new Size(42, 20);
			this.tbCommRate.TabIndex = 138;
			this.tbCommRate.Text = "0.20";
			this.tbCommRate.TextAlign = HorizontalAlignment.Center;
			this.label2.AutoSize = true;
			this.label2.ForeColor = Color.LightGray;
			this.label2.Location = new Point(213, 16);
			this.label2.Margin = new Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(28, 13);
			this.label2.TabIndex = 141;
			this.label2.Text = "VAT";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.tbVAT.AllowDrop = true;
			this.tbVAT.BackColor = Color.FromArgb(60, 60, 60);
			this.tbVAT.BorderStyle = BorderStyle.FixedSingle;
			this.tbVAT.ForeColor = Color.Yellow;
			this.tbVAT.Location = new Point(246, 12);
			this.tbVAT.Margin = new Padding(2, 3, 2, 3);
			this.tbVAT.MaxLength = 10;
			this.tbVAT.Name = "tbVAT";
			this.tbVAT.ReadOnly = true;
			this.tbVAT.Size = new Size(42, 20);
			this.tbVAT.TabIndex = 140;
			this.tbVAT.Text = "7";
			this.tbVAT.TextAlign = HorizontalAlignment.Center;
			this.btnSimulate.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnSimulate.AutoEllipsis = true;
			this.btnSimulate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSimulate.BackColor = Color.Transparent;
			this.btnSimulate.Cursor = Cursors.Hand;
			this.btnSimulate.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSimulate.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSimulate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSimulate.FlatStyle = FlatStyle.Flat;
			this.btnSimulate.ForeColor = Color.WhiteSmoke;
			this.btnSimulate.Image = Resources.side_noside;
			this.btnSimulate.Location = new Point(684, 31);
			this.btnSimulate.MaximumSize = new Size(58, 23);
			this.btnSimulate.Name = "btnSimulate";
			this.btnSimulate.Size = new Size(57, 22);
			this.btnSimulate.TabIndex = 142;
			this.btnSimulate.TabStop = false;
			this.btnSimulate.Text = "Simulate";
			this.btnSimulate.UseVisualStyleBackColor = false;
			this.btnSimulate.Click += new EventHandler(this.btnSimulate_Click);
			this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.panel1.BackColor = Color.FromArgb(45, 45, 45);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.tbRepurchasePrice);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.tbStopPrice);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new Point(530, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(224, 225);
			this.panel1.TabIndex = 144;
			this.button1.AutoEllipsis = true;
			this.button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = Color.Transparent;
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = Color.DimGray;
			this.button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.ForeColor = Color.WhiteSmoke;
			this.button1.Image = Resources.side_noside;
			this.button1.Location = new Point(163, 195);
			this.button1.MaximumSize = new Size(58, 23);
			this.button1.Name = "button1";
			this.button1.Size = new Size(52, 22);
			this.button1.TabIndex = 149;
			this.button1.TabStop = false;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = false;
			this.tbRepurchasePrice.AllowDrop = true;
			this.tbRepurchasePrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbRepurchasePrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbRepurchasePrice.ForeColor = Color.Black;
			this.tbRepurchasePrice.Location = new Point(128, 135);
			this.tbRepurchasePrice.Name = "tbRepurchasePrice";
			this.tbRepurchasePrice.Size = new Size(85, 20);
			this.tbRepurchasePrice.TabIndex = 147;
			this.label9.AutoSize = true;
			this.label9.ForeColor = Color.WhiteSmoke;
			this.label9.Location = new Point(23, 139);
			this.label9.Margin = new Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new Size(101, 13);
			this.label9.TabIndex = 148;
			this.label9.Text = "Repurchase Price <";
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.tbTakeVolPct);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbTakePrice);
			this.groupBox1.Controls.Add(this.tbTakeVol);
			this.groupBox1.Controls.Add(this.tbTakePriceRatio);
			this.groupBox1.Controls.Add(this.cbCondition);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = Color.LightGray;
			this.groupBox1.Location = new Point(12, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(203, 113);
			this.groupBox1.TabIndex = 146;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Take Profit";
			this.label6.AutoSize = true;
			this.label6.ForeColor = Color.WhiteSmoke;
			this.label6.Location = new Point(15, 56);
			this.label6.Margin = new Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new Size(59, 13);
			this.label6.TabIndex = 141;
			this.label6.Text = "Profit Ratio";
			this.label6.TextAlign = ContentAlignment.MiddleLeft;
			this.tbTakeVolPct.AllowDrop = true;
			this.tbTakeVolPct.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTakeVolPct.BorderStyle = BorderStyle.FixedSingle;
			this.tbTakeVolPct.ForeColor = Color.Black;
			this.tbTakeVolPct.Location = new Point(78, 79);
			this.tbTakeVolPct.Name = "tbTakeVolPct";
			this.tbTakeVolPct.Size = new Size(38, 20);
			this.tbTakeVolPct.TabIndex = 144;
			this.label7.AutoSize = true;
			this.label7.ForeColor = Color.WhiteSmoke;
			this.label7.Location = new Point(41, 82);
			this.label7.Margin = new Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new Size(30, 13);
			this.label7.TabIndex = 145;
			this.label7.Text = "%Vol";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.tbTakePrice.AllowDrop = true;
			this.tbTakePrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTakePrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbTakePrice.ForeColor = Color.Black;
			this.tbTakePrice.Location = new Point(120, 51);
			this.tbTakePrice.Name = "tbTakePrice";
			this.tbTakePrice.ReadOnly = true;
			this.tbTakePrice.Size = new Size(75, 20);
			this.tbTakePrice.TabIndex = 136;
			this.tbTakeVol.AllowDrop = true;
			this.tbTakeVol.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTakeVol.BorderStyle = BorderStyle.FixedSingle;
			this.tbTakeVol.ForeColor = Color.Black;
			this.tbTakeVol.Location = new Point(120, 79);
			this.tbTakeVol.Name = "tbTakeVol";
			this.tbTakeVol.ReadOnly = true;
			this.tbTakeVol.Size = new Size(75, 20);
			this.tbTakeVol.TabIndex = 142;
			this.tbTakePriceRatio.AllowDrop = true;
			this.tbTakePriceRatio.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTakePriceRatio.BorderStyle = BorderStyle.FixedSingle;
			this.tbTakePriceRatio.ForeColor = Color.Black;
			this.tbTakePriceRatio.Location = new Point(78, 51);
			this.tbTakePriceRatio.Name = "tbTakePriceRatio";
			this.tbTakePriceRatio.Size = new Size(38, 20);
			this.tbTakePriceRatio.TabIndex = 140;
			this.tbStopPrice.AllowDrop = true;
			this.tbStopPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbStopPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbStopPrice.ForeColor = Color.Black;
			this.tbStopPrice.Location = new Point(128, 162);
			this.tbStopPrice.Name = "tbStopPrice";
			this.tbStopPrice.Size = new Size(85, 20);
			this.tbStopPrice.TabIndex = 138;
			this.label5.AutoSize = true;
			this.label5.ForeColor = Color.WhiteSmoke;
			this.label5.Location = new Point(53, 166);
			this.label5.Margin = new Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new Size(71, 13);
			this.label5.TabIndex = 139;
			this.label5.Text = "Stop Price <=";
			this.label5.TextAlign = ContentAlignment.MiddleLeft;
			this.cbCondition.AllowDrop = true;
			this.cbCondition.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbCondition.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbCondition.BackColor = Color.FromArgb(224, 224, 224);
			this.cbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbCondition.FlatStyle = FlatStyle.Popup;
			this.cbCondition.ForeColor = Color.Black;
			this.cbCondition.FormattingEnabled = true;
			this.cbCondition.Location = new Point(79, 22);
			this.cbCondition.MaxLength = 20;
			this.cbCondition.Name = "cbCondition";
			this.cbCondition.Size = new Size(116, 21);
			this.cbCondition.TabIndex = 131;
			this.label3.AutoSize = true;
			this.label3.ForeColor = Color.LightGray;
			this.label3.Location = new Point(24, 26);
			this.label3.Margin = new Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(51, 13);
			this.label3.TabIndex = 130;
			this.label3.Text = "Condition";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.label10.AutoSize = true;
			this.label10.ForeColor = Color.LightGray;
			this.label10.Location = new Point(11, 16);
			this.label10.Margin = new Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new Size(30, 13);
			this.label10.TabIndex = 146;
			this.label10.Text = "Time";
			this.label10.TextAlign = ContentAlignment.MiddleLeft;
			this.tbTime.AllowDrop = true;
			this.tbTime.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTime.BorderStyle = BorderStyle.FixedSingle;
			this.tbTime.Location = new Point(46, 12);
			this.tbTime.Margin = new Padding(2, 3, 2, 3);
			this.tbTime.MaxLength = 10;
			this.tbTime.Name = "tbTime";
			this.tbTime.Size = new Size(35, 20);
			this.tbTime.TabIndex = 145;
			this.tbTime.Text = "5";
			this.tbTime.TextAlign = HorizontalAlignment.Center;
			this.tbTime.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbTime.Enter += new EventHandler(this.controlOrder_Enter);
			this.panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel2.BackColor = Color.FromArgb(45, 45, 45);
			this.panel2.Controls.Add(this.lbMMStock);
			this.panel2.Controls.Add(this.tbMMVolume);
			this.panel2.Controls.Add(this.lbMMVolume);
			this.panel2.Controls.Add(this.cbMMStock);
			this.panel2.Controls.Add(this.lbMMStopPrice);
			this.panel2.Controls.Add(this.btnSimulate);
			this.panel2.Controls.Add(this.tbMMGiveUp);
			this.panel2.Controls.Add(this.lbMMGiveUp);
			this.panel2.Controls.Add(this.tbMMTotalLoss);
			this.panel2.Controls.Add(this.lbMMTotalLoss);
			this.panel2.Controls.Add(this.lbMMPrice);
			this.panel2.Controls.Add(this.cbMMPrice);
			this.panel2.Controls.Add(this.tbMMStopPrice);
			this.panel2.Location = new Point(9, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(745, 59);
			this.panel2.TabIndex = 147;
			this.btnClose.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnClose.AutoEllipsis = true;
			this.btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnClose.BackColor = Color.Transparent;
			this.btnClose.Cursor = Cursors.Hand;
			this.btnClose.FlatAppearance.BorderColor = Color.DimGray;
			this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnClose.FlatStyle = FlatStyle.Flat;
			this.btnClose.ForeColor = Color.WhiteSmoke;
			this.btnClose.Image = Resources.side_noside;
			this.btnClose.Location = new Point(702, 7);
			this.btnClose.MaximumSize = new Size(58, 23);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(52, 22);
			this.btnClose.TabIndex = 148;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnSend.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnSend.AutoEllipsis = true;
			this.btnSend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSend.BackColor = Color.Transparent;
			this.btnSend.Cursor = Cursors.Hand;
			this.btnSend.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSend.FlatStyle = FlatStyle.Flat;
			this.btnSend.ForeColor = Color.WhiteSmoke;
			this.btnSend.Image = Resources.side_noside;
			this.btnSend.Location = new Point(465, 310);
			this.btnSend.MaximumSize = new Size(58, 23);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new Size(58, 22);
			this.btnSend.TabIndex = 150;
			this.btnSend.TabStop = false;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new EventHandler(this.btnSend_Click);
			this.gridSimm.AllowDrop = true;
			this.gridSimm.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridSimm.BackColor = Color.FromArgb(20, 20, 20);
			this.gridSimm.CanBlink = true;
			this.gridSimm.CanDrag = false;
			this.gridSimm.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "Step";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 9;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "take_condition";
			columnItem2.Text = "Take Profit Condition";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 55;
			columnItem3.Alignment = StringAlignment.Near;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "repurchase_cond";
			columnItem3.Text = "Repurchase";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 23;
			columnItem4.Alignment = StringAlignment.Near;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "repurchase_price";
			columnItem4.Text = "None";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = false;
			columnItem4.Width = 10;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "stop_price";
			columnItem5.Text = "Stop Price";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 13;
			columnItem6.Alignment = StringAlignment.Near;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "field_type";
			columnItem6.Text = "Condition";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = false;
			columnItem6.Width = 18;
			columnItem7.Alignment = StringAlignment.Near;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "operator_type";
			columnItem7.Text = "None";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = false;
			columnItem7.Width = 10;
			columnItem8.Alignment = StringAlignment.Near;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.FontColor = Color.LightGray;
			columnItem8.IsExpand = false;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "period";
			columnItem8.Text = "None";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = false;
			columnItem8.Width = 10;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.FontColor = Color.LightGray;
			columnItem9.IsExpand = false;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "take_price";
			columnItem9.Text = "Take Profit Price";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = false;
			columnItem9.Width = 15;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.FontColor = Color.LightGray;
			columnItem10.IsExpand = false;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "take_price_ratio";
			columnItem10.Text = "%";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = false;
			columnItem10.Width = 7;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.FontColor = Color.LightGray;
			columnItem11.IsExpand = false;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "take_vol";
			columnItem11.Text = "Take Profit Vol";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = false;
			columnItem11.Width = 15;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.FontColor = Color.LightGray;
			columnItem12.IsExpand = false;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "take_vol_pct";
			columnItem12.Text = "%";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = false;
			columnItem12.Width = 7;
			this.gridSimm.Columns.Add(columnItem);
			this.gridSimm.Columns.Add(columnItem2);
			this.gridSimm.Columns.Add(columnItem3);
			this.gridSimm.Columns.Add(columnItem4);
			this.gridSimm.Columns.Add(columnItem5);
			this.gridSimm.Columns.Add(columnItem6);
			this.gridSimm.Columns.Add(columnItem7);
			this.gridSimm.Columns.Add(columnItem8);
			this.gridSimm.Columns.Add(columnItem9);
			this.gridSimm.Columns.Add(columnItem10);
			this.gridSimm.Columns.Add(columnItem11);
			this.gridSimm.Columns.Add(columnItem12);
			this.gridSimm.CurrentScroll = 0;
			this.gridSimm.FocusItemIndex = -1;
			this.gridSimm.ForeColor = Color.Black;
			this.gridSimm.GridColor = Color.FromArgb(50, 50, 50);
			this.gridSimm.HeaderPctHeight = 100f;
			this.gridSimm.IsAutoRepaint = true;
			this.gridSimm.IsDrawGrid = true;
			this.gridSimm.IsDrawHeader = true;
			this.gridSimm.IsScrollable = true;
			this.gridSimm.Location = new Point(10, 106);
			this.gridSimm.MainColumn = "";
			this.gridSimm.Name = "gridSimm";
			this.gridSimm.Rows = 0;
			this.gridSimm.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridSimm.RowSelectType = 3;
			this.gridSimm.Size = new Size(513, 198);
			this.gridSimm.SortColumnName = "";
			this.gridSimm.SortType = SortType.Desc;
			this.gridSimm.TabIndex = 137;
			this.gridSimm.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.gridSimm_TableMouseClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(763, 339);
			base.Controls.Add(this.btnSend);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.tbTime);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.tbVAT);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.tbCommRate);
			base.Controls.Add(this.gridSimm);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmFTSCreateNew";
			this.Text = "frmFTSCreateNew";
			base.Shown += new EventHandler(this.frmFTSCreateNew_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400048F RID: 1167
		private BackgroundWorker bgwSendOrder;

		// Token: 0x04000490 RID: 1168
		private StockList.StockInformation _stockInfo;

		// Token: 0x04000491 RID: 1169
		private string _showSide;

		// Token: 0x04000492 RID: 1170
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000493 RID: 1171
		private decimal _buyCreditLimit;

		// Token: 0x04000494 RID: 1172
		private decimal _portStockEquity;

		// Token: 0x04000495 RID: 1173
		private long _onhand;

		// Token: 0x04000496 RID: 1174
		private object _objLastActive;

		// Token: 0x04000497 RID: 1175
		private BackgroundWorker bgwGetEquity;

		// Token: 0x04000498 RID: 1176
		private BackgroundWorker bgwReloadCredit;

		// Token: 0x04000499 RID: 1177
		private DataSet _tdsCredit;

		// Token: 0x0400049A RID: 1178
		private long _volume;

		// Token: 0x0400049B RID: 1179
		private decimal _buyPrice;

		// Token: 0x0400049C RID: 1180
		private decimal _stopPrice;

		// Token: 0x0400049D RID: 1181
		private decimal _commRate;

		// Token: 0x0400049E RID: 1182
		private decimal _VAT;

		// Token: 0x0400049F RID: 1183
		private decimal _giveUpPct;

		// Token: 0x040004A0 RID: 1184
		private decimal _loss;

		// Token: 0x040004A1 RID: 1185
		private AutoTradeFTSCommand _command;

		// Token: 0x040004A2 RID: 1186
		private IContainer components;

		// Token: 0x040004A3 RID: 1187
		private TextBox tbMMStopPrice;

		// Token: 0x040004A4 RID: 1188
		private TextBox cbMMPrice;

		// Token: 0x040004A5 RID: 1189
		private Label lbMMPrice;

		// Token: 0x040004A6 RID: 1190
		private Label lbMMTotalLoss;

		// Token: 0x040004A7 RID: 1191
		private TextBox tbMMTotalLoss;

		// Token: 0x040004A8 RID: 1192
		private Label lbMMGiveUp;

		// Token: 0x040004A9 RID: 1193
		private TextBox tbMMGiveUp;

		// Token: 0x040004AA RID: 1194
		private Label lbMMStopPrice;

		// Token: 0x040004AB RID: 1195
		private ComboBox cbMMStock;

		// Token: 0x040004AC RID: 1196
		private Label lbMMStock;

		// Token: 0x040004AD RID: 1197
		private Label lbMMVolume;

		// Token: 0x040004AE RID: 1198
		private TextBox tbMMVolume;

		// Token: 0x040004AF RID: 1199
		private ExpandGrid gridSimm;

		// Token: 0x040004B0 RID: 1200
		private Label label1;

		// Token: 0x040004B1 RID: 1201
		private TextBox tbCommRate;

		// Token: 0x040004B2 RID: 1202
		private Label label2;

		// Token: 0x040004B3 RID: 1203
		private TextBox tbVAT;

		// Token: 0x040004B4 RID: 1204
		private Button btnSimulate;

		// Token: 0x040004B5 RID: 1205
		private Panel panel1;

		// Token: 0x040004B6 RID: 1206
		private ComboBox cbCondition;

		// Token: 0x040004B7 RID: 1207
		private Label label3;

		// Token: 0x040004B8 RID: 1208
		private TextBox tbStopPrice;

		// Token: 0x040004B9 RID: 1209
		private Label label5;

		// Token: 0x040004BA RID: 1210
		private TextBox tbTakePrice;

		// Token: 0x040004BB RID: 1211
		private TextBox tbTakeVolPct;

		// Token: 0x040004BC RID: 1212
		private Label label7;

		// Token: 0x040004BD RID: 1213
		private TextBox tbTakeVol;

		// Token: 0x040004BE RID: 1214
		private TextBox tbTakePriceRatio;

		// Token: 0x040004BF RID: 1215
		private Label label6;

		// Token: 0x040004C0 RID: 1216
		private GroupBox groupBox1;

		// Token: 0x040004C1 RID: 1217
		private TextBox tbRepurchasePrice;

		// Token: 0x040004C2 RID: 1218
		private Label label9;

		// Token: 0x040004C3 RID: 1219
		private Button button1;

		// Token: 0x040004C4 RID: 1220
		private Label label10;

		// Token: 0x040004C5 RID: 1221
		private TextBox tbTime;

		// Token: 0x040004C6 RID: 1222
		private Panel panel2;

		// Token: 0x040004C7 RID: 1223
		private Button btnClose;

		// Token: 0x040004C8 RID: 1224
		private Button btnSend;

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x0600080C RID: 2060
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
