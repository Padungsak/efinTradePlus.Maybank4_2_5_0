using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;

namespace i2TradePlus
{
	// Token: 0x020000BB RID: 187
	public class frmEditOrder : Form
	{
		// Token: 0x060008A0 RID: 2208 RVA: 0x000A9D44 File Offset: 0x000A8144
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

		// Token: 0x060008A1 RID: 2209 RVA: 0x000A9D94 File Offset: 0x000A8194
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.btnClose = new Button();
			this.lbSide = new Label();
			this.btnSendOrder = new Button();
			this.lbPublic = new Label();
			this.lbPrice = new Label();
			this.tbVolume = new TextBox();
			this.lbStock = new Label();
			this.tbSide = new TextBox();
			this.lbVolume = new Label();
			this.chbNVDR = new CheckBox();
			this.tbPublic = new TextBox();
			this.tbStock = new TextBox();
			this.lbLoading = new Label();
			this.cbPrice = new ComboBox();
			this.label1 = new Label();
			this.tbOrderNo = new TextBox();
			base.SuspendLayout();
			this.btnClose.BackColor = SystemColors.Control;
			this.btnClose.FlatAppearance.BorderColor = Color.Gray;
			this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClose.FlatAppearance.MouseOverBackColor = Color.Turquoise;
			this.btnClose.FlatStyle = FlatStyle.Flat;
			this.btnClose.ForeColor = Color.Black;
			this.btnClose.Location = new Point(486, 19);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(50, 21);
			this.btnClose.TabIndex = 95;
			this.btnClose.Text = "Cancel";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.lbSide.AutoSize = true;
			this.lbSide.ForeColor = Color.Black;
			this.lbSide.Location = new Point(78, 5);
			this.lbSide.Margin = new Padding(2, 0, 2, 0);
			this.lbSide.Name = "lbSide";
			this.lbSide.Size = new Size(28, 13);
			this.lbSide.TabIndex = 90;
			this.lbSide.Text = "Side";
			this.lbSide.TextAlign = ContentAlignment.MiddleLeft;
			this.btnSendOrder.BackColor = Color.WhiteSmoke;
			this.btnSendOrder.FlatAppearance.BorderColor = Color.Gray;
			this.btnSendOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSendOrder.FlatAppearance.MouseOverBackColor = Color.Turquoise;
			this.btnSendOrder.FlatStyle = FlatStyle.Flat;
			this.btnSendOrder.ForeColor = Color.Black;
			this.btnSendOrder.Location = new Point(432, 19);
			this.btnSendOrder.Margin = new Padding(1, 3, 1, 3);
			this.btnSendOrder.MaximumSize = new Size(58, 23);
			this.btnSendOrder.Name = "btnSendOrder";
			this.btnSendOrder.Size = new Size(52, 22);
			this.btnSendOrder.TabIndex = 93;
			this.btnSendOrder.TabStop = false;
			this.btnSendOrder.Text = "Confirm";
			this.btnSendOrder.UseVisualStyleBackColor = false;
			this.btnSendOrder.Click += new EventHandler(this.btnSendOrder_Click);
			this.lbPublic.AutoSize = true;
			this.lbPublic.ForeColor = Color.Black;
			this.lbPublic.Location = new Point(372, 5);
			this.lbPublic.Margin = new Padding(2, 0, 2, 0);
			this.lbPublic.Name = "lbPublic";
			this.lbPublic.Size = new Size(44, 13);
			this.lbPublic.TabIndex = 91;
			this.lbPublic.Text = "P/B Vol";
			this.lbPublic.TextAlign = ContentAlignment.MiddleLeft;
			this.lbPrice.AutoSize = true;
			this.lbPrice.ForeColor = Color.Black;
			this.lbPrice.Location = new Point(311, 5);
			this.lbPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new Size(31, 13);
			this.lbPrice.TabIndex = 89;
			this.lbPrice.Text = "Price";
			this.lbPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.tbVolume.AllowDrop = true;
			this.tbVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbVolume.Location = new Point(237, 21);
			this.tbVolume.Margin = new Padding(2, 3, 2, 3);
			this.tbVolume.MaxLength = 10;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new Size(60, 20);
			this.tbVolume.TabIndex = 83;
			this.tbVolume.TextChanged += new EventHandler(this.tbVolume_TextChanged);
			this.tbVolume.KeyDown += new KeyEventHandler(this.tbVolume_KeyDown);
			this.tbVolume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbVolume.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbStock.AutoSize = true;
			this.lbStock.ForeColor = Color.Black;
			this.lbStock.Location = new Point(110, 5);
			this.lbStock.Margin = new Padding(2, 0, 2, 0);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new Size(35, 13);
			this.lbStock.TabIndex = 87;
			this.lbStock.Text = "Stock";
			this.lbStock.TextAlign = ContentAlignment.MiddleLeft;
			this.tbSide.AllowDrop = true;
			this.tbSide.BorderStyle = BorderStyle.FixedSingle;
			this.tbSide.CharacterCasing = CharacterCasing.Upper;
			this.tbSide.Location = new Point(79, 21);
			this.tbSide.Margin = new Padding(2, 3, 2, 3);
			this.tbSide.MaxLength = 1;
			this.tbSide.Name = "tbSide";
			this.tbSide.ReadOnly = true;
			this.tbSide.Size = new Size(24, 20);
			this.tbSide.TabIndex = 80;
			this.tbSide.TabStop = false;
			this.tbSide.TextAlign = HorizontalAlignment.Center;
			this.lbVolume.AutoSize = true;
			this.lbVolume.ForeColor = Color.Black;
			this.lbVolume.Location = new Point(246, 5);
			this.lbVolume.Margin = new Padding(2, 0, 2, 0);
			this.lbVolume.Name = "lbVolume";
			this.lbVolume.Size = new Size(42, 13);
			this.lbVolume.TabIndex = 88;
			this.lbVolume.Text = "Volume";
			this.lbVolume.TextAlign = ContentAlignment.MiddleLeft;
			this.chbNVDR.AutoSize = true;
			this.chbNVDR.ForeColor = Color.Black;
			this.chbNVDR.Location = new Point(176, 24);
			this.chbNVDR.Margin = new Padding(2, 3, 0, 3);
			this.chbNVDR.Name = "chbNVDR";
			this.chbNVDR.Size = new Size(57, 17);
			this.chbNVDR.TabIndex = 82;
			this.chbNVDR.Text = "NVDR";
			this.chbNVDR.UseVisualStyleBackColor = false;
			this.tbPublic.AllowDrop = true;
			this.tbPublic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPublic.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPublic.BorderStyle = BorderStyle.FixedSingle;
			this.tbPublic.CharacterCasing = CharacterCasing.Upper;
			this.tbPublic.Location = new Point(364, 21);
			this.tbPublic.Margin = new Padding(2, 3, 2, 3);
			this.tbPublic.MaxLength = 10;
			this.tbPublic.Name = "tbPublic";
			this.tbPublic.Size = new Size(60, 20);
			this.tbPublic.TabIndex = 85;
			this.tbPublic.TextChanged += new EventHandler(this.tbPublic_TextChanged);
			this.tbPublic.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbPublic.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbStock.AllowDrop = true;
			this.tbStock.BorderStyle = BorderStyle.FixedSingle;
			this.tbStock.CharacterCasing = CharacterCasing.Upper;
			this.tbStock.Location = new Point(107, 21);
			this.tbStock.Margin = new Padding(2, 3, 2, 3);
			this.tbStock.MaxLength = 10;
			this.tbStock.Name = "tbStock";
			this.tbStock.ReadOnly = true;
			this.tbStock.Size = new Size(66, 20);
			this.tbStock.TabIndex = 81;
			this.tbStock.TabStop = false;
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(108, 46);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(4, 3, 4, 3);
			this.lbLoading.Size = new Size(158, 23);
			this.lbLoading.TabIndex = 98;
			this.lbLoading.Text = "Sending New Order ...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.cbPrice.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbPrice.AutoCompleteMode = AutoCompleteMode.Append;
			this.cbPrice.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.cbPrice.FlatStyle = FlatStyle.Popup;
			this.cbPrice.ForeColor = Color.Black;
			this.cbPrice.FormattingEnabled = true;
			this.cbPrice.Items.AddRange(new object[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cbPrice.Location = new Point(301, 21);
			this.cbPrice.Name = "cbPrice";
			this.cbPrice.Size = new Size(59, 21);
			this.cbPrice.TabIndex = 99;
			this.cbPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbPrice.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.cbPrice.KeyDown += new KeyEventHandler(this.cbPrice_KeyDown);
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.Black;
			this.label1.Location = new Point(13, 5);
			this.label1.Margin = new Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(47, 13);
			this.label1.TabIndex = 101;
			this.label1.Text = "OrderNo";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.tbOrderNo.AllowDrop = true;
			this.tbOrderNo.BorderStyle = BorderStyle.FixedSingle;
			this.tbOrderNo.CharacterCasing = CharacterCasing.Upper;
			this.tbOrderNo.Location = new Point(3, 21);
			this.tbOrderNo.Margin = new Padding(2, 3, 2, 3);
			this.tbOrderNo.MaxLength = 1;
			this.tbOrderNo.Name = "tbOrderNo";
			this.tbOrderNo.ReadOnly = true;
			this.tbOrderNo.Size = new Size(73, 20);
			this.tbOrderNo.TabIndex = 100;
			this.tbOrderNo.TabStop = false;
			this.tbOrderNo.TextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.LightGray;
			base.ClientSize = new Size(545, 45);
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.Controls.Add(this.tbOrderNo);
			base.Controls.Add(this.cbPrice);
			base.Controls.Add(this.lbLoading);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lbSide);
			base.Controls.Add(this.btnSendOrder);
			base.Controls.Add(this.lbPublic);
			base.Controls.Add(this.lbPrice);
			base.Controls.Add(this.tbVolume);
			base.Controls.Add(this.lbStock);
			base.Controls.Add(this.tbSide);
			base.Controls.Add(this.lbVolume);
			base.Controls.Add(this.chbNVDR);
			base.Controls.Add(this.tbPublic);
			base.Controls.Add(this.tbStock);
			base.FormBorderStyle = FormBorderStyle.None;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.Name = "frmEditOrder";
			this.Text = "-";
			base.Paint += new PaintEventHandler(this.frmEditOrder_Paint);
			base.Shown += new EventHandler(this.frmEditOrder_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000AAD24 File Offset: 0x000A9124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmEditOrder(frmEditOrder.OrderEditRecord recordData) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._price = string.Empty;
			this._verifyResult_Pin = false;
			this._verifyResultStr_Pin = string.Empty;
			this._frmConfirm = null;
			this.bgw = null;
			this._sendResult = false;
			this._sendResultMessage = string.Empty;
			this._isLockPubVol = false;
			
			this.InitializeComponent();
			this._record = recordData;
			this.SetResize();
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000AADB0 File Offset: 0x000A91B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmEditOrder_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Color foreColor = Color.White;
				string side = this._record.Side;
				if (side != null)
				{
					if (!(side == "B"))
					{
						if (!(side == "S"))
						{
							if (!(side == "H"))
							{
								if (side == "C")
								{
									this.BackColor = Color.Turquoise;
									foreColor = Color.Black;
								}
							}
							else
							{
								this.BackColor = Color.Pink;
								foreColor = Color.Black;
							}
						}
						else
						{
							this.BackColor = Color.Maroon;
						}
					}
					else
					{
						this.BackColor = Color.DarkGreen;
					}
				}
				foreach (Control control in base.Controls)
				{
					if (control != this.lbLoading)
					{
						if (control.GetType() == typeof(Label) || control.GetType() == typeof(CheckBox))
						{
							control.ForeColor = foreColor;
						}
					}
				}
				this.tbOrderNo.Text = this._record.OrderNumber.ToString();
				this.tbSide.Text = this._record.Side;
				this.tbStock.Text = this._record.Stock;
				this.tbVolume.Text = Utilities.VolumeFormat(this._record.Volume, true);
				this.cbPrice.Text = this._record.Price;
				this.tbPublic.Text = Utilities.VolumeFormat(this._record.PubVol, true);
				this.chbNVDR.Checked = (this._record.TrusteeID == 2);
				if (!ApplicationInfo.SupportFreewill)
				{
					this.tbVolume.Focus();
				}
				else
				{
					this.chbNVDR.Focus();
				}
				if (base.Top + base.Height > base.Parent.Height)
				{
					base.Top = base.Parent.Height - base.Height;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmEditOrder_Shown", ex);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000AB0AC File Offset: 0x000A94AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, Settings.Default.Default_Font.Style);
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000AB134 File Offset: 0x000A9534
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000AB168 File Offset: 0x000A9568
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000AB180 File Offset: 0x000A9580
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

		// Token: 0x060008A8 RID: 2216 RVA: 0x000AB218 File Offset: 0x000A9618
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
					if (this.BackColor == Color.Maroon || this.BackColor == Color.DarkGreen)
					{
						((Control)sender).ForeColor = Color.White;
					}
					else
					{
						((Control)sender).ForeColor = Color.Black;
					}
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

		// Token: 0x060008A9 RID: 2217 RVA: 0x000AB384 File Offset: 0x000A9784
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmEditOrder_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.ClipRectangle.Width == base.Width)
			{
				e.Graphics.DrawRectangle(Pens.White, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000AB410 File Offset: 0x000A9810
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSendOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this._record.Stock];
				this._volume = 0L;
				try
				{
					this._volume = Convert.ToInt64(this.tbVolume.Text.Replace(",", ""));
					if (this._volume <= 0L)
					{
						this.ShowMessageInFormConfirm("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.ShowBox);
						return;
					}
					if (this._volume < (long)stockInformation.BoardLot)
					{
						this.ShowMessageInFormConfirm("Odd-lot dosn't supported!", frmOrderFormConfirm.OpenStyle.ShowBox);
						return;
					}
					if (this._volume % (long)stockInformation.BoardLot > 0L)
					{
						this.ShowMessageInFormConfirm("Mix-lot dosn't supported!", frmOrderFormConfirm.OpenStyle.ShowBox);
						return;
					}
				}
				catch
				{
					this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox);
					return;
				}
				if (this.IsValidPrice(this.cbPrice.Text, true))
				{
					this._price = this.cbPrice.Text.ToUpper().Trim();
					string price = this._price;
					if (price != null)
					{
						if (price == "ATO" || price == "ATC" || price == "MP" || price == "MO" || price == "ML")
						{
							goto IL_209;
						}
					}
					if (stockInformation.Number > 0)
					{
						decimal d;
						decimal.TryParse(this._price, out d);
						if (!(d >= stockInformation.Floor) || !(d <= stockInformation.Ceiling))
						{
							this.ShowMessageInFormConfirm("Checking with floor and ceiling.", frmOrderFormConfirm.OpenStyle.ShowBox);
							return;
						}
					}
					IL_209:
					this._pubVol = 0L;
					try
					{
						this._pubVol = ((this.tbPublic.Text != "") ? Convert.ToInt64(this.tbPublic.Text.Replace(",", "")) : 0L);
						if (this._pubVol > this._volume)
						{
							this.ShowMessageInFormConfirm("Published is Greater than Volume", frmOrderFormConfirm.OpenStyle.ShowBox);
							return;
						}
						if (this._pubVol > 0L && this._pubVol < this._volume)
						{
							price = this._price;
							if (price != null)
							{
								if (price == "MP" || price == "ATO" || price == "ATC" || price == "MO" || price == "ML")
								{
									this.ShowMessageInFormConfirm("Price condition cannot use Published.", frmOrderFormConfirm.OpenStyle.ShowBox);
									return;
								}
							}
						}
					}
					catch
					{
						this.ShowMessageInFormConfirm("Invalid public volume", frmOrderFormConfirm.OpenStyle.ShowBox);
						return;
					}
					this._trusteeId = (this.chbNVDR.Checked ? 2 : 0);
					this._sendResult = false;
					this.btnSendOrder.Enabled = false;
					string orderParam = string.Concat(new string[]
					{
						"Change Order::  ",
						(this._record.Volume != this._volume) ? string.Concat(new object[]
						{
							"\nVolume from ",
							this._record.Volume,
							" to ",
							FormatUtil.VolumeFormat(this._volume, true)
						}) : "",
						(this._record.Price != this._price) ? ("\nPrice from " + this._record.Price + " to " + this._price) : "",
						(this._record.TrusteeID != this._trusteeId) ? string.Concat(new object[]
						{
							"\nTrustee from ",
							this._record.TrusteeID,
							" to ",
							this._trusteeId
						}) : "",
						(this._record.PubVol != this._pubVol) ? string.Concat(new object[]
						{
							"\nPublish from ",
							this._record.PubVol,
							" to ",
							FormatUtil.VolumeFormat(this._pubVol, true)
						}) : ""
					});
					this.ShowOrderFormConfirm("Confirm to send?", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSendOrder_Click", ex);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000AB9B8 File Offset: 0x000A9DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice(string price, bool IsShowMessage)
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
						this.ShowMessageInFormConfirm("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox);
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
								this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox);
							}
							result = false;
							return result;
						}
					}
					else if (text.Length > 2)
					{
						if (IsShowMessage)
						{
							this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox);
						}
						result = false;
						return result;
					}
				}
				if (Convert.ToDecimal(price) <= 0m)
				{
					if (IsShowMessage)
					{
						this.ShowMessageInFormConfirm("Invalid price [More than 0]!.", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					result = false;
					return result;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000ABBB4 File Offset: 0x000A9FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmEditOrder.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
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
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, "", openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					if (base.Parent.GetType() == typeof(Panel))
					{
						this._frmConfirm.Parent = base.Parent.Parent;
					}
					else if (base.Parent.GetType().BaseType == typeof(ClientBaseForm))
					{
						this._frmConfirm.Parent = base.Parent;
					}
					else if (base.Parent.Parent.Parent.GetType() == typeof(frmMain))
					{
						this._frmConfirm.Parent = base.Parent.Parent.Parent;
					}
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

		// Token: 0x060008AD RID: 2221 RVA: 0x000ABE04 File Offset: 0x000AA204
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._verifyResult_Pin = ApplicationInfo.VerifyPincode(ApplicationInfo.UserPincode, ref this._verifyResultStr_Pin);
				if (this._verifyResult_Pin)
				{
					string data = ApplicationInfo.WebOrderService.SendEditOrder(ApplicationInfo.AuthenKey, ApplicationInfo.GetSession(), this._record.OrderNumber, this._record.EntryDate, this._volume, this._price, ApplicationInfo.AccInfo.CurrentAccount, this._pubVol, this._trusteeId, ApplicationInfo.AccInfo.CurrInternetUser);
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(data, dataSet);
						if (ApplicationInfo.SupportFreewill)
						{
							if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
							{
								this._sendResult = (dataSet.Tables["Results"].Rows[0]["code"].ToString() == "0");
								this._sendResultMessage = dataSet.Tables["Results"].Rows[0]["message"].ToString();
							}
						}
						else if (dataSet.Tables.Contains("TABLE") && dataSet.Tables["TABLE"].Rows.Count > 0)
						{
							if (dataSet.Tables["TABLE"].Rows[0][0].ToString() == "Y")
							{
								ApplicationInfo.AddOrderNoToAutoRefreshList(this._record.OrderNumber.ToString(), 1);
								this._sendResult = true;
							}
							else
							{
								foreach (DataTable dataTable in dataSet.Tables)
								{
									if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0].ToString() != "N")
									{
										this._sendResultMessage = dataTable.Rows[0][0].ToString();
									}
								}
							}
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowMessageInFormConfirm("Request fail =>" + ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000AC178 File Offset: 0x000AA578
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._verifyResult_Pin)
				{
					this.ShowMessageInFormConfirm(this._verifyResultStr_Pin, frmOrderFormConfirm.OpenStyle.ShowBox);
				}
				else if (this._sendResult)
				{
					base.Close();
				}
				else
				{
					this.ShowMessageInFormConfirm("Request fail =>" + this._sendResultMessage, frmOrderFormConfirm.OpenStyle.ShowBox);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo:RunWorkerCompleted", ex);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000AC220 File Offset: 0x000AA620
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbVolume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbVolume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbVolume.Text.Replace(",", ""));
							this.tbVolume.Text = num.ToString("#,###");
							this.tbVolume.Select(this.tbVolume.Text.Length, 0);
							this._isLockPubVol = true;
							this.tbPublic.Text = this.tbVolume.Text;
						}
						catch
						{
							this.tbVolume.Text = this.tbVolume.Text.Substring(0, this.tbVolume.Text.Length - 1);
						}
					}
					else
					{
						this.tbVolume.Text = this.tbVolume.Text.Substring(0, this.tbVolume.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbVolume_TextChanged", ex);
			}
			this._isLockPubVol = false;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000AC3C4 File Offset: 0x000AA7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPublic_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isLockPubVol && this.tbPublic.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbPublic.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbPublic.Text.Replace(",", ""));
							this.tbPublic.Text = num.ToString("#,###");
							this.tbPublic.Select(this.tbPublic.Text.Length, 0);
						}
						catch
						{
							this.tbPublic.Text = this.tbPublic.Text.Substring(0, this.tbPublic.Text.Length - 1);
						}
					}
					else
					{
						this.tbPublic.Text = this.tbPublic.Text.Substring(0, this.tbPublic.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbPublic_TextChanged", ex);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000AC554 File Offset: 0x000AA954
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				if (keyCode == Keys.Right)
				{
					this.cbPrice.Focus();
				}
			}
			else
			{
				this.btnSendOrder.PerformClick();
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000AC5B0 File Offset: 0x000AA9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_KeyDown(object sender, KeyEventArgs e)
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
					this.tbVolume.Focus();
				}
			}
			else
			{
				this.btnSendOrder.PerformClick();
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000AC60C File Offset: 0x000AAA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000AC648 File Offset: 0x000AAA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowOrderFormConfirm(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmEditOrder.ShowOrderFormConfirmCallBack(this.ShowOrderFormConfirm), new object[]
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
					this._frmConfirm = new frmOrderFormConfirm(message, "", openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.OrderParam = orderParam;
					if (base.Parent.GetType() == typeof(Panel))
					{
						this._frmConfirm.Parent = base.Parent.Parent;
					}
					else if (base.Parent.GetType().BaseType == typeof(ClientBaseForm))
					{
						this._frmConfirm.Parent = base.Parent;
					}
					else if (base.Parent.Parent.Parent.GetType() == typeof(frmMain))
					{
						this._frmConfirm.Parent = base.Parent.Parent.Parent;
					}
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

		// Token: 0x060008B5 RID: 2229 RVA: 0x000AC8C4 File Offset: 0x000AACC4
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
					if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
					{
						if (result == DialogResult.OK)
						{
							if (this.bgw == null)
							{
								this.bgw = new BackgroundWorker();
								this.bgw.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
								this.bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
							}
							if (!this.bgw.IsBusy)
							{
								this.bgw.RunWorkerAsync();
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
			this.btnSendOrder.Enabled = true;
		}

		// Token: 0x0400057E RID: 1406
		private IContainer components;

		// Token: 0x0400057F RID: 1407
		private Button btnClose;

		// Token: 0x04000580 RID: 1408
		private Label lbSide;

		// Token: 0x04000581 RID: 1409
		private Button btnSendOrder;

		// Token: 0x04000582 RID: 1410
		private Label lbPublic;

		// Token: 0x04000583 RID: 1411
		private Label lbPrice;

		// Token: 0x04000584 RID: 1412
		private TextBox tbVolume;

		// Token: 0x04000585 RID: 1413
		private Label lbStock;

		// Token: 0x04000586 RID: 1414
		private TextBox tbSide;

		// Token: 0x04000587 RID: 1415
		private Label lbVolume;

		// Token: 0x04000588 RID: 1416
		private CheckBox chbNVDR;

		// Token: 0x04000589 RID: 1417
		private TextBox tbPublic;

		// Token: 0x0400058A RID: 1418
		private TextBox tbStock;

		// Token: 0x0400058B RID: 1419
		private Label lbLoading;

		// Token: 0x0400058C RID: 1420
		private ComboBox cbPrice;

		// Token: 0x0400058D RID: 1421
		private Label label1;

		// Token: 0x0400058E RID: 1422
		private TextBox tbOrderNo;

		// Token: 0x0400058F RID: 1423
		private frmEditOrder.OrderEditRecord _record;

		// Token: 0x04000590 RID: 1424
		private long _volume;

		// Token: 0x04000591 RID: 1425
		private long _pubVol;

		// Token: 0x04000592 RID: 1426
		private string _price;

		// Token: 0x04000593 RID: 1427
		private int _trusteeId;

		// Token: 0x04000594 RID: 1428
		private bool _verifyResult_Pin;

		// Token: 0x04000595 RID: 1429
		private string _verifyResultStr_Pin;

		// Token: 0x04000596 RID: 1430
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000597 RID: 1431
		private BackgroundWorker bgw;

		// Token: 0x04000598 RID: 1432
		private bool _sendResult;

		// Token: 0x04000599 RID: 1433
		private string _sendResultMessage;

		// Token: 0x0400059A RID: 1434
		private bool _isLockPubVol;

		// Token: 0x020000BC RID: 188
		public struct OrderEditRecord
		{
			// Token: 0x0400059B RID: 1435
			public long OrderNumber;

			// Token: 0x0400059C RID: 1436
			public string Side;

			// Token: 0x0400059D RID: 1437
			public string Stock;

			// Token: 0x0400059E RID: 1438
			public int TrusteeID;

			// Token: 0x0400059F RID: 1439
			public long Volume;

			// Token: 0x040005A0 RID: 1440
			public string Price;

			// Token: 0x040005A1 RID: 1441
			public long PubVol;

			// Token: 0x040005A2 RID: 1442
			public string EntryDate;

			// Token: 0x040005A3 RID: 1443
			public long MatVolume;
		}

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x060008B7 RID: 2231
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060008BB RID: 2235
		private delegate void ShowOrderFormConfirmCallBack(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
