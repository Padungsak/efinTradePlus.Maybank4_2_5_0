using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;

namespace i2TradePlus.Controls
{
	// Token: 0x02000054 RID: 84
	public class ucBSSetting : Form
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x0003D594 File Offset: 0x0003B994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucBSSetting() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0003D5C0 File Offset: 0x0003B9C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBSSetting_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.chkBSAutoVolume.Checked = Settings.Default.BSBoxDefaultVolumeActive;
				this.tbDefVolume.Text = Utilities.VolumeFormat(Settings.Default.BSBoxDefaultVolume, true);
				this.tbNextVolume.Text = Utilities.VolumeFormat(Settings.Default.BSBoxDefaultVolumeNext, true);
				this.chkBSDefaultLastStock.Checked = Settings.Default.BSBoxDefaultStock;
				this.chkBSInputTTF.Checked = Settings.Default.BSBoxEntryTTF;
				if (Settings.Default.BSBoxDefaultPrice > 0)
				{
					this.chkBSAutoPrice.Checked = true;
					if (Settings.Default.BSBoxDefaultPrice == 1)
					{
						this.rbBSDefLastprice.Checked = true;
					}
					else if (Settings.Default.BSBoxDefaultPrice == 2)
					{
						this.rbBSDefBestBid.Checked = true;
					}
				}
				else
				{
					this.chkBSAutoPrice.Checked = false;
				}
				this.chkSavePincode.Checked = Settings.Default.BSBoxSavePincode;
				this.gbAutoTrade.Enabled = (ApplicationInfo.AutoTradeType > 0);
			}
			catch
			{
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0003D73C File Offset: 0x0003BB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Save()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Settings.Default.BSBoxDefaultStock = this.chkBSDefaultLastStock.Checked;
			Settings.Default.BSBoxEntryTTF = this.chkBSInputTTF.Checked;
			Settings.Default.BSBoxDefaultVolumeActive = this.chkBSAutoVolume.Checked;
			long num;
			long.TryParse(this.tbNextVolume.Text.Replace(",", ""), out num);
			Settings.Default.BSBoxDefaultVolumeNext = num;
			long.TryParse(this.tbDefVolume.Text.Replace(",", ""), out num);
			Settings.Default.BSBoxDefaultVolume = num;
			if (this.chkBSAutoPrice.Checked)
			{
				if (this.rbBSDefLastprice.Checked)
				{
					Settings.Default.BSBoxDefaultPrice = 1;
				}
				else if (this.rbBSDefBestBid.Checked)
				{
					Settings.Default.BSBoxDefaultPrice = 2;
				}
			}
			else
			{
				Settings.Default.BSBoxDefaultPrice = 0;
			}
			Settings.Default.BSBoxSavePincode = this.chkSavePincode.Checked;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0003D87C File Offset: 0x0003BC7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeLanguage(string lang)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (lang == "T")
				{
					this.chkSavePincode.Text = "บันทึก PINCODE";
					this.gbSavePin.Text = "คำเตือน";
					this.lbSavePin.Text = "   \"บันทึก PINCODE\" โปรแกรมจะจดจำรหัส PINCODE ไว้จนกว่าจะถึงเวลาที่กำหนดในแต่ละรอบ " + "\r\nเมื่อมีการส่งคำสั่งซื้อ/ขาย หรือยกเลิก โปรแกรมจะเป็นผู้ป้อนค่าให้แบบอัตโนมัติ" + "\r\n   ดังนั้นท่านต้องทำความเข้าใจและยอมรับในความเสี่ยงที่จะเกิดขึ้นจากการ บันทึก PINCODE " + "\r\n และโปรแกรม i2Trade จะไม่รับผิดชอบต่อความเสียหายใดที่เกิดขึ้นทุกกรณี";
					this.chkBSDefaultLastStock.Text = "หลังส่งคำสั่งให้คงชื่อหลักทรัพย์ไว้";
					this.chkBSInputTTF.Text = "ใส่ค่า Trustee Id ทุกครั้ง";
					this.chkBSAutoPrice.Text = "ใส่ราคาอัตโนมัติ";
					this.chkBSAutoVolume.Text = "ใส่ราคาปริมาณซื้อ/ขายอัตโนมัติ";
					this.gbBSDefaultPrice.Text = "กำหนดราคาเป็น";
				}
				else
				{
					this.chkSavePincode.Text = "Save PINCODE";
					this.gbSavePin.Text = "Disclaimer";
					this.lbSavePin.Text = string.Concat(new string[]
					{
						"   \"Save PIN\" function allows you to save your PIN for an interval. During this ",
						"\r\ninterval, re-enter PIN is not required for any transaction performed in this",
						"\r\ntrading program only.",
						"\r\n   Therefore, you understand and accept the risk of using this \"Save PIN\"",
						"\r\nfunction, i2Trade will take no responsibility on any loss or damage from any",
						"\r\nerror occurred."
					});
					this.chkBSDefaultLastStock.Text = "The order shall remain subject securities.";
					this.chkBSInputTTF.Text = "Always put value of Trustee Id.";
					this.chkBSAutoPrice.Text = "The price automatically.";
					this.chkBSAutoVolume.Text = "Enter the amount of automation.";
					this.gbBSDefaultPrice.Text = "Default price.";
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0003DA40 File Offset: 0x0003BE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chkBSAutoPrice_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.gbBSDefaultPrice.Enabled = this.chkBSAutoPrice.Checked;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0003DA68 File Offset: 0x0003BE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chkBSAutoVolume_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lbDefVolume.Enabled = this.chkBSAutoVolume.Checked;
			this.tbDefVolume.Enabled = this.chkBSAutoVolume.Checked;
			this.lbNextVolume.Enabled = this.chkBSAutoVolume.Checked;
			this.tbNextVolume.Enabled = this.chkBSAutoVolume.Checked;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0003DAE0 File Offset: 0x0003BEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbDefVolume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbDefVolume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbDefVolume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbDefVolume.Text.Replace(",", ""));
							this.tbDefVolume.Text = num.ToString("#,###");
							this.tbDefVolume.Select(this.tbDefVolume.Text.Length, 0);
						}
						catch
						{
							this.tbDefVolume.Text = this.tbDefVolume.Text.Substring(0, this.tbDefVolume.Text.Length - 1);
						}
					}
					else
					{
						this.tbDefVolume.Text = this.tbDefVolume.Text.Substring(0, this.tbDefVolume.Text.Length - 1);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0003DC54 File Offset: 0x0003C054
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbNextVolume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbNextVolume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbNextVolume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbNextVolume.Text.Replace(",", ""));
							this.tbNextVolume.Text = num.ToString("#,###");
							this.tbNextVolume.Select(this.tbNextVolume.Text.Length, 0);
						}
						catch
						{
							this.tbNextVolume.Text = this.tbNextVolume.Text.Substring(0, this.tbNextVolume.Text.Length - 1);
						}
					}
					else
					{
						this.tbNextVolume.Text = this.tbNextVolume.Text.Substring(0, this.tbNextVolume.Text.Length - 1);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0003DDC8 File Offset: 0x0003C1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdoLangThai_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ChangeLanguage("T");
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0003DDE8 File Offset: 0x0003C1E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdoLangEnglish_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ChangeLanguage("E");
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0003DE08 File Offset: 0x0003C208
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSave_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Save();
			base.Close();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0003DE28 File Offset: 0x0003C228
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0003DE40 File Offset: 0x0003C240
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBSSetting_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0003DE5C File Offset: 0x0003C25C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnStopOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				frmStopDisclaimer frmStopDisclaimer = new frmStopDisclaimer(true);
				frmStopDisclaimer.TopLevel = false;
				frmStopDisclaimer.Parent = base.Parent;
				frmStopDisclaimer.Location = new Point((frmStopDisclaimer.Parent.Width - frmStopDisclaimer.Width) / 2, (frmStopDisclaimer.Parent.Height - frmStopDisclaimer.Height) / 2);
				frmStopDisclaimer.TopMost = true;
				frmStopDisclaimer.Show();
				frmStopDisclaimer.BringToFront();
			}
			catch
			{
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0003DF00 File Offset: 0x0003C300
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

		// Token: 0x060003F8 RID: 1016 RVA: 0x0003DF50 File Offset: 0x0003C350
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucBSSetting));
			this.chkBSAutoVolume = new CheckBox();
			this.tbNextVolume = new TextBox();
			this.lbNextVolume = new Label();
			this.tbDefVolume = new TextBox();
			this.lbDefVolume = new Label();
			this.chkBSInputTTF = new CheckBox();
			this.gbSavePin = new GroupBox();
			this.lbSavePin = new Label();
			this.chkSavePincode = new CheckBox();
			this.chkBSAutoPrice = new CheckBox();
			this.chkBSDefaultLastStock = new CheckBox();
			this.rbBSDefBestBid = new RadioButton();
			this.rbBSDefLastprice = new RadioButton();
			this.gbBSDefaultPrice = new GroupBox();
			this.rdoLangEnglish = new RadioButton();
			this.rdoLangThai = new RadioButton();
			this.btnClose = new Button();
			this.btnSave = new Button();
			this.gbAutoTrade = new GroupBox();
			this.btnStopOrder = new Button();
			this.gbSavePin.SuspendLayout();
			this.gbBSDefaultPrice.SuspendLayout();
			this.gbAutoTrade.SuspendLayout();
			base.SuspendLayout();
			this.chkBSAutoVolume.AutoSize = true;
			this.chkBSAutoVolume.Location = new Point(9, 178);
			this.chkBSAutoVolume.Name = "chkBSAutoVolume";
			this.chkBSAutoVolume.Size = new Size(170, 20);
			this.chkBSAutoVolume.TabIndex = 5;
			this.chkBSAutoVolume.Text = "ใส่ปริมาณซื้อ/ขายอัตโนมัติ";
			this.chkBSAutoVolume.UseVisualStyleBackColor = true;
			this.chkBSAutoVolume.TextChanged += new EventHandler(this.chkBSAutoVolume_CheckedChanged);
			this.chkBSAutoVolume.CheckedChanged += new EventHandler(this.chkBSAutoVolume_CheckedChanged);
			this.tbNextVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbNextVolume.Enabled = false;
			this.tbNextVolume.Location = new Point(321, 208);
			this.tbNextVolume.Name = "tbNextVolume";
			this.tbNextVolume.Size = new Size(92, 23);
			this.tbNextVolume.TabIndex = 7;
			this.tbNextVolume.TextChanged += new EventHandler(this.tbNextVolume_TextChanged);
			this.lbNextVolume.AutoSize = true;
			this.lbNextVolume.Enabled = false;
			this.lbNextVolume.Location = new Point(257, 210);
			this.lbNextVolume.Name = "lbNextVolume";
			this.lbNextVolume.Size = new Size(63, 16);
			this.lbNextVolume.TabIndex = 33;
			this.lbNextVolume.Text = "Next Step";
			this.tbDefVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbDefVolume.Enabled = false;
			this.tbDefVolume.Location = new Point(120, 207);
			this.tbDefVolume.Name = "tbDefVolume";
			this.tbDefVolume.Size = new Size(116, 23);
			this.tbDefVolume.TabIndex = 6;
			this.tbDefVolume.TextChanged += new EventHandler(this.tbDefVolume_TextChanged);
			this.lbDefVolume.AutoSize = true;
			this.lbDefVolume.Enabled = false;
			this.lbDefVolume.Location = new Point(66, 210);
			this.lbDefVolume.Name = "lbDefVolume";
			this.lbDefVolume.Size = new Size(51, 16);
			this.lbDefVolume.TabIndex = 28;
			this.lbDefVolume.Text = "Volume";
			this.chkBSInputTTF.AutoSize = true;
			this.chkBSInputTTF.Location = new Point(9, 42);
			this.chkBSInputTTF.Name = "chkBSInputTTF";
			this.chkBSInputTTF.Size = new Size(159, 20);
			this.chkBSInputTTF.TabIndex = 1;
			this.chkBSInputTTF.Text = "ใส่ค่า Trustee Id ทุกครั้ง";
			this.chkBSInputTTF.UseVisualStyleBackColor = true;
			this.gbSavePin.Controls.Add(this.lbSavePin);
			this.gbSavePin.Location = new Point(6, 274);
			this.gbSavePin.Name = "gbSavePin";
			this.gbSavePin.Size = new Size(522, 116);
			this.gbSavePin.TabIndex = 6;
			this.gbSavePin.TabStop = false;
			this.gbSavePin.Text = "คำเตือน";
			this.lbSavePin.BackColor = Color.Transparent;
			this.lbSavePin.Dock = DockStyle.Fill;
			this.lbSavePin.Location = new Point(3, 19);
			this.lbSavePin.Name = "lbSavePin";
			this.lbSavePin.Size = new Size(516, 94);
			this.lbSavePin.TabIndex = 0;
			this.lbSavePin.Text = componentResourceManager.GetString("lbSavePin.Text");
			this.chkSavePincode.AutoSize = true;
			this.chkSavePincode.Location = new Point(9, 243);
			this.chkSavePincode.Name = "chkSavePincode";
			this.chkSavePincode.Size = new Size(115, 20);
			this.chkSavePincode.TabIndex = 8;
			this.chkSavePincode.Text = "บันทึก PINCODE";
			this.chkSavePincode.UseVisualStyleBackColor = true;
			this.chkBSAutoPrice.AutoSize = true;
			this.chkBSAutoPrice.Location = new Point(9, 75);
			this.chkBSAutoPrice.Name = "chkBSAutoPrice";
			this.chkBSAutoPrice.Size = new Size(113, 20);
			this.chkBSAutoPrice.TabIndex = 2;
			this.chkBSAutoPrice.Text = "ใส่ราคาอัตโนมัติ";
			this.chkBSAutoPrice.UseVisualStyleBackColor = true;
			this.chkBSAutoPrice.TextChanged += new EventHandler(this.chkBSAutoPrice_CheckedChanged);
			this.chkBSAutoPrice.CheckedChanged += new EventHandler(this.chkBSAutoPrice_CheckedChanged);
			this.chkBSDefaultLastStock.AutoSize = true;
			this.chkBSDefaultLastStock.Location = new Point(9, 9);
			this.chkBSDefaultLastStock.Name = "chkBSDefaultLastStock";
			this.chkBSDefaultLastStock.Size = new Size(204, 20);
			this.chkBSDefaultLastStock.TabIndex = 0;
			this.chkBSDefaultLastStock.Text = "หลังส่งคำสั่งให้คงชื่อหลักทรัพย์ไว้";
			this.chkBSDefaultLastStock.UseVisualStyleBackColor = true;
			this.rbBSDefBestBid.AutoSize = true;
			this.rbBSDefBestBid.Location = new Point(133, 27);
			this.rbBSDefBestBid.Name = "rbBSDefBestBid";
			this.rbBSDefBestBid.Size = new Size(212, 20);
			this.rbBSDefBestBid.TabIndex = 4;
			this.rbBSDefBestBid.TabStop = true;
			this.rbBSDefBestBid.Text = "Buy -> 1st Offer / Sell -> 1st Bid";
			this.rbBSDefBestBid.UseVisualStyleBackColor = true;
			this.rbBSDefLastprice.AutoSize = true;
			this.rbBSDefLastprice.Location = new Point(27, 26);
			this.rbBSDefLastprice.Name = "rbBSDefLastprice";
			this.rbBSDefLastprice.Size = new Size(81, 20);
			this.rbBSDefLastprice.TabIndex = 3;
			this.rbBSDefLastprice.TabStop = true;
			this.rbBSDefLastprice.Text = "Last Price";
			this.rbBSDefLastprice.UseVisualStyleBackColor = true;
			this.gbBSDefaultPrice.Controls.Add(this.rbBSDefLastprice);
			this.gbBSDefaultPrice.Controls.Add(this.rbBSDefBestBid);
			this.gbBSDefaultPrice.Enabled = false;
			this.gbBSDefaultPrice.Location = new Point(63, 98);
			this.gbBSDefaultPrice.Name = "gbBSDefaultPrice";
			this.gbBSDefaultPrice.Size = new Size(406, 66);
			this.gbBSDefaultPrice.TabIndex = 2;
			this.gbBSDefaultPrice.TabStop = false;
			this.gbBSDefaultPrice.Text = "กำหนดราคาเป็น";
			this.rdoLangEnglish.AutoSize = true;
			this.rdoLangEnglish.Location = new Point(83, 475);
			this.rdoLangEnglish.Margin = new Padding(3, 4, 3, 4);
			this.rdoLangEnglish.Name = "rdoLangEnglish";
			this.rdoLangEnglish.Size = new Size(66, 20);
			this.rdoLangEnglish.TabIndex = 39;
			this.rdoLangEnglish.Text = "English";
			this.rdoLangEnglish.UseVisualStyleBackColor = true;
			this.rdoLangEnglish.CheckedChanged += new EventHandler(this.rdoLangEnglish_CheckedChanged);
			this.rdoLangThai.AutoSize = true;
			this.rdoLangThai.Checked = true;
			this.rdoLangThai.Location = new Point(10, 475);
			this.rdoLangThai.Margin = new Padding(3, 4, 3, 4);
			this.rdoLangThai.Name = "rdoLangThai";
			this.rdoLangThai.Size = new Size(50, 20);
			this.rdoLangThai.TabIndex = 38;
			this.rdoLangThai.TabStop = true;
			this.rdoLangThai.Text = "ไทย";
			this.rdoLangThai.UseVisualStyleBackColor = true;
			this.rdoLangThai.CheckedChanged += new EventHandler(this.rdoLangThai_CheckedChanged);
			this.btnClose.FlatAppearance.BorderColor = Color.Gray;
			this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClose.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnClose.FlatStyle = FlatStyle.Flat;
			this.btnClose.Location = new Point(443, 471);
			this.btnClose.Margin = new Padding(3, 4, 3, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(87, 28);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnSave.FlatAppearance.BorderColor = Color.Gray;
			this.btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSave.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnSave.FlatStyle = FlatStyle.Flat;
			this.btnSave.Location = new Point(348, 471);
			this.btnSave.Margin = new Padding(3, 4, 3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new Size(87, 28);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new EventHandler(this.btnSave_Click);
			this.gbAutoTrade.Controls.Add(this.btnStopOrder);
			this.gbAutoTrade.Location = new Point(6, 393);
			this.gbAutoTrade.Name = "gbAutoTrade";
			this.gbAutoTrade.Size = new Size(522, 58);
			this.gbAutoTrade.TabIndex = 40;
			this.gbAutoTrade.TabStop = false;
			this.gbAutoTrade.Text = "Auto Trade";
			this.btnStopOrder.FlatAppearance.BorderColor = Color.Gray;
			this.btnStopOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStopOrder.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnStopOrder.FlatStyle = FlatStyle.Flat;
			this.btnStopOrder.Location = new Point(114, 23);
			this.btnStopOrder.Margin = new Padding(3, 4, 3, 4);
			this.btnStopOrder.Name = "btnStopOrder";
			this.btnStopOrder.Size = new Size(271, 28);
			this.btnStopOrder.TabIndex = 10;
			this.btnStopOrder.Text = "แสดงเงื่อนไขการใช้งาน Auto Trade";
			this.btnStopOrder.UseVisualStyleBackColor = true;
			this.btnStopOrder.Click += new EventHandler(this.btnStopOrder_Click);
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(533, 502);
			base.ControlBox = false;
			base.Controls.Add(this.gbAutoTrade);
			base.Controls.Add(this.rdoLangEnglish);
			base.Controls.Add(this.rdoLangThai);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.chkBSAutoVolume);
			base.Controls.Add(this.tbNextVolume);
			base.Controls.Add(this.chkBSDefaultLastStock);
			base.Controls.Add(this.lbNextVolume);
			base.Controls.Add(this.chkBSAutoPrice);
			base.Controls.Add(this.tbDefVolume);
			base.Controls.Add(this.chkSavePincode);
			base.Controls.Add(this.lbDefVolume);
			base.Controls.Add(this.gbSavePin);
			base.Controls.Add(this.chkBSInputTTF);
			base.Controls.Add(this.gbBSDefaultPrice);
			this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ucBSSetting";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Buy/Sell Option";
			base.Load += new EventHandler(this.ucBSSetting_Load);
			base.Shown += new EventHandler(this.ucBSSetting_Shown);
			this.gbSavePin.ResumeLayout(false);
			this.gbBSDefaultPrice.ResumeLayout(false);
			this.gbBSDefaultPrice.PerformLayout();
			this.gbAutoTrade.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000232 RID: 562
		private IContainer components;

		// Token: 0x04000233 RID: 563
		private CheckBox chkBSAutoVolume;

		// Token: 0x04000234 RID: 564
		private TextBox tbNextVolume;

		// Token: 0x04000235 RID: 565
		private Label lbNextVolume;

		// Token: 0x04000236 RID: 566
		private TextBox tbDefVolume;

		// Token: 0x04000237 RID: 567
		private Label lbDefVolume;

		// Token: 0x04000238 RID: 568
		private CheckBox chkBSInputTTF;

		// Token: 0x04000239 RID: 569
		private GroupBox gbSavePin;

		// Token: 0x0400023A RID: 570
		private Label lbSavePin;

		// Token: 0x0400023B RID: 571
		private CheckBox chkSavePincode;

		// Token: 0x0400023C RID: 572
		private CheckBox chkBSAutoPrice;

		// Token: 0x0400023D RID: 573
		private CheckBox chkBSDefaultLastStock;

		// Token: 0x0400023E RID: 574
		private RadioButton rbBSDefBestBid;

		// Token: 0x0400023F RID: 575
		private RadioButton rbBSDefLastprice;

		// Token: 0x04000240 RID: 576
		private GroupBox gbBSDefaultPrice;

		// Token: 0x04000241 RID: 577
		private RadioButton rdoLangEnglish;

		// Token: 0x04000242 RID: 578
		private RadioButton rdoLangThai;

		// Token: 0x04000243 RID: 579
		private Button btnClose;

		// Token: 0x04000244 RID: 580
		private Button btnSave;

		// Token: 0x04000245 RID: 581
		private GroupBox gbAutoTrade;

		// Token: 0x04000246 RID: 582
		private Button btnStopOrder;
	}
}
