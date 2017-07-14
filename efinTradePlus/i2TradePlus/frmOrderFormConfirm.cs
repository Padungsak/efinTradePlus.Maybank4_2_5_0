using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus
{
	// Token: 0x02000039 RID: 57
	public class frmOrderFormConfirm : Form
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0002AE0C File Offset: 0x0002920C
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

		// Token: 0x06000241 RID: 577 RVA: 0x0002AE5C File Offset: 0x0002925C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmOrderFormConfirm));
			this.btnCancel = new Button();
			this.btnOk = new Button();
			this.btnNo = new Button();
			this.lbPincode = new Label();
			this.tbPincode = new TextBox();
			this.chbSavePincode = new CheckBox();
			this.gbSavePingDisclaimer = new GroupBox();
			this.btnSavePinDisAgree = new Button();
			this.btnSavePinAgree = new Button();
			this.lbSavePin = new Label();
			this.panel1 = new Panel();
			this.lbOSS = new Label();
			this.lbOSSLabel = new Label();
			this.lbStockTH = new Label();
			this.lbStockTHlabel = new Label();
			this.lbOrderString = new Label();
			this.gbSavePingDisclaimer.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnCancel.BackColor = Color.WhiteSmoke;
			this.btnCancel.FlatAppearance.BorderColor = Color.Gray;
			this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnCancel.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Location = new Point(272, 197);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(87, 29);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnCancel.Leave += new EventHandler(this.Button_Leave);
			this.btnCancel.Enter += new EventHandler(this.Button_Enter);
			this.btnOk.BackColor = Color.WhiteSmoke;
			this.btnOk.FlatAppearance.BorderColor = Color.Gray;
			this.btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnOk.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnOk.FlatStyle = FlatStyle.Flat;
			this.btnOk.Location = new Point(51, 198);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(87, 29);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Yes";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.btnOk.Leave += new EventHandler(this.Button_Leave);
			this.btnOk.Enter += new EventHandler(this.Button_Enter);
			this.btnNo.BackColor = Color.WhiteSmoke;
			this.btnNo.FlatAppearance.BorderColor = Color.Gray;
			this.btnNo.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnNo.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnNo.FlatStyle = FlatStyle.Flat;
			this.btnNo.Location = new Point(160, 197);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new Size(87, 29);
			this.btnNo.TabIndex = 1;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Click += new EventHandler(this.btnNo_Click);
			this.btnNo.Leave += new EventHandler(this.Button_Leave);
			this.btnNo.Enter += new EventHandler(this.Button_Enter);
			this.lbPincode.AutoSize = true;
			this.lbPincode.Location = new Point(10, 203);
			this.lbPincode.Name = "lbPincode";
			this.lbPincode.Size = new Size(25, 16);
			this.lbPincode.TabIndex = 2;
			this.lbPincode.Text = "Pin";
			this.tbPincode.Location = new Point(39, 200);
			this.tbPincode.MaxLength = 10;
			this.tbPincode.Name = "tbPincode";
			this.tbPincode.PasswordChar = '*';
			this.tbPincode.Size = new Size(72, 23);
			this.tbPincode.TabIndex = 0;
			this.tbPincode.KeyDown += new KeyEventHandler(this.tbPincode_KeyDown);
			this.tbPincode.Leave += new EventHandler(this.Button_Leave);
			this.tbPincode.Enter += new EventHandler(this.Button_Enter);
			this.chbSavePincode.AutoSize = true;
			this.chbSavePincode.Location = new Point(116, 202);
			this.chbSavePincode.Name = "chbSavePincode";
			this.chbSavePincode.Size = new Size(55, 20);
			this.chbSavePincode.TabIndex = 0;
			this.chbSavePincode.TabStop = false;
			this.chbSavePincode.Text = "Save";
			this.chbSavePincode.UseVisualStyleBackColor = true;
			this.chbSavePincode.Click += new EventHandler(this.chbSavePincode_Click);
			this.gbSavePingDisclaimer.BackColor = Color.FromArgb(224, 224, 224);
			this.gbSavePingDisclaimer.Controls.Add(this.btnSavePinDisAgree);
			this.gbSavePingDisclaimer.Controls.Add(this.btnSavePinAgree);
			this.gbSavePingDisclaimer.Controls.Add(this.lbSavePin);
			this.gbSavePingDisclaimer.Dock = DockStyle.Fill;
			this.gbSavePingDisclaimer.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.gbSavePingDisclaimer.Location = new Point(0, 0);
			this.gbSavePingDisclaimer.Name = "gbSavePingDisclaimer";
			this.gbSavePingDisclaimer.Size = new Size(479, 231);
			this.gbSavePingDisclaimer.TabIndex = 7;
			this.gbSavePingDisclaimer.TabStop = false;
			this.gbSavePingDisclaimer.Text = "Disclaimer";
			this.gbSavePingDisclaimer.Visible = false;
			this.btnSavePinDisAgree.Location = new Point(200, 72);
			this.btnSavePinDisAgree.Name = "btnSavePinDisAgree";
			this.btnSavePinDisAgree.Size = new Size(96, 23);
			this.btnSavePinDisAgree.TabIndex = 2;
			this.btnSavePinDisAgree.Text = "I DISAGREE";
			this.btnSavePinDisAgree.UseVisualStyleBackColor = true;
			this.btnSavePinDisAgree.Click += new EventHandler(this.btnSavePinDisAgree_Click);
			this.btnSavePinAgree.Location = new Point(114, 72);
			this.btnSavePinAgree.Name = "btnSavePinAgree";
			this.btnSavePinAgree.Size = new Size(72, 23);
			this.btnSavePinAgree.TabIndex = 1;
			this.btnSavePinAgree.Text = "I AGREE";
			this.btnSavePinAgree.UseVisualStyleBackColor = true;
			this.btnSavePinAgree.Click += new EventHandler(this.btnSavePinAgree_Click);
			this.lbSavePin.AutoSize = true;
			this.lbSavePin.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbSavePin.Location = new Point(6, -19);
			this.lbSavePin.Name = "lbSavePin";
			this.lbSavePin.Size = new Size(414, 90);
			this.lbSavePin.TabIndex = 0;
			this.lbSavePin.Text = componentResourceManager.GetString("lbSavePin.Text");
			this.panel1.BackColor = Color.FromArgb(20, 20, 20);
			this.panel1.Controls.Add(this.lbOSS);
			this.panel1.Controls.Add(this.lbOSSLabel);
			this.panel1.Controls.Add(this.lbStockTH);
			this.panel1.Controls.Add(this.lbStockTHlabel);
			this.panel1.Controls.Add(this.lbOrderString);
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(478, 190);
			this.panel1.TabIndex = 8;
			this.lbOSS.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lbOSS.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbOSS.ForeColor = Color.FromArgb(255, 128, 0);
			this.lbOSS.Location = new Point(24, 159);
			this.lbOSS.Name = "lbOSS";
			this.lbOSS.Size = new Size(443, 23);
			this.lbOSS.TabIndex = 6;
			this.lbOSS.Text = "Warning String";
			this.lbOSSLabel.AutoSize = true;
			this.lbOSSLabel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbOSSLabel.ForeColor = Color.LightGray;
			this.lbOSSLabel.Location = new Point(8, 141);
			this.lbOSSLabel.Name = "lbOSSLabel";
			this.lbOSSLabel.Size = new Size(111, 16);
			this.lbOSSLabel.TabIndex = 5;
			this.lbOSSLabel.Text = "Order Screening :";
			this.lbStockTH.AutoSize = true;
			this.lbStockTH.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbStockTH.ForeColor = Color.Red;
			this.lbStockTH.Location = new Point(24, 118);
			this.lbStockTH.Name = "lbStockTH";
			this.lbStockTH.Size = new Size(102, 18);
			this.lbStockTH.TabIndex = 4;
			this.lbStockTH.Text = "Warning String";
			this.lbStockTHlabel.AutoSize = true;
			this.lbStockTHlabel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbStockTHlabel.ForeColor = Color.LightGray;
			this.lbStockTHlabel.Location = new Point(8, 97);
			this.lbStockTHlabel.Name = "lbStockTHlabel";
			this.lbStockTHlabel.Size = new Size(85, 16);
			this.lbStockTHlabel.TabIndex = 3;
			this.lbStockTHlabel.Text = "Risk Control :";
			this.lbOrderString.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lbOrderString.AutoSize = true;
			this.lbOrderString.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbOrderString.ForeColor = Color.Yellow;
			this.lbOrderString.Location = new Point(8, 5);
			this.lbOrderString.Name = "lbOrderString";
			this.lbOrderString.Size = new Size(86, 18);
			this.lbOrderString.TabIndex = 0;
			this.lbOrderString.Text = "Order String";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(479, 231);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.chbSavePincode);
			base.Controls.Add(this.tbPincode);
			base.Controls.Add(this.lbPincode);
			base.Controls.Add(this.btnNo);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.gbSavePingDisclaimer);
			this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.Name = "frmOrderFormConfirm";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Order Confirmation";
			base.Load += new EventHandler(this.frmOrderFormConfirm_Load);
			base.Shown += new EventHandler(this.frmOrderFormConfirm_Shown);
			base.KeyDown += new KeyEventHandler(this.frmOrderFormConfirm_KeyDown);
			this.gbSavePingDisclaimer.ResumeLayout(false);
			this.gbSavePingDisclaimer.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0002BC78 File Offset: 0x0002A078
		public DialogResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.result;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0002BCA4 File Offset: 0x0002A0A4
		public frmOrderFormConfirm.OpenStyle OpenFormStyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.openFormStyle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0002BCD0 File Offset: 0x0002A0D0
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0002BCFC File Offset: 0x0002A0FC
		public string OssMessage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._ossMessage;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._ossMessage = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0002BD14 File Offset: 0x0002A114
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0002BD40 File Offset: 0x0002A140
		public string StockThreshold
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._stockThreshold;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._stockThreshold = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0002BD58 File Offset: 0x0002A158
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0002BD84 File Offset: 0x0002A184
		public string OrderParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._orderParam;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._orderParam = value;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0002BD9C File Offset: 0x0002A19C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmOrderFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.result = DialogResult.None;
			this.openFormStyle = frmOrderFormConfirm.OpenStyle.ShowBox;
			this._ossMessage = string.Empty;
			this._stockThreshold = string.Empty;
			this._orderParam = string.Empty;
			this._message = string.Empty;
			this._isShowPin = false;
			this.tmCloseForm = null;
			
			this.InitializeComponent();
			this.openFormStyle = openStyle;
			this._message = message;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0002BE2C File Offset: 0x0002A22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmOrderFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle, string pinCode) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.result = DialogResult.None;
			this.openFormStyle = frmOrderFormConfirm.OpenStyle.ShowBox;
			this._ossMessage = string.Empty;
			this._stockThreshold = string.Empty;
			this._orderParam = string.Empty;
			this._message = string.Empty;
			this._isShowPin = false;
			this.tmCloseForm = null;
			
			this.InitializeComponent();
			this.openFormStyle = openStyle;
			ApplicationInfo.UserPincodeLastEntry = pinCode;
			this._message = message;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0002BEC0 File Offset: 0x0002A2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmOrderFormConfirm(string message, string caption, frmOrderFormConfirm.OpenStyle openStyle) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.result = DialogResult.None;
			this.openFormStyle = frmOrderFormConfirm.OpenStyle.ShowBox;
			this._ossMessage = string.Empty;
			this._stockThreshold = string.Empty;
			this._orderParam = string.Empty;
			this._message = string.Empty;
			this._isShowPin = false;
			this.tmCloseForm = null;
			
			this.InitializeComponent();
			this.Text = caption;
			this.openFormStyle = openStyle;
			this._message = message;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0002BF58 File Offset: 0x0002A358
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmOrderFormConfirm_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Init();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002BF70 File Offset: 0x0002A370
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
			{
				this.lbOrderString.Text = this._orderParam;
				if (this._orderParam.ToUpper().IndexOf("BUY") > -1)
				{
					this.lbOrderString.ForeColor = Color.Lime;
				}
				else if (this._orderParam.ToUpper().IndexOf("SELL") > -1)
				{
					this.lbOrderString.ForeColor = Color.Red;
				}
				else if (this._orderParam.ToUpper().IndexOf("SHORT") > -1)
				{
					this.lbOrderString.ForeColor = Color.Magenta;
				}
				else if (this._orderParam.ToUpper().IndexOf("COVER") > -1)
				{
					this.lbOrderString.ForeColor = Color.Cyan;
				}
				else
				{
					this.lbOrderString.ForeColor = Color.Yellow;
				}
				if (this._stockThreshold != string.Empty || this._ossMessage != string.Empty)
				{
					this.lbStockTH.Text = this._stockThreshold;
					this.lbOSS.Text = this._ossMessage;
					this.lbStockTH.Visible = true;
					this.lbOSS.Visible = true;
					this.lbOSSLabel.Visible = true;
				}
				else
				{
					this.lbStockTHlabel.Text = this._message;
					this.lbStockTH.Visible = false;
					this.lbOSS.Visible = false;
					this.lbOSSLabel.Visible = false;
				}
			}
			else
			{
				this.ShowText(this._message);
				if (this.openFormStyle == frmOrderFormConfirm.OpenStyle.Error)
				{
					this.lbOrderString.ForeColor = Color.Red;
				}
			}
			this.btnCancel.Visible = false;
			this.btnNo.Visible = false;
			this.btnOk.Visible = false;
			this.SetPinCodeVisible(false);
			this._isShowPin = false;
			switch (this.openFormStyle)
			{
			case frmOrderFormConfirm.OpenStyle.ShowBox:
			case frmOrderFormConfirm.OpenStyle.Error:
				this.btnOk.Visible = true;
				this.btnOk.Text = "Ok";
				this.btnOk.Left = (base.Width - this.btnOk.Width) / 2;
				break;
			case frmOrderFormConfirm.OpenStyle.ConfirmCancel:
			case frmOrderFormConfirm.OpenStyle.ConfirmSendNew:
				this._isShowPin = (ApplicationInfo.UserLoginMode == "C");
				this.SetUpControlOkCancel();
				break;
			case frmOrderFormConfirm.OpenStyle.ConfirmBox:
				this._isShowPin = false;
				this.SetUpControlOkCancel();
				break;
			}
			this.lbSavePin.Text = string.Concat(new string[]
			{
				"   \"Save PIN\" function allows you to save your PIN for an interval. During this ",
				"\r\ninterval, re-enter PIN is not required for any transaction performed in this",
				"\r\ntrading program only.",
				"\r\n   Therefore, you understand and accept the risk of using this \"Save PIN\"",
				"\r\nfunction, i2Trade will take no responsibility on any loss or damage from any",
				"\r\nerror occurred."
			});
			if (ApplicationInfo.IsScreen125)
			{
				this.lbOrderString.Font = new Font("Tahoma", 8.75f);
				this.lbStockTHlabel.Font = new Font("Tahoma", 8.75f);
				this.lbStockTH.Font = new Font("Tahoma", 8.75f);
				this.lbOSSLabel.Font = new Font("Tahoma", 8.75f);
				this.lbOSS.Font = new Font("Tahoma", 8.75f);
				this.lbSavePin.Font = new Font("Microsoft Sans Serif", 8.75f);
				this.btnOk.Font = new Font("Tahoma", 8.75f);
				this.btnNo.Font = new Font("Tahoma", 8.75f);
				this.btnCancel.Font = new Font("Tahoma", 8.75f);
				this.lbPincode.Font = new Font("Tahoma", 8.75f);
				this.chbSavePincode.Font = new Font("Tahoma", 8.75f);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0002C400 File Offset: 0x0002A800
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPinCodeVisible(bool isVisible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lbPincode.Visible = isVisible;
			this.tbPincode.Visible = isVisible;
			this.chbSavePincode.Visible = isVisible;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002C438 File Offset: 0x0002A838
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetUpControlOkCancel()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.btnOk.Visible = true;
				this.btnNo.Visible = true;
				this.btnOk.Text = "Ok";
				this.btnNo.Text = "Cancel";
				if (this._isShowPin)
				{
					this.SetPinCodeVisible(true);
					this.btnOk.Left = this.chbSavePincode.Left + this.chbSavePincode.Width + 10;
					this.btnNo.Left = this.btnOk.Left + this.btnOk.Width + 10;
				}
				else
				{
					this.btnOk.Left = base.Width / 3 - this.btnOk.Width / 2;
					this.btnNo.Left = base.Width * 2 / 3 - this.btnNo.Width / 2;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetUpControlOkCancel", ex);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0002C570 File Offset: 0x0002A970
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetUpControlYesNo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.btnOk.Visible = true;
				this.btnCancel.Visible = true;
				this.btnNo.Visible = true;
				this.btnOk.Text = "Yes";
				this.btnNo.Text = "No";
				this.btnOk.Left = base.Width / 4 - this.btnOk.Width / 2;
				this.btnNo.Left = base.Width * 2 / 4 - this.btnOk.Width / 2;
				this.btnCancel.Left = base.Width * 3 / 4 - this.btnOk.Width / 2;
			}
			catch (Exception ex)
			{
				this.ShowError("SetUpControlYesNo", ex);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0002C66C File Offset: 0x0002AA6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowText(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmOrderFormConfirm.ShowTextCallBack(this.ShowText), new object[]
				{
					message
				});
			}
			else
			{
				this.lbStockTHlabel.Text = string.Empty;
				this.lbStockTH.Visible = false;
				this.lbOSS.Visible = false;
				this.lbOSSLabel.Visible = false;
				this.lbOrderString.MaximumSize = new Size(this.panel1.Width - this.lbOrderString.Left * 2, 100);
				this.lbOrderString.Text = message;
				this.lbOrderString.ForeColor = Color.Yellow;
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0002C744 File Offset: 0x0002AB44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnOk_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.result == DialogResult.None)
				{
					if (this._isShowPin)
					{
						if (ApplicationInfo.AccInfo.UserInternetInBroker == "Y")
						{
							this.ShowText("Internal user not authenrize!");
							return;
						}
						if (ApplicationInfo.UserPincodeWrongCount >= ApplicationInfo.UserMaxRetryPincode)
						{
							this.ShowText("*** Pincode Locked. ***\nPlease logout and login again!");
							this.btnOk.Focus();
							return;
						}
						string empty = string.Empty;
						if (!ApplicationInfo.VerifyPincode(this.tbPincode.Text.Trim(), ref empty))
						{
							this.ShowText(empty);
							this.tbPincode.Focus();
							this.tbPincode.SelectAll();
							return;
						}
					}
					this.result = DialogResult.OK;
					this.ShowText("Waiting...");
					this.CloseMe();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnOk_Click", ex);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0002C894 File Offset: 0x0002AC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseMe()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.CloseMe));
			}
			else
			{
				try
				{
					base.Enabled = false;
					if (this.tmCloseForm == null)
					{
						this.tmCloseForm = new Timer();
						this.tmCloseForm.Interval = 100;
						this.tmCloseForm.Tick += new EventHandler(this.tmCloseForm_Tick);
					}
					this.tmCloseForm.Stop();
					this.tmCloseForm.Start();
				}
				catch (Exception ex)
				{
					this.ShowError("CloseMe", ex);
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002C970 File Offset: 0x0002AD70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmCloseForm_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tmCloseForm.Stop();
			base.Close();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002C994 File Offset: 0x0002AD94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnNo_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.result == DialogResult.None)
			{
				this.result = DialogResult.No;
				this.CloseMe();
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0002C9D4 File Offset: 0x0002ADD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.result == DialogResult.None)
			{
				this.result = DialogResult.Cancel;
				this.CloseMe();
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0002CA14 File Offset: 0x0002AE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmOrderFormConfirm_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._isShowPin)
			{
				if (ApplicationInfo.CheckPinTimeout())
				{
					this.tbPincode.Text = string.Empty;
				}
				else
				{
					this.chbSavePincode.Checked = Settings.Default.BSBoxSavePincode;
					if (Settings.Default.BSBoxSavePincode)
					{
						this.tbPincode.Text = ApplicationInfo.UserPincodeLastEntry;
					}
					else
					{
						this.tbPincode.Text = string.Empty;
					}
				}
			}
			if (this.tbPincode.Visible && this.tbPincode.Text == string.Empty)
			{
				this.tbPincode.Focus();
			}
			else if (this.btnCancel.Visible)
			{
				this.btnCancel.Focus();
			}
			else if (this.btnOk.Visible)
			{
				this.btnOk.Focus();
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002CB50 File Offset: 0x0002AF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Button_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(Button))
				{
					((Button)sender).BackColor = Color.Yellow;
				}
				else if (sender.GetType() == typeof(TextBox))
				{
					((TextBox)sender).BackColor = Color.Yellow;
					((TextBox)sender).SelectAll();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Button_Enter", ex);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002CC08 File Offset: 0x0002B008
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Button_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(Button))
				{
					((Button)sender).BackColor = Color.WhiteSmoke;
				}
				else if (sender.GetType() == typeof(TextBox))
				{
					((TextBox)sender).BackColor = Color.WhiteSmoke;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Button_Leave", ex);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002CCB0 File Offset: 0x0002B0B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chbSavePincode_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (Settings.Default.BSBoxSavePincode != this.chbSavePincode.Checked)
			{
				if (this.chbSavePincode.Checked)
				{
					this.gbSavePingDisclaimer.Show();
					this.gbSavePingDisclaimer.BringToFront();
				}
				else
				{
					Settings.Default.BSBoxSavePincode = this.chbSavePincode.Checked;
					Settings.Default.Save();
					this.tbPincode.Focus();
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0002CD50 File Offset: 0x0002B150
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPincode_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return || keyCode == Keys.Right)
			{
				this.btnOk.Focus();
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002CD9C File Offset: 0x0002B19C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmOrderFormConfirm_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Escape)
			{
				this.result = DialogResult.Cancel;
				this.CloseMe();
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002CDE0 File Offset: 0x0002B1E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSavePinAgree_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Settings.Default.BSBoxSavePincode = true;
			Settings.Default.Save();
			this.chbSavePincode.Checked = true;
			this.gbSavePingDisclaimer.Hide();
			this.tbPincode.Focus();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002CE38 File Offset: 0x0002B238
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSavePinDisAgree_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Settings.Default.BSBoxSavePincode = false;
			Settings.Default.Save();
			this.chbSavePincode.Checked = false;
			this.gbSavePingDisclaimer.Hide();
			this.tbPincode.Focus();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002CE90 File Offset: 0x0002B290
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x0400017A RID: 378
		private IContainer components;

		// Token: 0x0400017B RID: 379
		private Button btnCancel;

		// Token: 0x0400017C RID: 380
		private Button btnOk;

		// Token: 0x0400017D RID: 381
		private Button btnNo;

		// Token: 0x0400017E RID: 382
		private Label lbPincode;

		// Token: 0x0400017F RID: 383
		private TextBox tbPincode;

		// Token: 0x04000180 RID: 384
		private CheckBox chbSavePincode;

		// Token: 0x04000181 RID: 385
		private GroupBox gbSavePingDisclaimer;

		// Token: 0x04000182 RID: 386
		private Button btnSavePinDisAgree;

		// Token: 0x04000183 RID: 387
		private Button btnSavePinAgree;

		// Token: 0x04000184 RID: 388
		private Label lbSavePin;

		// Token: 0x04000185 RID: 389
		private Panel panel1;

		// Token: 0x04000186 RID: 390
		private Label lbStockTH;

		// Token: 0x04000187 RID: 391
		private Label lbStockTHlabel;

		// Token: 0x04000188 RID: 392
		private Label lbOrderString;

		// Token: 0x04000189 RID: 393
		private Label lbOSS;

		// Token: 0x0400018A RID: 394
		private Label lbOSSLabel;

		// Token: 0x0400018B RID: 395
		private DialogResult result;

		// Token: 0x0400018C RID: 396
		private frmOrderFormConfirm.OpenStyle openFormStyle;

		// Token: 0x0400018D RID: 397
		private string _ossMessage;

		// Token: 0x0400018E RID: 398
		private string _stockThreshold;

		// Token: 0x0400018F RID: 399
		private string _orderParam;

		// Token: 0x04000190 RID: 400
		private string _message;

		// Token: 0x04000191 RID: 401
		private bool _isShowPin;

		// Token: 0x04000192 RID: 402
		private Timer tmCloseForm;

		// Token: 0x0200003A RID: 58
		public enum OpenStyle
		{
			// Token: 0x04000194 RID: 404
			ShowBox,
			// Token: 0x04000195 RID: 405
			ConfirmCancel,
			// Token: 0x04000196 RID: 406
			ConfirmSendNew,
			// Token: 0x04000197 RID: 407
			Error,
			// Token: 0x04000198 RID: 408
			WaitingForm,
			// Token: 0x04000199 RID: 409
			ConfirmBox
		}

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000262 RID: 610
		private delegate void ShowTextCallBack(string message);
	}
}
