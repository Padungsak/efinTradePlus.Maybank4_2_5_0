using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x0200002A RID: 42
	public class frmPcPriceAlert : Form
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00016F24 File Offset: 0x00015324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmPcPriceAlert() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._isLoading = true;
			this.tmCloseSplash = null;
			this.frmConfirm = null;
			this.components = null;
			
			this.InitializeComponent();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00016F70 File Offset: 0x00015370
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAlertOption_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.chkOpenAlert.Checked = ApplicationInfo.AlertOpen;
				this.chkAutoAlert.Checked = ApplicationInfo.AlertAutoPopup;
				this.chkAlertSound.Checked = ApplicationInfo.AlertSound;
				if (this.tbStockPc.AutoCompleteCustomSource != null)
				{
					if (ApplicationInfo.StockAutoComp != null)
					{
						this.tbStockPc.AutoCompleteMode = AutoCompleteMode.Suggest;
						this.tbStockPc.AutoCompleteSource = AutoCompleteSource.CustomSource;
						if (ApplicationInfo.IsSupportTfex)
						{
							this.tbStockPc.AutoCompleteCustomSource = ApplicationInfo.MultiAutoComp;
						}
						else
						{
							this.tbStockPc.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmAlertOption_Load", ex);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00017068 File Offset: 0x00015468
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAlertSetting_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.FormBorderStyle = FormBorderStyle.FixedDialog;
			}
			catch (Exception ex)
			{
				this.ShowError("frmAlertSetting_Shown", ex);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000170BC File Offset: 0x000154BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reload()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ReloadPriceAlertOnPc();
			}
			catch (Exception ex)
			{
				this.ShowError("Reload", ex);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001710C File Offset: 0x0001550C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadPriceAlertOnPc()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int num = 0;
				this.intzaPC.BeginUpdate();
				this.intzaPC.Rows = 0;
				foreach (KeyValuePair<string, AlertItemCollection> current in AlertManager.Instance.Symbols)
				{
					foreach (AlertItem current2 in current.Value)
					{
						RecordItem recordItem = this.intzaPC.AddRecord(-1, false);
						if (current2.Field == "%Change")
						{
							current2.Operator = ">=";
						}
						recordItem.Fields("stock").Text = current2.Symbol;
						recordItem.Fields("field").Text = current2.Field;
						recordItem.Fields("operator").Text = current2.Operator;
						recordItem.Fields("value").Text = current2.Value;
						if (current2.AlertTime > DateTime.MinValue)
						{
							recordItem.Fields("alert_time").Text = current2.AlertTime.ToString("HH:mm:ss");
						}
						recordItem.Fields("value_at_alert").Text = current2.ValueMessageRealtime;
						num++;
					}
				}
				this.intzaPC.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadPriceAlertOnPc", ex);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00017334 File Offset: 0x00015734
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			((Control)sender).BackColor = Color.Yellow;
			((Control)sender).ForeColor = Color.Black;
			if (sender.GetType() == typeof(TextBox))
			{
				((TextBox)sender).SelectAll();
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001739C File Offset: 0x0001579C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender.GetType() == typeof(CheckBox))
			{
				((Control)sender).BackColor = Color.Transparent;
				if (this.BackColor == Color.DarkGreen)
				{
					((Control)sender).ForeColor = Color.White;
				}
				else
				{
					((Control)sender).ForeColor = Color.Black;
				}
			}
			else
			{
				((Control)sender).BackColor = Color.White;
				((Control)sender).ForeColor = Color.Black;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00017454 File Offset: 0x00015854
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00017488 File Offset: 0x00015888
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.AlertAutoPopup = this.chkAutoAlert.Checked;
				ApplicationInfo.AlertSound = this.chkAlertSound.Checked;
				ApplicationInfo.AlertOpen = this.chkOpenAlert.Checked;
				base.Hide();
			}
			catch (Exception ex)
			{
				this.ShowError("btnClose_Click", ex);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00017508 File Offset: 0x00015908
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00017534 File Offset: 0x00015934
		public bool IsLoadingData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._isLoading;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (!base.DesignMode)
				{
					this._isLoading = value;
					this.ShowSplash(this._isLoading, "Loading...", false);
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001757C File Offset: 0x0001597C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible, string message, bool isAutoClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPcPriceAlert.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible,
					message,
					isAutoClose
				});
			}
			else
			{
				try
				{
					if (this.tmCloseSplash == null)
					{
						this.tmCloseSplash = new Timer();
						this.tmCloseSplash.Interval = 1500;
						this.tmCloseSplash.Tick += new EventHandler(this.tmCloseSplash_Tick);
					}
					if (visible)
					{
						this.lbLoading.Text = message;
						this.lbLoading.Left = (base.Width - this.lbLoading.Width) / 2;
						this.lbLoading.Top = (base.Height - this.lbLoading.Height) / 2;
						this.lbLoading.Visible = true;
						this.lbLoading.BringToFront();
						this.tmCloseSplash.Enabled = false;
						if (isAutoClose)
						{
							this.tmCloseSplash.Enabled = true;
						}
					}
					else
					{
						this.lbLoading.Visible = false;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ShowSplash", ex);
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00017704 File Offset: 0x00015B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmCloseSplash_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tmCloseSplash.Enabled = false;
			this.ShowSplash(false, "", false);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00017730 File Offset: 0x00015B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPCupdate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal d = 0m;
				if (!decimal.TryParse(this.tbValuePc.Text, out d))
				{
					this.ShowMessage("Invalid value!");
					this.tbValuePc.Focus();
				}
				else
				{
					string text = this.tbStockPc.Text.Trim().ToUpper();
					string text2 = this.cbFieldPc.Text;
					string text3 = this.cbOperatorPc.Text;
					bool flag;
					if (text != string.Empty)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[text];
						if (stockInformation.Number > 0)
						{
							flag = true;
						}
						else if (ApplicationInfo.IsSupportTfex)
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[text.ToUpper()];
							flag = !string.IsNullOrEmpty(seriesInformation.Symbol);
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
					if (flag)
					{
						int num = -1;
						RecordItem recordItem;
						for (int i = 0; i < this.intzaPC.Rows; i++)
						{
							recordItem = this.intzaPC.Records(i);
							if (recordItem.Fields("stock").Text.ToString() == text && recordItem.Fields("field").Text.ToString() == text2 && recordItem.Fields("operator").Text.ToString() == text3)
							{
								num = i;
								break;
							}
						}
						if (num > -1)
						{
							recordItem = this.intzaPC.Records(num);
						}
						else
						{
							recordItem = this.intzaPC.AddRecord(-1, false);
						}
						recordItem.Fields("stock").Text = text;
						recordItem.Fields("field").Text = text2;
						recordItem.Fields("operator").Text = text3;
						recordItem.Fields("value").Text = d.ToString();
						recordItem.Fields("alert_time").Text = "";
						recordItem.Fields("value_at_alert").Text = "";
						this.intzaPC.Redraw();
						AlertItem alertItem = null;
						if (!AlertManager.Instance.Symbols.ContainsKey(text))
						{
							AlertManager.Instance.Symbols.Add(text, new AlertItemCollection());
						}
						else
						{
							foreach (AlertItem current in AlertManager.Instance.Symbols[text])
							{
								if (current.Field == text2 && current.Operator == text3)
								{
									alertItem = current;
									break;
								}
							}
						}
						if (alertItem == null)
						{
							alertItem = new AlertItem();
							alertItem.Symbol = text;
							alertItem.Field = text2;
							if (text2 == "%Change")
							{
								if (d > 0m)
								{
									text3 = ">=";
								}
								else
								{
									text3 = "<=";
								}
							}
							alertItem.Operator = text3;
							AlertManager.Instance.Symbols[alertItem.Symbol].Add(alertItem);
						}
						alertItem.Value = d.ToString();
						alertItem.IsReaded = false;
						alertItem.AlertTime = DateTime.MinValue;
						alertItem.ValueMessageRealtime = string.Empty;
					}
					else
					{
						this.ShowMessage("Invalid Stock!");
						this.tbStockPc.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnAlertAdd_Click", ex);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00017BF0 File Offset: 0x00015FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaPC_TableFocusIndexChanged(object sender, int Index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (Index > -1 && Index < this.intzaPC.Rows)
				{
					RecordItem recordItem = this.intzaPC.Records(Index);
					this.tbStockPc.Text = recordItem.Fields("stock").Text.ToString();
					this.cbFieldPc.Text = recordItem.Fields("field").Text.ToString();
					this.cbOperatorPc.Text = recordItem.Fields("operator").Text.ToString();
					this.tbValuePc.Text = recordItem.Fields("value").Text.ToString();
					this.tbStockPc.Focus();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaM_TableFocusIndexChanged", ex);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00017D00 File Offset: 0x00016100
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPCremove_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaPC.Rows > 0 && this.intzaPC.FocusItemIndex > -1)
				{
					string key = this.intzaPC.Records(this.intzaPC.FocusItemIndex).Fields("stock").Text.ToString();
					string b = this.intzaPC.Records(this.intzaPC.FocusItemIndex).Fields("field").Text.ToString();
					string b2 = this.intzaPC.Records(this.intzaPC.FocusItemIndex).Fields("operator").Text.ToString();
					lock (((ICollection)AlertManager.Instance.Symbols).SyncRoot)
					{
						AlertItem alertItem = null;
						foreach (AlertItem current in AlertManager.Instance.Symbols[key])
						{
							if (current.Field == b && current.Operator == b2)
							{
								alertItem = current;
								break;
							}
						}
						if (alertItem != null)
						{
							AlertManager.Instance.Symbols[key].Remove(alertItem);
						}
					}
					this.intzaPC.DeleteRecord(this.intzaPC.FocusItemIndex);
					this.intzaPC.Redraw();
				}
				if (this.intzaPC.Rows == 0)
				{
					this.tbStockPc.Text = "";
					this.tbValuePc.Text = "";
					this.tbStockPc.Focus();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnPCremove_Click", ex);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00017F80 File Offset: 0x00016380
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPCremoveAll_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				lock (((ICollection)AlertManager.Instance.Symbols).SyncRoot)
				{
					AlertManager.Instance.Symbols.Clear();
				}
				this.intzaPC.Rows = 0;
				this.intzaPC.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("btnPCremoveAll_Click", ex);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00018024 File Offset: 0x00016424
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPCstock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return || keyCode == Keys.Right)
			{
				this.cbFieldPc.Focus();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00018078 File Offset: 0x00016478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPCfield_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.tbStockPc.Focus();
					e.SuppressKeyPress = true;
					return;
				case Keys.Up:
					return;
				case Keys.Right:
					break;
				default:
					return;
				}
			}
			this.cbOperatorPc.Focus();
			e.SuppressKeyPress = true;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000180F0 File Offset: 0x000164F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPCoperator_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.cbFieldPc.Focus();
					e.SuppressKeyPress = true;
					return;
				case Keys.Up:
					return;
				case Keys.Right:
					break;
				default:
					return;
				}
			}
			this.tbValuePc.Focus();
			e.SuppressKeyPress = true;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00018168 File Offset: 0x00016568
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPCvalue_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				if (keyCode == Keys.Left)
				{
					this.cbOperatorPc.Focus();
					e.SuppressKeyPress = true;
				}
			}
			else
			{
				this.btnUpdatePc.PerformClick();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000181D4 File Offset: 0x000165D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbFieldPc_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.cbFieldPc.Text == "%Change")
			{
				this.cbOperatorPc.Text = ">=";
				this.cbOperatorPc.Enabled = false;
			}
			else
			{
				this.cbOperatorPc.Enabled = true;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00018244 File Offset: 0x00016644
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnReloadPc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadPriceAlertOnPc();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001825C File Offset: 0x0001665C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessage(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPcPriceAlert.ShowMessageCallBack(this.ShowMessage), new object[]
				{
					message
				});
			}
			else
			{
				try
				{
					if (this.frmConfirm != null)
					{
						if (!this.frmConfirm.IsDisposed)
						{
							this.frmConfirm.Dispose();
						}
						this.frmConfirm = null;
					}
					this.frmConfirm = new frmOrderFormConfirm(message, "", frmOrderFormConfirm.OpenStyle.ShowBox);
					this.frmConfirm.TopLevel = false;
					this.frmConfirm.Parent = this;
					this.frmConfirm.Location = new Point((base.Width - this.frmConfirm.Width) / 2, (base.Height - this.frmConfirm.Height) / 2);
					this.frmConfirm.TopMost = true;
					this.frmConfirm.Show();
					this.frmConfirm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowMessageInFormConfirm", ex);
				}
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000183A0 File Offset: 0x000167A0
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

		// Token: 0x06000197 RID: 407 RVA: 0x000183F0 File Offset: 0x000167F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
			ColumnItem columnItem5 = new ColumnItem();
			ColumnItem columnItem6 = new ColumnItem();
			this.chkAlertSound = new CheckBox();
			this.chkOpenAlert = new CheckBox();
			this.chkAutoAlert = new CheckBox();
			this.btnClose = new Button();
			this.lbLoading = new Label();
			this.toolTip1 = new ToolTip(this.components);
			this.panelPricAlertPC = new Panel();
			this.btnRemovePc = new Button();
			this.btnRemoveAllPc = new Button();
			this.btnReloadPc = new Button();
			this.tbStockPc = new TextBox();
			this.btnUpdatePc = new Button();
			this.lbStock = new Label();
			this.lbValue = new Label();
			this.lbOper = new Label();
			this.lbField = new Label();
			this.cbFieldPc = new ComboBox();
			this.tbValuePc = new TextBox();
			this.cbOperatorPc = new ComboBox();
			this.intzaPC = new SortGrid();
			this.panelPricAlertPC.SuspendLayout();
			base.SuspendLayout();
			this.chkAlertSound.AutoSize = true;
			this.chkAlertSound.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.chkAlertSound.ImageAlign = ContentAlignment.MiddleRight;
			this.chkAlertSound.Location = new Point(98, 7);
			this.chkAlertSound.Margin = new Padding(3, 2, 3, 2);
			this.chkAlertSound.Name = "chkAlertSound";
			this.chkAlertSound.Size = new Size(94, 20);
			this.chkAlertSound.TabIndex = 2;
			this.chkAlertSound.Text = "Sound Alert";
			this.chkAlertSound.UseVisualStyleBackColor = true;
			this.chkOpenAlert.AutoSize = true;
			this.chkOpenAlert.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.chkOpenAlert.ImageAlign = ContentAlignment.MiddleRight;
			this.chkOpenAlert.Location = new Point(12, 7);
			this.chkOpenAlert.Margin = new Padding(3, 2, 3, 2);
			this.chkOpenAlert.Name = "chkOpenAlert";
			this.chkOpenAlert.Size = new Size(65, 20);
			this.chkOpenAlert.TabIndex = 0;
			this.chkOpenAlert.Text = "Enable";
			this.chkOpenAlert.UseVisualStyleBackColor = true;
			this.chkAutoAlert.AutoSize = true;
			this.chkAutoAlert.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.chkAutoAlert.ImageAlign = ContentAlignment.MiddleRight;
			this.chkAutoAlert.Location = new Point(220, 7);
			this.chkAutoAlert.Margin = new Padding(3, 2, 3, 2);
			this.chkAutoAlert.Name = "chkAutoAlert";
			this.chkAutoAlert.Size = new Size(92, 20);
			this.chkAutoAlert.TabIndex = 1;
			this.chkAutoAlert.Text = "Auto Popup";
			this.chkAutoAlert.UseVisualStyleBackColor = true;
			this.btnClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnClose.AutoSize = true;
			this.btnClose.FlatAppearance.BorderColor = Color.Gray;
			this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClose.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
			this.btnClose.FlatStyle = FlatStyle.Flat;
			this.btnClose.Location = new Point(532, 391);
			this.btnClose.Margin = new Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(79, 33);
			this.btnClose.TabIndex = 92;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(250, 394);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(5, 4, 5, 4);
			this.lbLoading.Size = new Size(73, 25);
			this.lbLoading.TabIndex = 98;
			this.lbLoading.Text = "Loading...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.panelPricAlertPC.AutoSize = true;
			this.panelPricAlertPC.BackColor = SystemColors.ControlLight;
			this.panelPricAlertPC.Controls.Add(this.btnRemovePc);
			this.panelPricAlertPC.Controls.Add(this.btnRemoveAllPc);
			this.panelPricAlertPC.Controls.Add(this.btnReloadPc);
			this.panelPricAlertPC.Location = new Point(12, 36);
			this.panelPricAlertPC.Name = "panelPricAlertPC";
			this.panelPricAlertPC.Size = new Size(600, 40);
			this.panelPricAlertPC.TabIndex = 111;
			this.btnRemovePc.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRemovePc.AutoSize = true;
			this.btnRemovePc.FlatAppearance.BorderColor = Color.Gray;
			this.btnRemovePc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRemovePc.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
			this.btnRemovePc.FlatStyle = FlatStyle.Flat;
			this.btnRemovePc.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnRemovePc.Location = new Point(402, 5);
			this.btnRemovePc.Margin = new Padding(3, 2, 3, 2);
			this.btnRemovePc.Name = "btnRemovePc";
			this.btnRemovePc.Size = new Size(82, 33);
			this.btnRemovePc.TabIndex = 110;
			this.btnRemovePc.Text = "Remove";
			this.btnRemovePc.UseVisualStyleBackColor = true;
			this.btnRemovePc.Click += new EventHandler(this.btnPCremove_Click);
			this.btnRemoveAllPc.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRemoveAllPc.AutoSize = true;
			this.btnRemoveAllPc.FlatAppearance.BorderColor = Color.Gray;
			this.btnRemoveAllPc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRemoveAllPc.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
			this.btnRemoveAllPc.FlatStyle = FlatStyle.Flat;
			this.btnRemoveAllPc.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnRemoveAllPc.Location = new Point(490, 5);
			this.btnRemoveAllPc.Margin = new Padding(3, 2, 3, 2);
			this.btnRemoveAllPc.Name = "btnRemoveAllPc";
			this.btnRemoveAllPc.Size = new Size(106, 33);
			this.btnRemoveAllPc.TabIndex = 97;
			this.btnRemoveAllPc.Text = "Remove All";
			this.btnRemoveAllPc.UseVisualStyleBackColor = true;
			this.btnRemoveAllPc.Click += new EventHandler(this.btnPCremoveAll_Click);
			this.btnReloadPc.AutoSize = true;
			this.btnReloadPc.FlatAppearance.BorderColor = Color.Gray;
			this.btnReloadPc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnReloadPc.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
			this.btnReloadPc.FlatStyle = FlatStyle.Flat;
			this.btnReloadPc.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnReloadPc.Location = new Point(9, 5);
			this.btnReloadPc.Margin = new Padding(3, 2, 3, 2);
			this.btnReloadPc.Name = "btnReloadPc";
			this.btnReloadPc.Size = new Size(73, 33);
			this.btnReloadPc.TabIndex = 95;
			this.btnReloadPc.Text = "Reload";
			this.btnReloadPc.UseVisualStyleBackColor = true;
			this.btnReloadPc.Click += new EventHandler(this.btnReloadPc_Click);
			this.tbStockPc.AllowDrop = true;
			this.tbStockPc.BorderStyle = BorderStyle.FixedSingle;
			this.tbStockPc.CharacterCasing = CharacterCasing.Upper;
			this.tbStockPc.Location = new Point(14, 365);
			this.tbStockPc.Margin = new Padding(3, 2, 3, 2);
			this.tbStockPc.MaxLength = 9;
			this.tbStockPc.Name = "tbStockPc";
			this.tbStockPc.Size = new Size(106, 23);
			this.tbStockPc.TabIndex = 109;
			this.tbStockPc.KeyDown += new KeyEventHandler(this.tbPCstock_KeyDown);
			this.tbStockPc.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbStockPc.Enter += new EventHandler(this.controlOrder_Enter);
			this.btnUpdatePc.AutoSize = true;
			this.btnUpdatePc.FlatAppearance.BorderColor = Color.Gray;
			this.btnUpdatePc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnUpdatePc.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
			this.btnUpdatePc.FlatStyle = FlatStyle.Flat;
			this.btnUpdatePc.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnUpdatePc.Location = new Point(420, 362);
			this.btnUpdatePc.Margin = new Padding(3, 2, 3, 2);
			this.btnUpdatePc.Name = "btnUpdatePc";
			this.btnUpdatePc.Size = new Size(75, 33);
			this.btnUpdatePc.TabIndex = 107;
			this.btnUpdatePc.Text = "Update";
			this.btnUpdatePc.UseVisualStyleBackColor = true;
			this.btnUpdatePc.Click += new EventHandler(this.btnPCupdate_Click);
			this.lbStock.AutoSize = true;
			this.lbStock.Location = new Point(46, 338);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new Size(50, 16);
			this.lbStock.TabIndex = 103;
			this.lbStock.Text = "Symbol";
			this.lbValue.AutoSize = true;
			this.lbValue.Location = new Point(326, 338);
			this.lbValue.Name = "lbValue";
			this.lbValue.Size = new Size(40, 16);
			this.lbValue.TabIndex = 106;
			this.lbValue.Text = "Value";
			this.lbOper.AutoSize = true;
			this.lbOper.Location = new Point(231, 338);
			this.lbOper.Name = "lbOper";
			this.lbOper.Size = new Size(59, 16);
			this.lbOper.TabIndex = 105;
			this.lbOper.Text = "Operator";
			this.lbField.AutoSize = true;
			this.lbField.Location = new Point(152, 338);
			this.lbField.Name = "lbField";
			this.lbField.Size = new Size(35, 16);
			this.lbField.TabIndex = 104;
			this.lbField.Text = "Field";
			this.cbFieldPc.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbFieldPc.FlatStyle = FlatStyle.Flat;
			this.cbFieldPc.FormattingEnabled = true;
			this.cbFieldPc.Items.AddRange(new object[]
			{
				"LastPrice",
				"%Change"
			});
			this.cbFieldPc.Location = new Point(124, 365);
			this.cbFieldPc.Margin = new Padding(3, 2, 3, 2);
			this.cbFieldPc.Name = "cbFieldPc";
			this.cbFieldPc.Size = new Size(99, 24);
			this.cbFieldPc.TabIndex = 100;
			this.cbFieldPc.SelectedIndexChanged += new EventHandler(this.cbFieldPc_SelectedIndexChanged);
			this.cbFieldPc.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbFieldPc.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbFieldPc.KeyDown += new KeyEventHandler(this.cbPCfield_KeyDown);
			this.tbValuePc.AllowDrop = true;
			this.tbValuePc.BorderStyle = BorderStyle.FixedSingle;
			this.tbValuePc.Location = new Point(299, 365);
			this.tbValuePc.Margin = new Padding(3, 2, 3, 2);
			this.tbValuePc.MaxLength = 9;
			this.tbValuePc.Name = "tbValuePc";
			this.tbValuePc.Size = new Size(106, 23);
			this.tbValuePc.TabIndex = 102;
			this.tbValuePc.KeyDown += new KeyEventHandler(this.tbPCvalue_KeyDown);
			this.tbValuePc.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbValuePc.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbOperatorPc.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbOperatorPc.FlatStyle = FlatStyle.Flat;
			this.cbOperatorPc.FormattingEnabled = true;
			this.cbOperatorPc.Items.AddRange(new object[]
			{
				">=",
				"<="
			});
			this.cbOperatorPc.Location = new Point(232, 365);
			this.cbOperatorPc.Margin = new Padding(3, 2, 3, 2);
			this.cbOperatorPc.Name = "cbOperatorPc";
			this.cbOperatorPc.Size = new Size(60, 24);
			this.cbOperatorPc.TabIndex = 101;
			this.cbOperatorPc.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbOperatorPc.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbOperatorPc.KeyDown += new KeyEventHandler(this.cbPCoperator_KeyDown);
			this.intzaPC.AllowDrop = true;
			this.intzaPC.BackColor = Color.FromArgb(20, 20, 20);
			this.intzaPC.CanBlink = false;
			this.intzaPC.CanDrag = false;
			this.intzaPC.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "stock";
			columnItem.Text = "Symbol";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 20;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "field";
			columnItem2.Text = "Field";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 15;
			columnItem3.Alignment = StringAlignment.Center;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "operator";
			columnItem3.Text = "Operator";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 15;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "value";
			columnItem4.Text = "Value";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 15;
			columnItem5.Alignment = StringAlignment.Center;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.FromArgb(255, 128, 0);
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "alert_time";
			columnItem5.Text = "Alert Time";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 18;
			columnItem6.Alignment = StringAlignment.Center;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.FromArgb(255, 128, 0);
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "value_at_alert";
			columnItem6.Text = "Alert Price";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 17;
			this.intzaPC.Columns.Add(columnItem);
			this.intzaPC.Columns.Add(columnItem2);
			this.intzaPC.Columns.Add(columnItem3);
			this.intzaPC.Columns.Add(columnItem4);
			this.intzaPC.Columns.Add(columnItem5);
			this.intzaPC.Columns.Add(columnItem6);
			this.intzaPC.CurrentScroll = 0;
			this.intzaPC.FocusItemIndex = -1;
			this.intzaPC.ForeColor = Color.Black;
			this.intzaPC.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaPC.HeaderPctHeight = 100f;
			this.intzaPC.IsAutoRepaint = true;
			this.intzaPC.IsDrawFullRow = false;
			this.intzaPC.IsDrawGrid = true;
			this.intzaPC.IsDrawHeader = true;
			this.intzaPC.IsScrollable = true;
			this.intzaPC.Location = new Point(12, 77);
			this.intzaPC.MainColumn = "";
			this.intzaPC.Margin = new Padding(3, 2, 3, 2);
			this.intzaPC.Name = "intzaPC";
			this.intzaPC.Rows = 0;
			this.intzaPC.RowSelectColor = Color.CadetBlue;
			this.intzaPC.RowSelectType = 3;
			this.intzaPC.RowsVisible = 0;
			this.intzaPC.Size = new Size(600, 254);
			this.intzaPC.SortColumnName = "";
			this.intzaPC.SortType = SortType.Desc;
			this.intzaPC.TabIndex = 92;
			this.intzaPC.TableFocusIndexChanged += new SortGrid.TableFocusIndexChangedEventHandler(this.intzaPC_TableFocusIndexChanged);
			this.AllowDrop = true;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(623, 430);
			base.ControlBox = false;
			base.Controls.Add(this.tbStockPc);
			base.Controls.Add(this.panelPricAlertPC);
			base.Controls.Add(this.btnUpdatePc);
			base.Controls.Add(this.lbStock);
			base.Controls.Add(this.lbValue);
			base.Controls.Add(this.lbLoading);
			base.Controls.Add(this.lbOper);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lbField);
			base.Controls.Add(this.chkOpenAlert);
			base.Controls.Add(this.cbFieldPc);
			base.Controls.Add(this.chkAutoAlert);
			base.Controls.Add(this.tbValuePc);
			base.Controls.Add(this.chkAlertSound);
			base.Controls.Add(this.cbOperatorPc);
			base.Controls.Add(this.intzaPC);
			this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.Margin = new Padding(3, 2, 3, 2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmPcPriceAlert";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Price Alert on PC";
			base.Load += new EventHandler(this.frmAlertOption_Load);
			base.Shown += new EventHandler(this.frmAlertSetting_Shown);
			this.panelPricAlertPC.ResumeLayout(false);
			this.panelPricAlertPC.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000CA RID: 202
		private bool _isLoading;

		// Token: 0x040000CB RID: 203
		private Timer tmCloseSplash;

		// Token: 0x040000CC RID: 204
		private frmOrderFormConfirm frmConfirm;

		// Token: 0x040000CD RID: 205
		private IContainer components;

		// Token: 0x040000CE RID: 206
		private CheckBox chkOpenAlert;

		// Token: 0x040000CF RID: 207
		private CheckBox chkAlertSound;

		// Token: 0x040000D0 RID: 208
		private CheckBox chkAutoAlert;

		// Token: 0x040000D1 RID: 209
		private Button btnClose;

		// Token: 0x040000D2 RID: 210
		private Label lbLoading;

		// Token: 0x040000D3 RID: 211
		private ToolTip toolTip1;

		// Token: 0x040000D4 RID: 212
		private TextBox tbStockPc;

		// Token: 0x040000D5 RID: 213
		private Button btnUpdatePc;

		// Token: 0x040000D6 RID: 214
		private Label lbStock;

		// Token: 0x040000D7 RID: 215
		private Label lbValue;

		// Token: 0x040000D8 RID: 216
		private Label lbOper;

		// Token: 0x040000D9 RID: 217
		private Label lbField;

		// Token: 0x040000DA RID: 218
		private ComboBox cbFieldPc;

		// Token: 0x040000DB RID: 219
		private TextBox tbValuePc;

		// Token: 0x040000DC RID: 220
		private ComboBox cbOperatorPc;

		// Token: 0x040000DD RID: 221
		private SortGrid intzaPC;

		// Token: 0x040000DE RID: 222
		private Button btnRemovePc;

		// Token: 0x040000DF RID: 223
		private Panel panelPricAlertPC;

		// Token: 0x040000E0 RID: 224
		private Button btnRemoveAllPc;

		// Token: 0x040000E1 RID: 225
		private Button btnReloadPc;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000199 RID: 409
		private delegate void ShowSplashCallBack(bool visible, string message, bool isAutoClose);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600019D RID: 413
		private delegate void ShowMessageCallBack(string message);
	}
}
