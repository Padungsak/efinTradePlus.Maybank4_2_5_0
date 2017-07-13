using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using CSVReaderTest;
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.CustomGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x020000A4 RID: 164
	public class frmTradeJornal : Form
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x00091458 File Offset: 0x0008F858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataTable CreateOverviewTable()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new DataTable("overview")
			{
				Columns = 
				{
					"equitytext",
					"equityValue",
					"tradetext",
					"tradevalue",
					"tradepct",
					"wintext",
					"winvalue",
					"winpct",
					"losstext",
					"losevalue",
					"losspct"
				}
			};
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00091544 File Offset: 0x0008F944
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataTable CreateOrderTable()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new DataTable("orderQueue")
			{
				Columns = 
				{
					"dateopen",
					"dateclose",
					"direction",
					"entryprice",
					"stoploss",
					"takeprofit",
					"exitprice",
					"riskreward",
					"loss",
					"profit",
					"profitpct",
					"losspct",
					"balance"
				}
			};
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00091650 File Offset: 0x0008FA50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmTradeJornal()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._totalTJAmount = 0m;
			this._dataSetTJ = null;
			this.lastFocus = -1;
			this.isEditing = false;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
			decimal.TryParse(this.tstxtAmount.Text.Replace(",", ""), out this._totalTJAmount);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000916D0 File Offset: 0x0008FAD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00091704 File Offset: 0x0008FB04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Prior:
			case Keys.Next:
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00091764 File Offset: 0x0008FB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000917A0 File Offset: 0x0008FBA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_KeyUp(object sender, KeyEventArgs e)
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
					if (keyCode == Keys.Escape)
					{
						this.cbText.Hide();
						goto IL_566;
					}
					switch (keyCode)
					{
					case Keys.Left:
					{
						string text = this.cbText.Tag.ToString();
						switch (text)
						{
						case "profit":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "loss");
							break;
						case "loss":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "exitprice");
							break;
						case "exitprice":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "takeprofit");
							break;
						case "takeprofit":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "stoploss");
							break;
						case "stoploss":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "entryprice");
							break;
						case "entryprice":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "positionsize");
							break;
						case "positionsize":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "direction");
							break;
						case "direction":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "dateclose");
							break;
						case "dateclose":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "dateopen");
							break;
						}
						e.SuppressKeyPress = true;
						goto IL_566;
					}
					case Keys.Up:
						if (this.sortGrid1.FocusItemIndex - 1 > -1)
						{
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex - 1);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, this.cbText.Tag.ToString());
						}
						e.SuppressKeyPress = true;
						goto IL_566;
					case Keys.Right:
						break;
					case Keys.Down:
						if (this.sortGrid1.FocusItemIndex + 1 < this.sortGrid1.Rows)
						{
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex + 1, this.cbText.Tag.ToString());
						}
						e.SuppressKeyPress = true;
						goto IL_566;
					default:
						goto IL_566;
					}
				}
				if (this.SetText())
				{
					string text = this.cbText.Tag.ToString();
					switch (text)
					{
					case "dateopen":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "dateclose");
						break;
					case "dateclose":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "direction");
						break;
					case "direction":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "entryprice");
						this.calOverview();
						break;
					case "entryprice":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "stoploss");
						this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
						break;
					case "stoploss":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "takeprofit");
						this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
						break;
					case "takeprofit":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "exitprice");
						this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
						break;
					case "exitprice":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "loss");
						break;
					case "loss":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "profit");
						this.calBalanceByRow(this.sortGrid1.FocusItemIndex);
						this.calOverview();
						break;
					case "profit":
						this.calBalanceByRow(this.sortGrid1.FocusItemIndex);
						this.calOverview();
						break;
					}
				}
				e.SuppressKeyPress = true;
				IL_566:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbText_KeyUp", ex);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00091D4C File Offset: 0x0009014C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cbText.Hide();
			if (this.SetText())
			{
				string text = this.cbText.Tag.ToString();
				switch (text)
				{
				case "dateopen":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "dateclose");
					break;
				case "dateclose":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "direction");
					break;
				case "direction":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "entryprice");
					break;
				case "entryprice":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "stoploss");
					this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
					break;
				case "stoploss":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "takeprofit");
					this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
					break;
				case "takeprofit":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "exitprice");
					this.calRiskRewardByRow(this.sortGrid1.FocusItemIndex);
					break;
				case "exitprice":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "loss");
					break;
				case "loss":
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, "profit");
					this.calBalanceByRow(this.sortGrid1.FocusItemIndex);
					this.calOverview();
					break;
				case "profit":
					this.calBalanceByRow(this.sortGrid1.FocusItemIndex);
					this.calOverview();
					break;
				}
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00091FB4 File Offset: 0x000903B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbText.Tag.ToString() == "entryprice" || this.cbText.Tag.ToString() == "stoploss" || this.cbText.Tag.ToString() == "takeprofit" || this.cbText.Tag.ToString() == "exitprice" || this.cbText.Tag.ToString() == "loss" || this.cbText.Tag.ToString() == "profit")
				{
					if (this.cbText.Text.Trim() != string.Empty)
					{
						if (FormatUtil.Isnumeric(this.cbText.Text))
						{
							try
							{
								decimal num = Convert.ToDecimal(this.cbText.Text.Replace(",", ""));
								this.cbText.Text = num.ToString("#,###.##");
								this.cbText.Select(this.cbText.Text.Length, 0);
							}
							catch
							{
								this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
							}
						}
						else
						{
							bool flag = false;
							string text = string.Empty;
							if (this.cbText.Text.Length > 0)
							{
								if (this.cbText.Text.Substring(0, 1) == "-")
								{
									flag = true;
								}
								text = this.cbText.Text.Replace("-", "");
								if (FormatUtil.Isnumeric(text) || string.IsNullOrEmpty(text))
								{
									if (FormatUtil.Isnumeric(text))
									{
										try
										{
											decimal num = Convert.ToDecimal(this.cbText.Text.Replace(",", ""));
											this.cbText.Text = num.ToString("#,###.##");
											this.cbText.Select(this.cbText.Text.Length, 0);
										}
										catch
										{
											this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
										}
									}
									if (flag)
									{
										this.cbText.Text = "-" + text;
									}
									else
									{
										this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
									}
								}
								else
								{
									this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
								}
							}
							else
							{
								this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
							}
						}
					}
				}
				if (!this.isEditing && this.sortGrid1.FocusItemIndex > -1 && this.cbText.Tag != null)
				{
					this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields(this.cbText.Tag.ToString()).Text = this.cbText.Text;
					if (this.cbText.Tag.ToString() == "direction")
					{
						if (this.cbText.Text.ToString().Trim().ToUpper() == "L")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("direction").FontColor = Color.Lime;
						}
						else if (this.cbText.Text.ToString().Trim().ToUpper() == "S")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("direction").FontColor = Color.Red;
						}
					}
					this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Changed = true;
					this.sortGrid1.EndUpdate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbText_TextChanged", ex);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00092578 File Offset: 0x00090978
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid1_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex == -1)
				{
					string name = e.Column.Name;
					if (name != null)
					{
						if (name == "side" || name == "stock" || name == "volume" || name == "price" || name == "pubvol")
						{
							if (this.sortGrid1.SortType == SortType.Asc)
							{
								this.sortGrid1.Sort(e.Column.Name, SortType.Desc);
							}
							else
							{
								this.sortGrid1.Sort(e.Column.Name, SortType.Asc);
							}
							this.sortGrid1.Redraw();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intza_TableMouseClick", ex);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0009269C File Offset: 0x00090A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid1_TableMouseDoubleClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if ((float)e.Mouse.Y > this.sortGrid1.RowHeight)
				{
					string name = e.Column.Name;
					switch (name)
					{
					case "dateopen":
					case "dateclose":
					case "direction":
					case "positionsize":
					case "entryprice":
					case "stoploss":
					case "takeprofit":
					case "exitprice":
					case "loss":
					case "profit":
						this.SetTextPosition(e.RowIndex, e.Column.Name);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intza_TableMouseClick", ex);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00092820 File Offset: 0x00090C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTextPosition(int rowIndex, string columnName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.isEditing = true;
				this.lastFocus = rowIndex;
				Rectangle position = this.sortGrid1.GetPosition(rowIndex, columnName);
				this.cbText.DataSource = null;
				this.cbText.Items.Clear();
				this.sortGrid1.SetFocusItem(rowIndex);
				this.cbText.Tag = columnName;
				this.cbText.SetBounds(position.X + this.sortGrid1.Left, position.Y + this.sortGrid1.Top + 1, position.Width, position.Height);
				if (columnName != null)
				{
					if (!(columnName == "dateopen"))
					{
						if (!(columnName == "dateclose"))
						{
							if (columnName == "direction")
							{
								this.cbText.Items.Add("L");
								this.cbText.Items.Add("S");
							}
						}
						else
						{
							this.cbText.DataSource = this.GetDates(DateTime.Now.Year, DateTime.Now.Month);
						}
					}
					else
					{
						this.cbText.DataSource = this.GetDates(DateTime.Now.Year, DateTime.Now.Month);
					}
				}
				this.cbText.BringToFront();
				this.cbText.Show();
				this.cbText.Text = this.sortGrid1.Records(rowIndex).Fields(columnName).Text.ToString();
				this.cbText.Focus();
				this.cbText.SelectAll();
				this.isEditing = false;
			}
			catch (Exception ex)
			{
				this.isEditing = false;
				this.ShowError("SetTextPosition", ex);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00092A44 File Offset: 0x00090E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SetText()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			try
			{
				string text = this.cbText.Tag.ToString();
				switch (text)
				{
				case "direction":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "L" || text == "S")
						{
							result = true;
						}
					}
					break;
				case "entryprice":
				case "stoploss":
				case "takeprofit":
				case "exitprice":
					if (FormatUtil.Isnumeric(this.cbText.Text.Trim()))
					{
						result = true;
					}
					break;
				case "loss":
					if (FormatUtil.Isnumeric(this.cbText.Text.Trim()))
					{
						if (Convert.ToDecimal(this.cbText.Text.Trim()) != 0m)
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("profit").Text = "";
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "loss";
							this.sortGrid1.EndUpdate();
						}
						else if (Convert.ToDecimal(this.cbText.Text.Trim()) == 0m)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("profit").Text.ToString().Trim() == "")
							{
								this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "";
							}
						}
						result = true;
					}
					else if (string.IsNullOrEmpty(this.cbText.Text.Trim()))
					{
						if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("profit").Text.ToString().Trim() == "")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "";
						}
						result = true;
					}
					break;
				case "profit":
					if (FormatUtil.Isnumeric(this.cbText.Text.Trim()))
					{
						if (Convert.ToDecimal(this.cbText.Text.Trim()) != 0m)
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("loss").Text = "";
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "win";
							this.sortGrid1.EndUpdate();
						}
						else if (Convert.ToDecimal(this.cbText.Text.Trim()) == 0m)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("loss").Text.ToString().Trim() == "")
							{
								this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "";
							}
						}
						result = true;
					}
					else if (string.IsNullOrEmpty(this.cbText.Text.Trim()))
					{
						if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("loss").Text.ToString().Trim() == "")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("winloss").Text = "";
						}
						result = true;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetText", ex);
			}
			return result;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00092FCC File Offset: 0x000913CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calOverview()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				decimal num5 = 0m;
				string text = string.Empty;
				string a = string.Empty;
				for (int i = 0; i < this.sortGrid1.Rows; i++)
				{
					text = this.sortGrid1.Records(i).Fields("winloss").Text.ToString().Trim();
					a = this.sortGrid1.Records(i).Fields("direction").Text.ToString().Trim();
					if (!string.IsNullOrEmpty(text))
					{
						if (text == "win")
						{
							if (a == "L")
							{
								num++;
							}
							else if (a == "S")
							{
								num2++;
							}
						}
						else if (text == "loss")
						{
							if (a == "L")
							{
								num3++;
							}
							else if (a == "S")
							{
								num4++;
							}
						}
					}
				}
				decimal.TryParse(this.sortGrid1.Records(this.sortGrid1.Rows - 1).Fields("tmpbalance").Text.ToString().Replace(",", ""), out num5);
				decimal d;
				if (this._totalTJAmount != 0m)
				{
					d = (num5 - this._totalTJAmount) / this._totalTJAmount;
				}
				else
				{
					d = 0m;
				}
				this.intzaTradeOverview.Item("tbEquityInvest").Text = FormatUtil.PriceFormat(this._totalTJAmount, 2, "0.00");
				this.intzaTradeOverview.Item("tbCurrEquity").Text = FormatUtil.PriceFormat(num5, 2, "0.00");
				this.intzaTradeOverview.Item("tbTotalPL").Text = FormatUtil.PriceFormat(d * this._totalTJAmount, 2, "0.00");
				this.intzaTradeOverview.Item("tbTotalPLPct").Text = FormatUtil.PriceFormat(d * 100m, 2, "0.00") + "%";
				this.intzaTradeOverview.Item("tbTotalTrade").Text = FormatUtil.PriceFormat(num + num2 + num3 + num4, 2, "0");
				this.intzaTradeOverview.Item("tbTotalTradePct").Text = FormatUtil.PriceFormat(100, false, "%", 2);
				this.intzaTradeOverview.Item("tbLongTrade").Text = FormatUtil.PriceFormat(num + num3, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbLongTradePct").Text = FormatUtil.PriceFormat((double)(num + num3) / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbLongTradePct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbShortTrade").Text = FormatUtil.PriceFormat(num2 + num4, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbShortTradePct").Text = FormatUtil.PriceFormat((double)(num2 + num4) / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbShortTradePct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbWinTrade").Text = FormatUtil.PriceFormat(num + num2, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbWinTradePct").Text = FormatUtil.PriceFormat((double)(num + num2) / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbWinTradePct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbWinLong").Text = FormatUtil.PriceFormat(num, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbWinLongPct").Text = FormatUtil.PriceFormat((double)num / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbWinLongPct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbWinShort").Text = FormatUtil.PriceFormat(num2, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbwinShortPct").Text = FormatUtil.PriceFormat((double)num2 / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbwinShortPct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbLoseTrade").Text = FormatUtil.PriceFormat(num3 + num4, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbLoseTradePct").Text = FormatUtil.PriceFormat((double)(num3 + num4) / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbLoseTradePct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbLoseLong").Text = FormatUtil.PriceFormat(num3, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbLoseLongPct").Text = FormatUtil.PriceFormat((double)num3 / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbLoseLongPct").Text = "0.00%";
				}
				this.intzaTradeOverview.Item("tbLoseShort").Text = FormatUtil.PriceFormat(num4, 2, "0");
				if ((double)(num + num2 + num3 + num4) != 0.0)
				{
					this.intzaTradeOverview.Item("tbLoseShortPct").Text = FormatUtil.PriceFormat((double)num4 / (double)(num + num2 + num3 + num4) * 100.0, 2, "0.00") + "%";
				}
				else
				{
					this.intzaTradeOverview.Item("tbLoseShortPct").Text = "0.00%";
				}
				this.intzaTradeOverview.EndUpdate();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00093874 File Offset: 0x00091C74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calRiskRewardByRow(int rowIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal d = 0m;
				decimal num = 0m;
				decimal d2 = 0m;
				decimal.TryParse(this.sortGrid1.Records(rowIndex).Fields("entryprice").Text.ToString().Replace(",", ""), out num);
				decimal.TryParse(this.sortGrid1.Records(rowIndex).Fields("stoploss").Text.ToString().Replace(",", ""), out d2);
				decimal.TryParse(this.sortGrid1.Records(rowIndex).Fields("takeprofit").Text.ToString().Replace(",", ""), out d);
				decimal num2;
				if (num - d2 == 0m)
				{
					num2 = 0m;
				}
				else
				{
					num2 = (d - num) / (num - d2);
				}
				this.sortGrid1.Records(rowIndex).Fields("riskreward").Text = FormatUtil.PriceFormat(num2, 2, "0");
				this.sortGrid1.EndUpdate();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000939F4 File Offset: 0x00091DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calBalanceByRow(int rowIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal d = 0m;
				decimal num = 0m;
				decimal num2 = 0m;
				int i = rowIndex;
				while (i < this.sortGrid1.Rows)
				{
					RecordItem recordItem = this.sortGrid1.Records(i);
					decimal.TryParse(recordItem.Fields("loss").Text.ToString().Replace(",", ""), out d);
					decimal.TryParse(recordItem.Fields("profit").Text.ToString().Replace(",", ""), out num);
					decimal num3;
					decimal num4;
					decimal num5;
					if (i == 0)
					{
						num3 = this._totalTJAmount + (d + num);
						if (this._totalTJAmount != 0m)
						{
							num4 = num / this._totalTJAmount * 100m;
							num5 = d / this._totalTJAmount * 100m;
						}
						else
						{
							num4 = 0m;
							num5 = 0m;
						}
					}
					else
					{
						decimal.TryParse(this.sortGrid1.Records(i - 1).Fields("tmpbalance").Text.ToString().Replace(",", ""), out num2);
						num3 = num2 + (d + num);
						if (num2 != 0m)
						{
							num4 = num / num2 * 100m;
							num5 = d / num2 * 100m;
						}
						else
						{
							num4 = 0m;
							num5 = 0m;
						}
					}
					if (d == 0m && num == 0m)
					{
						recordItem.Fields("balance").Text = "";
					}
					else
					{
						recordItem.Fields("balance").Text = FormatUtil.PriceFormat(num3);
					}
					recordItem.Fields("tmpbalance").Text = num3;
					recordItem.Fields("profitpct").Text = FormatUtil.PriceFormat(num4, false, "%", 2);
					recordItem.Fields("losspct").Text = FormatUtil.PriceFormat(num5, false, "%", 2);
					this.sortGrid1.EndUpdate();
					rowIndex++;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00093D08 File Offset: 0x00092108
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<DateTime> GetDates(int year, int month)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<DateTime> list = new List<DateTime>();
			DateTime item = new DateTime(year, month, 1);
			while (item.Month == month)
			{
				list.Add(item);
				item = item.AddDays(1.0);
			}
			return list;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00093D70 File Offset: 0x00092170
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnExportCSV_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.gridToDataSet();
				if (this._dataSetTJ != null && this._dataSetTJ.Tables.Count > 0)
				{
					CSVReadWrite.exportToCSV(this._dataSetTJ);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00093DEC File Offset: 0x000921EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gridToDataSet()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._dataSetTJ = new DataSet();
				DataTable dataTable = this.CreateOverviewTable();
				dataTable.Rows.Add(new object[0]);
				dataTable.Rows[0][0] = this.intzaTradeOverview.Item("lbEquityInvest").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][1] = this.intzaTradeOverview.Item("tbEquityInvest").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][2] = this.intzaTradeOverview.Item("lbTotalTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][3] = this.intzaTradeOverview.Item("tbTotalTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][4] = this.intzaTradeOverview.Item("tbTotalTradePct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][5] = this.intzaTradeOverview.Item("lbWinTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][6] = this.intzaTradeOverview.Item("tbWinTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][7] = this.intzaTradeOverview.Item("tbWinTradePct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][8] = this.intzaTradeOverview.Item("lbLoseTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][9] = this.intzaTradeOverview.Item("tbLoseTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[0][10] = this.intzaTradeOverview.Item("tbLoseTradePct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows.Add(new object[0]);
				dataTable.Rows[1][0] = this.intzaTradeOverview.Item("lbCurrEquity").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][1] = this.intzaTradeOverview.Item("tbCurrEquity").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][2] = this.intzaTradeOverview.Item("lbLongTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][3] = this.intzaTradeOverview.Item("tbLongTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][4] = this.intzaTradeOverview.Item("tbLongTradePct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][5] = this.intzaTradeOverview.Item("lbWinLong").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][6] = this.intzaTradeOverview.Item("tbWinLong").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][7] = this.intzaTradeOverview.Item("tbWinLongPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][8] = this.intzaTradeOverview.Item("lbLoseLong").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][9] = this.intzaTradeOverview.Item("tbLoseLong").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[1][10] = this.intzaTradeOverview.Item("tbLoseLongPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows.Add(new object[0]);
				dataTable.Rows[2][0] = this.intzaTradeOverview.Item("lbTotalPL").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][1] = this.intzaTradeOverview.Item("tbTotalPL").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][2] = this.intzaTradeOverview.Item("lbShortTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][3] = this.intzaTradeOverview.Item("tbShortTrade").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][4] = this.intzaTradeOverview.Item("tbShortTradePct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][5] = this.intzaTradeOverview.Item("lbWinShort").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][6] = this.intzaTradeOverview.Item("tbWinShort").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][7] = this.intzaTradeOverview.Item("tbwinShortPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][8] = this.intzaTradeOverview.Item("lbLoseShort").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][9] = this.intzaTradeOverview.Item("tbLoseShort").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[2][10] = this.intzaTradeOverview.Item("tbLoseShortPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows.Add(new object[0]);
				dataTable.Rows[3][0] = this.intzaTradeOverview.Item("lbTotalPLPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[3][1] = this.intzaTradeOverview.Item("tbTotalPLPct").Text.ToString().Trim().Replace(",", "");
				dataTable.Rows[3][2] = string.Empty;
				dataTable.Rows[3][3] = string.Empty;
				dataTable.Rows[3][4] = string.Empty;
				dataTable.Rows[3][5] = string.Empty;
				dataTable.Rows[3][6] = string.Empty;
				dataTable.Rows[3][7] = string.Empty;
				dataTable.Rows[3][8] = string.Empty;
				dataTable.Rows[3][9] = string.Empty;
				dataTable.Rows[3][10] = string.Empty;
				DataTable dataTable2 = this.CreateOrderTable();
				dataTable2.Rows.Add(new object[0]);
				dataTable2.Rows[0][0] = "Date Open";
				dataTable2.Rows[0][1] = "Date Close";
				dataTable2.Rows[0][2] = "Direction";
				dataTable2.Rows[0][3] = "Entry Price";
				dataTable2.Rows[0][4] = "Stop Loss";
				dataTable2.Rows[0][5] = "Take Profit";
				dataTable2.Rows[0][6] = "Exit Price";
				dataTable2.Rows[0][7] = "Risk/Reward";
				dataTable2.Rows[0][8] = "Loss";
				dataTable2.Rows[0][9] = "Profit";
				dataTable2.Rows[0][10] = "Profit%";
				dataTable2.Rows[0][11] = "Loss%";
				dataTable2.Rows[0][12] = "Balance";
				for (int i = 0; i < this.sortGrid1.Rows; i++)
				{
					RecordItem recordItem = this.sortGrid1.Records(i);
					if (recordItem.Fields("direction").Text.ToString() != string.Empty && recordItem.Fields("entryprice").Text.ToString() != string.Empty && recordItem.Fields("stoploss").Text.ToString() != string.Empty && recordItem.Fields("takeprofit").Text.ToString() != string.Empty && (recordItem.Fields("loss").Text.ToString() != string.Empty || recordItem.Fields("profit").Text.ToString() != string.Empty))
					{
						dataTable2.Rows.Add(new object[0]);
						dataTable2.Rows[i + 1][0] = recordItem.Fields("dateopen").Text.ToString();
						dataTable2.Rows[i + 1][1] = recordItem.Fields("dateclose").Text.ToString();
						dataTable2.Rows[i + 1][2] = recordItem.Fields("direction").Text.ToString();
						dataTable2.Rows[i + 1][3] = recordItem.Fields("entryprice").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][4] = recordItem.Fields("stoploss").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][5] = recordItem.Fields("takeprofit").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][6] = recordItem.Fields("exitprice").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][7] = recordItem.Fields("riskreward").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][8] = recordItem.Fields("loss").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][9] = recordItem.Fields("profit").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][10] = recordItem.Fields("profitpct").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][11] = recordItem.Fields("losspct").Text.ToString().Replace(",", "");
						dataTable2.Rows[i + 1][12] = recordItem.Fields("balance").Text.ToString().Replace(",", "");
					}
				}
				this._dataSetTJ.Tables.Add(dataTable);
				this._dataSetTJ.Tables.Add(dataTable2);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00094DB8 File Offset: 0x000931B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnAmount_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tsbtnAmount.Visible = false;
			this.tstxtAmount.Visible = true;
			this.tstxtAmount.Text = this.tsbtnAmount.Text;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00094E08 File Offset: 0x00093208
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

		// Token: 0x060007ED RID: 2029 RVA: 0x00094E58 File Offset: 0x00093258
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTradeJornal));
			ItemGrid itemGrid = new ItemGrid();
			ItemGrid itemGrid2 = new ItemGrid();
			ItemGrid itemGrid3 = new ItemGrid();
			ItemGrid itemGrid4 = new ItemGrid();
			ItemGrid itemGrid5 = new ItemGrid();
			ItemGrid itemGrid6 = new ItemGrid();
			ItemGrid itemGrid7 = new ItemGrid();
			ItemGrid itemGrid8 = new ItemGrid();
			ItemGrid itemGrid9 = new ItemGrid();
			ItemGrid itemGrid10 = new ItemGrid();
			ItemGrid itemGrid11 = new ItemGrid();
			ItemGrid itemGrid12 = new ItemGrid();
			ItemGrid itemGrid13 = new ItemGrid();
			ItemGrid itemGrid14 = new ItemGrid();
			ItemGrid itemGrid15 = new ItemGrid();
			ItemGrid itemGrid16 = new ItemGrid();
			ItemGrid itemGrid17 = new ItemGrid();
			ItemGrid itemGrid18 = new ItemGrid();
			ItemGrid itemGrid19 = new ItemGrid();
			ItemGrid itemGrid20 = new ItemGrid();
			ItemGrid itemGrid21 = new ItemGrid();
			ItemGrid itemGrid22 = new ItemGrid();
			ItemGrid itemGrid23 = new ItemGrid();
			ItemGrid itemGrid24 = new ItemGrid();
			ItemGrid itemGrid25 = new ItemGrid();
			ItemGrid itemGrid26 = new ItemGrid();
			ItemGrid itemGrid27 = new ItemGrid();
			ItemGrid itemGrid28 = new ItemGrid();
			ItemGrid itemGrid29 = new ItemGrid();
			ItemGrid itemGrid30 = new ItemGrid();
			ItemGrid itemGrid31 = new ItemGrid();
			ItemGrid itemGrid32 = new ItemGrid();
			ItemGrid itemGrid33 = new ItemGrid();
			ItemGrid itemGrid34 = new ItemGrid();
			ItemGrid itemGrid35 = new ItemGrid();
			ItemGrid itemGrid36 = new ItemGrid();
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
			ColumnItem columnItem13 = new ColumnItem();
			ColumnItem columnItem14 = new ColumnItem();
			ColumnItem columnItem15 = new ColumnItem();
			ColumnItem columnItem16 = new ColumnItem();
			this.tStripTJ = new ToolStrip();
			this.tslbAmountText = new ToolStripLabel();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbtnAmount = new ToolStripButton();
			this.tstxtAmount = new ToolStripTextBox();
			this.tsbtnExportCSV = new ToolStripButton();
			this.cbText = new ComboBox();
			this.intzaTradeOverview = new IntzaCustomGrid();
			this.sortGrid1 = new SortGrid();
			this.tStripTJ.SuspendLayout();
			base.SuspendLayout();
			this.tStripTJ.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripTJ.Dock = DockStyle.Bottom;
			this.tStripTJ.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripTJ.Items.AddRange(new ToolStripItem[]
			{
				this.tslbAmountText,
				this.toolStripSeparator2,
				this.tsbtnAmount,
				this.tstxtAmount,
				this.tsbtnExportCSV
			});
			this.tStripTJ.Location = new Point(0, 405);
			this.tStripTJ.Margin = new Padding(1);
			this.tStripTJ.Name = "tStripTJ";
			this.tStripTJ.Padding = new Padding(1);
			this.tStripTJ.RenderMode = ToolStripRenderMode.Professional;
			this.tStripTJ.Size = new Size(687, 28);
			this.tStripTJ.TabIndex = 27;
			this.tStripTJ.Text = "toolStrip1";
			this.tslbAmountText.ForeColor = Color.WhiteSmoke;
			this.tslbAmountText.Name = "tslbAmountText";
			this.tslbAmountText.Size = new Size(144, 23);
			this.tslbAmountText.Text = "Account Start Transaction";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 26);
			this.tsbtnAmount.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnAmount.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
			this.tsbtnAmount.ForeColor = Color.Cyan;
			this.tsbtnAmount.Image = (Image)componentResourceManager.GetObject("tsbtnAmount.Image");
			this.tsbtnAmount.ImageTransparentColor = Color.Magenta;
			this.tsbtnAmount.Name = "tsbtnAmount";
			this.tsbtnAmount.Size = new Size(41, 23);
			this.tsbtnAmount.Text = "0.00";
			this.tsbtnAmount.Click += new EventHandler(this.tsbtnAmount_Click);
			this.tstxtAmount.Name = "tstxtAmount";
			this.tstxtAmount.Size = new Size(100, 26);
			this.tstxtAmount.Visible = false;
			this.tsbtnExportCSV.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnExportCSV.ForeColor = Color.WhiteSmoke;
			this.tsbtnExportCSV.Image = (Image)componentResourceManager.GetObject("tsbtnExportCSV.Image");
			this.tsbtnExportCSV.ImageTransparentColor = Color.Magenta;
			this.tsbtnExportCSV.Name = "tsbtnExportCSV";
			this.tsbtnExportCSV.Size = new Size(60, 23);
			this.tsbtnExportCSV.Text = "Export";
			this.tsbtnExportCSV.Click += new EventHandler(this.tsbtnExportCSV_Click);
			this.cbText.FormattingEnabled = true;
			this.cbText.Location = new Point(165, 341);
			this.cbText.Name = "cbText";
			this.cbText.Size = new Size(121, 21);
			this.cbText.TabIndex = 2;
			this.cbText.Visible = false;
			this.cbText.Leave += new EventHandler(this.cbText_Leave);
			this.cbText.KeyPress += new KeyPressEventHandler(this.cbText_KeyPress);
			this.cbText.KeyUp += new KeyEventHandler(this.cbText_KeyUp);
			this.cbText.KeyDown += new KeyEventHandler(this.cbText_KeyDown);
			this.cbText.TextChanged += new EventHandler(this.cbText_TextChanged);
			this.intzaTradeOverview.AllowDrop = true;
			this.intzaTradeOverview.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaTradeOverview.CanDrag = false;
			this.intzaTradeOverview.Dock = DockStyle.Top;
			this.intzaTradeOverview.IsAutoRepaint = true;
			this.intzaTradeOverview.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Center;
			itemGrid.BackColor = Color.DimGray;
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.TextGradient;
			itemGrid.FontColor = Color.White;
			itemGrid.FontStyle = FontStyle.Underline;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "lbTJOverviewHeader";
			itemGrid.Text = "Trade Journal Overview";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 100;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = 0f;
			itemGrid2.Alignment = StringAlignment.Near;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Label2;
			itemGrid2.FontColor = Color.White;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "lbEquityInvest";
			itemGrid2.Text = "Equity Invested ";
			itemGrid2.ValueFormat = FormatType.Text;
			itemGrid2.Visible = true;
			itemGrid2.Width = 12;
			itemGrid2.X = 0;
			itemGrid2.Y = 1f;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Far;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = false;
			itemGrid3.FieldType = ItemType.Text;
			itemGrid3.FontColor = Color.Yellow;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "tbEquityInvest";
			itemGrid3.Text = "";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 10;
			itemGrid3.X = 12;
			itemGrid3.Y = 1f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Near;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = false;
			itemGrid4.FieldType = ItemType.Label2;
			itemGrid4.FontColor = Color.White;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "lbCurrEquity";
			itemGrid4.Text = "Current Equity";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 12;
			itemGrid4.X = 0;
			itemGrid4.Y = 2f;
			itemGrid5.AdjustFontSize = 0f;
			itemGrid5.Alignment = StringAlignment.Far;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = false;
			itemGrid5.FieldType = ItemType.Text;
			itemGrid5.FontColor = Color.Yellow;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "tbCurrEquity";
			itemGrid5.Text = "";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 10;
			itemGrid5.X = 12;
			itemGrid5.Y = 2f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Near;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Label2;
			itemGrid6.FontColor = Color.White;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "lbTotalPL";
			itemGrid6.Text = "Total Profit/Loss";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = true;
			itemGrid6.Width = 12;
			itemGrid6.X = 0;
			itemGrid6.Y = 3f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Far;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Text;
			itemGrid7.FontColor = Color.Yellow;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "tbTotalPL";
			itemGrid7.Text = "";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 10;
			itemGrid7.X = 12;
			itemGrid7.Y = 3f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Near;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Label2;
			itemGrid8.FontColor = Color.White;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "lbTotalPLPct";
			itemGrid8.Text = "Total Profit/Loss %";
			itemGrid8.ValueFormat = FormatType.Text;
			itemGrid8.Visible = true;
			itemGrid8.Width = 12;
			itemGrid8.X = 0;
			itemGrid8.Y = 4f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Far;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Text;
			itemGrid9.FontColor = Color.Yellow;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "tbTotalPLPct";
			itemGrid9.Text = "";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 10;
			itemGrid9.X = 12;
			itemGrid9.Y = 4f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Near;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Label2;
			itemGrid10.FontColor = Color.White;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "lbTotalTrade";
			itemGrid10.Text = "Total Trades";
			itemGrid10.ValueFormat = FormatType.Text;
			itemGrid10.Visible = true;
			itemGrid10.Width = 10;
			itemGrid10.X = 24;
			itemGrid10.Y = 1f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Center;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Text;
			itemGrid11.FontColor = Color.Yellow;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "tbTotalTrade";
			itemGrid11.Text = "";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 5;
			itemGrid11.X = 34;
			itemGrid11.Y = 1f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Center;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Yellow;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "tbTotalTradePct";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Text;
			itemGrid12.Visible = true;
			itemGrid12.Width = 7;
			itemGrid12.X = 39;
			itemGrid12.Y = 1f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.White;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "lbLongTrade";
			itemGrid13.Text = "Long Trades";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 10;
			itemGrid13.X = 24;
			itemGrid13.Y = 2f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Center;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Yellow;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "tbLongTrade";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Text;
			itemGrid14.Visible = true;
			itemGrid14.Width = 5;
			itemGrid14.X = 34;
			itemGrid14.Y = 2f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Center;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Text;
			itemGrid15.FontColor = Color.Yellow;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "tbLongTradePct";
			itemGrid15.Text = "";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 7;
			itemGrid15.X = 39;
			itemGrid15.Y = 2f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Near;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Label2;
			itemGrid16.FontColor = Color.White;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "lbShortTrade";
			itemGrid16.Text = "Short Trades";
			itemGrid16.ValueFormat = FormatType.Text;
			itemGrid16.Visible = true;
			itemGrid16.Width = 10;
			itemGrid16.X = 24;
			itemGrid16.Y = 3f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Center;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Text;
			itemGrid17.FontColor = Color.Yellow;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "tbShortTrade";
			itemGrid17.Text = "";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 5;
			itemGrid17.X = 34;
			itemGrid17.Y = 3f;
			itemGrid18.AdjustFontSize = 0f;
			itemGrid18.Alignment = StringAlignment.Center;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.Yellow;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "tbShortTradePct";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 7;
			itemGrid18.X = 39;
			itemGrid18.Y = 3f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = false;
			itemGrid19.FieldType = ItemType.Label2;
			itemGrid19.FontColor = Color.White;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "lbWinTrade";
			itemGrid19.Text = "Winning Trades";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 11;
			itemGrid19.X = 47;
			itemGrid19.Y = 1f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Center;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = false;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Yellow;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "tbWinTrade";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Text;
			itemGrid20.Visible = true;
			itemGrid20.Width = 5;
			itemGrid20.X = 58;
			itemGrid20.Y = 1f;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Center;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = false;
			itemGrid21.FieldType = ItemType.Text;
			itemGrid21.FontColor = Color.Yellow;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "tbWinTradePct";
			itemGrid21.Text = "";
			itemGrid21.ValueFormat = FormatType.Text;
			itemGrid21.Visible = true;
			itemGrid21.Width = 7;
			itemGrid21.X = 63;
			itemGrid21.Y = 1f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Near;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = false;
			itemGrid22.FieldType = ItemType.Label2;
			itemGrid22.FontColor = Color.White;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "lbWinLong";
			itemGrid22.Text = "Winning Long";
			itemGrid22.ValueFormat = FormatType.Text;
			itemGrid22.Visible = true;
			itemGrid22.Width = 11;
			itemGrid22.X = 47;
			itemGrid22.Y = 2f;
			itemGrid23.AdjustFontSize = 0f;
			itemGrid23.Alignment = StringAlignment.Center;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = false;
			itemGrid23.FieldType = ItemType.Text;
			itemGrid23.FontColor = Color.Yellow;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "tbWinLong";
			itemGrid23.Text = "";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = true;
			itemGrid23.Width = 5;
			itemGrid23.X = 58;
			itemGrid23.Y = 2f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Center;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = false;
			itemGrid24.FieldType = ItemType.Text;
			itemGrid24.FontColor = Color.Yellow;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "tbWinLongPct";
			itemGrid24.Text = "";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 7;
			itemGrid24.X = 63;
			itemGrid24.Y = 2f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Near;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = false;
			itemGrid25.FieldType = ItemType.Label2;
			itemGrid25.FontColor = Color.White;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "lbWinShort";
			itemGrid25.Text = "Winning Short";
			itemGrid25.ValueFormat = FormatType.Text;
			itemGrid25.Visible = true;
			itemGrid25.Width = 11;
			itemGrid25.X = 47;
			itemGrid25.Y = 3f;
			itemGrid26.AdjustFontSize = 0f;
			itemGrid26.Alignment = StringAlignment.Center;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = false;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Yellow;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "tbWinShort";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Text;
			itemGrid26.Visible = true;
			itemGrid26.Width = 5;
			itemGrid26.X = 58;
			itemGrid26.Y = 3f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Center;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = false;
			itemGrid27.FieldType = ItemType.Text;
			itemGrid27.FontColor = Color.Yellow;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "tbwinShortPct";
			itemGrid27.Text = "";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 7;
			itemGrid27.X = 63;
			itemGrid27.Y = 3f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Near;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = false;
			itemGrid28.FieldType = ItemType.Label2;
			itemGrid28.FontColor = Color.White;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "lbLoseTrade";
			itemGrid28.Text = "Losing Trades";
			itemGrid28.ValueFormat = FormatType.Text;
			itemGrid28.Visible = true;
			itemGrid28.Width = 10;
			itemGrid28.X = 71;
			itemGrid28.Y = 1f;
			itemGrid29.AdjustFontSize = 0f;
			itemGrid29.Alignment = StringAlignment.Center;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = false;
			itemGrid29.FieldType = ItemType.Text;
			itemGrid29.FontColor = Color.Yellow;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "tbLoseTrade";
			itemGrid29.Text = "";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = true;
			itemGrid29.Width = 5;
			itemGrid29.X = 81;
			itemGrid29.Y = 1f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Center;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.Yellow;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 1f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "tbLoseTradePct";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.Text;
			itemGrid30.Visible = true;
			itemGrid30.Width = 7;
			itemGrid30.X = 86;
			itemGrid30.Y = 1f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = false;
			itemGrid31.FieldType = ItemType.Label2;
			itemGrid31.FontColor = Color.White;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "lbLoseLong";
			itemGrid31.Text = "Losing Long";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 10;
			itemGrid31.X = 71;
			itemGrid31.Y = 2f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Center;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = false;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "tbLoseLong";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 5;
			itemGrid32.X = 81;
			itemGrid32.Y = 2f;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Center;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = false;
			itemGrid33.FieldType = ItemType.Text;
			itemGrid33.FontColor = Color.Yellow;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "tbLoseLongPct";
			itemGrid33.Text = "";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = true;
			itemGrid33.Width = 7;
			itemGrid33.X = 86;
			itemGrid33.Y = 2f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Near;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Label2;
			itemGrid34.FontColor = Color.White;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "lbLoseShort";
			itemGrid34.Text = "Losing Short";
			itemGrid34.ValueFormat = FormatType.Text;
			itemGrid34.Visible = true;
			itemGrid34.Width = 10;
			itemGrid34.X = 71;
			itemGrid34.Y = 3f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Center;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = false;
			itemGrid35.FieldType = ItemType.Text;
			itemGrid35.FontColor = Color.Yellow;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "tbLoseShort";
			itemGrid35.Text = "";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 5;
			itemGrid35.X = 81;
			itemGrid35.Y = 3f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Center;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.Yellow;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "tbLoseShortPct";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Text;
			itemGrid36.Visible = true;
			itemGrid36.Width = 7;
			itemGrid36.X = 86;
			itemGrid36.Y = 3f;
			this.intzaTradeOverview.Items.Add(itemGrid);
			this.intzaTradeOverview.Items.Add(itemGrid2);
			this.intzaTradeOverview.Items.Add(itemGrid3);
			this.intzaTradeOverview.Items.Add(itemGrid4);
			this.intzaTradeOverview.Items.Add(itemGrid5);
			this.intzaTradeOverview.Items.Add(itemGrid6);
			this.intzaTradeOverview.Items.Add(itemGrid7);
			this.intzaTradeOverview.Items.Add(itemGrid8);
			this.intzaTradeOverview.Items.Add(itemGrid9);
			this.intzaTradeOverview.Items.Add(itemGrid10);
			this.intzaTradeOverview.Items.Add(itemGrid11);
			this.intzaTradeOverview.Items.Add(itemGrid12);
			this.intzaTradeOverview.Items.Add(itemGrid13);
			this.intzaTradeOverview.Items.Add(itemGrid14);
			this.intzaTradeOverview.Items.Add(itemGrid15);
			this.intzaTradeOverview.Items.Add(itemGrid16);
			this.intzaTradeOverview.Items.Add(itemGrid17);
			this.intzaTradeOverview.Items.Add(itemGrid18);
			this.intzaTradeOverview.Items.Add(itemGrid19);
			this.intzaTradeOverview.Items.Add(itemGrid20);
			this.intzaTradeOverview.Items.Add(itemGrid21);
			this.intzaTradeOverview.Items.Add(itemGrid22);
			this.intzaTradeOverview.Items.Add(itemGrid23);
			this.intzaTradeOverview.Items.Add(itemGrid24);
			this.intzaTradeOverview.Items.Add(itemGrid25);
			this.intzaTradeOverview.Items.Add(itemGrid26);
			this.intzaTradeOverview.Items.Add(itemGrid27);
			this.intzaTradeOverview.Items.Add(itemGrid28);
			this.intzaTradeOverview.Items.Add(itemGrid29);
			this.intzaTradeOverview.Items.Add(itemGrid30);
			this.intzaTradeOverview.Items.Add(itemGrid31);
			this.intzaTradeOverview.Items.Add(itemGrid32);
			this.intzaTradeOverview.Items.Add(itemGrid33);
			this.intzaTradeOverview.Items.Add(itemGrid34);
			this.intzaTradeOverview.Items.Add(itemGrid35);
			this.intzaTradeOverview.Items.Add(itemGrid36);
			this.intzaTradeOverview.LineColor = Color.Red;
			this.intzaTradeOverview.Location = new Point(0, 0);
			this.intzaTradeOverview.Name = "intzaTradeOverview";
			this.intzaTradeOverview.Size = new Size(687, 62);
			this.intzaTradeOverview.TabIndex = 0;
			this.sortGrid1.AllowDrop = true;
			this.sortGrid1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sortGrid1.BackColor = Color.FromArgb(30, 30, 30);
			this.sortGrid1.CanBlink = true;
			this.sortGrid1.CanDrag = false;
			this.sortGrid1.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "dateopen";
			columnItem.Text = "Date Open";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 8;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "dateclose";
			columnItem2.Text = "Date Close";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 8;
			columnItem3.Alignment = StringAlignment.Center;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "direction";
			columnItem3.Text = "L/S";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 4;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "positionsize";
			columnItem4.Text = "Position Size";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = false;
			columnItem4.Width = 10;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "entryprice";
			columnItem5.Text = "Entry Price";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 8;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "stoploss";
			columnItem6.Text = "Stop Loss";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 8;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "takeprofit";
			columnItem7.Text = "Take Profit";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 8;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "exitprice";
			columnItem8.Text = "Exit Price";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 8;
			columnItem9.Alignment = StringAlignment.Center;
			columnItem9.BackColor = Color.Teal;
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "riskreward";
			columnItem9.Text = "Risk/Reward";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 8;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "loss";
			columnItem10.Text = "Loss";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 8;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "profit";
			columnItem11.Text = "Profit";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = true;
			columnItem11.Width = 8;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.Teal;
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "profitpct";
			columnItem12.Text = "% Profit";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = true;
			columnItem12.Width = 7;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.Teal;
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "losspct";
			columnItem13.Text = "% Loss";
			columnItem13.ValueFormat = FormatType.Text;
			columnItem13.Visible = true;
			columnItem13.Width = 7;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.Teal;
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "balance";
			columnItem14.Text = "Balance";
			columnItem14.ValueFormat = FormatType.Text;
			columnItem14.Visible = true;
			columnItem14.Width = 10;
			columnItem15.Alignment = StringAlignment.Near;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.ColumnAlignment = StringAlignment.Center;
			columnItem15.FontColor = Color.LightGray;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "tmpbalance";
			columnItem15.Text = "None";
			columnItem15.ValueFormat = FormatType.Text;
			columnItem15.Visible = false;
			columnItem15.Width = 10;
			columnItem16.Alignment = StringAlignment.Near;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.ColumnAlignment = StringAlignment.Center;
			columnItem16.FontColor = Color.LightGray;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "winloss";
			columnItem16.Text = "None";
			columnItem16.ValueFormat = FormatType.Text;
			columnItem16.Visible = false;
			columnItem16.Width = 10;
			this.sortGrid1.Columns.Add(columnItem);
			this.sortGrid1.Columns.Add(columnItem2);
			this.sortGrid1.Columns.Add(columnItem3);
			this.sortGrid1.Columns.Add(columnItem4);
			this.sortGrid1.Columns.Add(columnItem5);
			this.sortGrid1.Columns.Add(columnItem6);
			this.sortGrid1.Columns.Add(columnItem7);
			this.sortGrid1.Columns.Add(columnItem8);
			this.sortGrid1.Columns.Add(columnItem9);
			this.sortGrid1.Columns.Add(columnItem10);
			this.sortGrid1.Columns.Add(columnItem11);
			this.sortGrid1.Columns.Add(columnItem12);
			this.sortGrid1.Columns.Add(columnItem13);
			this.sortGrid1.Columns.Add(columnItem14);
			this.sortGrid1.Columns.Add(columnItem15);
			this.sortGrid1.Columns.Add(columnItem16);
			this.sortGrid1.CurrentScroll = 0;
			this.sortGrid1.FocusItemIndex = -1;
			this.sortGrid1.ForeColor = Color.Black;
			this.sortGrid1.GridColor = Color.FromArgb(45, 45, 45);
			this.sortGrid1.HeaderPctHeight = 100f;
			this.sortGrid1.IsAutoRepaint = true;
			this.sortGrid1.IsDrawFullRow = false;
			this.sortGrid1.IsDrawGrid = true;
			this.sortGrid1.IsDrawHeader = true;
			this.sortGrid1.IsScrollable = true;
			this.sortGrid1.Location = new Point(2, 64);
			this.sortGrid1.MainColumn = "";
			this.sortGrid1.Name = "sortGrid1";
			this.sortGrid1.Rows = 25;
			this.sortGrid1.RowSelectColor = Color.MediumBlue;
			this.sortGrid1.RowSelectType = 0;
			this.sortGrid1.RowsVisible = 25;
			this.sortGrid1.Size = new Size(685, 337);
			this.sortGrid1.SortColumnName = "";
			this.sortGrid1.SortType = SortType.Desc;
			this.sortGrid1.TabIndex = 28;
			this.sortGrid1.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.sortGrid1_TableMouseClick);
			this.sortGrid1.TableMouseDoubleClick += new SortGrid.TableMouseDoubleClickEventHandler(this.sortGrid1_TableMouseDoubleClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(687, 433);
			base.Controls.Add(this.tStripTJ);
			base.Controls.Add(this.cbText);
			base.Controls.Add(this.sortGrid1);
			base.Controls.Add(this.intzaTradeOverview);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmTradeJornal";
			this.Text = "frmTradeJornal";
			this.tStripTJ.ResumeLayout(false);
			this.tStripTJ.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000481 RID: 1153
		private decimal _totalTJAmount;

		// Token: 0x04000482 RID: 1154
		private DataSet _dataSetTJ;

		// Token: 0x04000483 RID: 1155
		private int lastFocus;

		// Token: 0x04000484 RID: 1156
		private bool isEditing;

		// Token: 0x04000485 RID: 1157
		private IContainer components;

		// Token: 0x04000486 RID: 1158
		private IntzaCustomGrid intzaTradeOverview;

		// Token: 0x04000487 RID: 1159
		private ToolStrip tStripTJ;

		// Token: 0x04000488 RID: 1160
		private ToolStripLabel tslbAmountText;

		// Token: 0x04000489 RID: 1161
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400048A RID: 1162
		private ToolStripButton tsbtnAmount;

		// Token: 0x0400048B RID: 1163
		private ToolStripTextBox tstxtAmount;

		// Token: 0x0400048C RID: 1164
		private ToolStripButton tsbtnExportCSV;

		// Token: 0x0400048D RID: 1165
		private ComboBox cbText;

		// Token: 0x0400048E RID: 1166
		private SortGrid sortGrid1;
	}
}
