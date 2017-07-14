using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus
{
	// Token: 0x020000DB RID: 219
	internal class PasswordEntryUC : UserControl
	{
		// Token: 0x06000A27 RID: 2599 RVA: 0x000C219C File Offset: 0x000C059C
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

		// Token: 0x06000A28 RID: 2600 RVA: 0x000C21EC File Offset: 0x000C05EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PasswordEntryUC));
			this.lblPasswordText = new Label();
			this.lblConfirmPasswordText = new Label();
			this.txtPassword = new TextBox();
			this.txtConfirmPassword = new TextBox();
			this.errpValidatePassword = new ErrorProvider(this.components);
			this.pictureBoxPasswordOK = new PictureBox();
			this.pictureBoxConfirmPasswordOK = new PictureBox();
			this.txtOldPassword = new TextBox();
			this.lblOldPassword = new Label();
			this.pictureBoxOldPassword = new PictureBox();
			this.lblInfo = new Label();
			this.btnSave = new Button();
			((ISupportInitialize)this.errpValidatePassword).BeginInit();
			((ISupportInitialize)this.pictureBoxPasswordOK).BeginInit();
			((ISupportInitialize)this.pictureBoxConfirmPasswordOK).BeginInit();
			((ISupportInitialize)this.pictureBoxOldPassword).BeginInit();
			base.SuspendLayout();
			this.lblPasswordText.AutoSize = true;
			this.lblPasswordText.Location = new Point(3, 38);
			this.lblPasswordText.Name = "lblPasswordText";
			this.lblPasswordText.Size = new Size(62, 13);
			this.lblPasswordText.TabIndex = 4;
			this.lblPasswordText.Text = "Password : ";
			this.lblConfirmPasswordText.AutoSize = true;
			this.lblConfirmPasswordText.Location = new Point(3, 64);
			this.lblConfirmPasswordText.Name = "lblConfirmPasswordText";
			this.lblConfirmPasswordText.Size = new Size(99, 13);
			this.lblConfirmPasswordText.TabIndex = 5;
			this.lblConfirmPasswordText.Text = "Confirm password : ";
			this.txtPassword.ForeColor = SystemColors.GrayText;
			this.txtPassword.Location = new Point(103, 35);
			this.txtPassword.MaxLength = 12;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new Size(277, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Text = "Choose password and confirm,press ESC for cancel.";
			this.txtPassword.Validated += new EventHandler(this.txtPassword_Validated);
			this.txtPassword.KeyPress += new KeyPressEventHandler(this.txtPassword_KeyPress);
			this.txtPassword.Validating += new CancelEventHandler(this.txtPassword_Validating);
			this.txtConfirmPassword.Location = new Point(103, 61);
			this.txtConfirmPassword.MaxLength = 12;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.ReadOnly = true;
			this.txtConfirmPassword.Size = new Size(277, 20);
			this.txtConfirmPassword.TabIndex = 2;
			this.txtConfirmPassword.Validated += new EventHandler(this.txtConfirmPassword_Validated);
			this.txtConfirmPassword.KeyPress += new KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
			this.txtConfirmPassword.Validating += new CancelEventHandler(this.txtConfirmPassword_Validating);
			this.errpValidatePassword.ContainerControl = this;
			this.pictureBoxPasswordOK.Image = (Image)componentResourceManager.GetObject("pictureBoxPasswordOK.Image");
			this.pictureBoxPasswordOK.Location = new Point(381, 35);
			this.pictureBoxPasswordOK.Name = "pictureBoxPasswordOK";
			this.pictureBoxPasswordOK.Size = new Size(16, 20);
			this.pictureBoxPasswordOK.TabIndex = 6;
			this.pictureBoxPasswordOK.TabStop = false;
			this.pictureBoxPasswordOK.Visible = false;
			this.pictureBoxConfirmPasswordOK.Image = (Image)componentResourceManager.GetObject("pictureBoxConfirmPasswordOK.Image");
			this.pictureBoxConfirmPasswordOK.Location = new Point(380, 61);
			this.pictureBoxConfirmPasswordOK.Name = "pictureBoxConfirmPasswordOK";
			this.pictureBoxConfirmPasswordOK.Size = new Size(16, 16);
			this.pictureBoxConfirmPasswordOK.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBoxConfirmPasswordOK.TabIndex = 7;
			this.pictureBoxConfirmPasswordOK.TabStop = false;
			this.txtOldPassword.ForeColor = SystemColors.GrayText;
			this.txtOldPassword.Location = new Point(103, 10);
			this.txtOldPassword.MaxLength = 12;
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.Size = new Size(277, 20);
			this.txtOldPassword.TabIndex = 0;
			this.txtOldPassword.Text = "Enter current password ,press ESC for cancel.";
			this.txtOldPassword.Validated += new EventHandler(this.txtOldPassword_Validated);
			this.txtOldPassword.KeyPress += new KeyPressEventHandler(this.txtOldPassword_KeyPress);
			this.lblOldPassword.AutoSize = true;
			this.lblOldPassword.Location = new Point(3, 13);
			this.lblOldPassword.Name = "lblOldPassword";
			this.lblOldPassword.Size = new Size(81, 13);
			this.lblOldPassword.TabIndex = 3;
			this.lblOldPassword.Text = "Old Password : ";
			this.pictureBoxOldPassword.Image = (Image)componentResourceManager.GetObject("pictureBoxOldPassword.Image");
			this.pictureBoxOldPassword.Location = new Point(381, 10);
			this.pictureBoxOldPassword.Name = "pictureBoxOldPassword";
			this.pictureBoxOldPassword.Size = new Size(16, 20);
			this.pictureBoxOldPassword.TabIndex = 10;
			this.pictureBoxOldPassword.TabStop = false;
			this.pictureBoxOldPassword.Visible = false;
			this.lblInfo.AutoSize = true;
			this.lblInfo.ForeColor = Color.Red;
			this.lblInfo.Location = new Point(184, 97);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new Size(139, 13);
			this.lblInfo.TabIndex = 3;
			this.lblInfo.Text = "Your old password is wrong.";
			this.lblInfo.Visible = false;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new Point(103, 90);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new EventHandler(this.btnSave_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.pictureBoxPasswordOK);
			base.Controls.Add(this.pictureBoxConfirmPasswordOK);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.pictureBoxOldPassword);
			base.Controls.Add(this.txtConfirmPassword);
			base.Controls.Add(this.txtOldPassword);
			base.Controls.Add(this.lblInfo);
			base.Controls.Add(this.lblOldPassword);
			base.Controls.Add(this.lblConfirmPasswordText);
			base.Controls.Add(this.lblPasswordText);
			base.Name = "PasswordEntryUC";
			base.Size = new Size(404, 120);
			base.Load += new EventHandler(this.ChangePasswordUC_Load);
			((ISupportInitialize)this.errpValidatePassword).EndInit();
			((ISupportInitialize)this.pictureBoxPasswordOK).EndInit();
			((ISupportInitialize)this.pictureBoxConfirmPasswordOK).EndInit();
			((ISupportInitialize)this.pictureBoxOldPassword).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x000C2A20 File Offset: 0x000C0E20
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000C2A4C File Offset: 0x000C0E4C
		[DefaultValue(true)]
		public bool IsAutoEncrypt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isAutoEncrypt;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isAutoEncrypt = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000C2A64 File Offset: 0x000C0E64
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x000C2A90 File Offset: 0x000C0E90
		[DefaultValue(true)]
		public bool IsUseDefalutPattern
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isUseDefalutPattern;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isUseDefalutPattern = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000C2AA8 File Offset: 0x000C0EA8
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000C2AD8 File Offset: 0x000C0ED8
		[DefaultValue("Old Password : ")]
		public string OldPasswordLable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.lblOldPassword.Text;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.lblOldPassword.Text = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000C2AF8 File Offset: 0x000C0EF8
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000C2B28 File Offset: 0x000C0F28
		[DefaultValue("New Password : ")]
		public string PasswordLable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.lblPasswordText.Text;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.lblPasswordText.Text = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000C2B48 File Offset: 0x000C0F48
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000C2B78 File Offset: 0x000C0F78
		[DefaultValue("Confirm Password : ")]
		public string ConfirmPasswordLable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.lblConfirmPasswordText.Text;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.lblConfirmPasswordText.Text = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000C2B98 File Offset: 0x000C0F98
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000C2BC4 File Offset: 0x000C0FC4
		[DefaultValue(6)]
		public int MinimumPasswordLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.minimumPasswordLength;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.minimumPasswordLength = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000C2BDC File Offset: 0x000C0FDC
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x000C2C08 File Offset: 0x000C1008
		[DefaultValue(0)]
		public int MaximumPasswordLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.maximumPasswordLength;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.maximumPasswordLength = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000C2C20 File Offset: 0x000C1020
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x000C2C4C File Offset: 0x000C104C
		[DefaultValue(4)]
		public int MinimumPincodeLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.minimumPincodeLength;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.minimumPincodeLength = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000C2C64 File Offset: 0x000C1064
		[Browsable(false)]
		public string PasswordSetted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.passwordSetted;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000C2C90 File Offset: 0x000C1090
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000C2CBC File Offset: 0x000C10BC
		public bool IsCustomer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isCustomer;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isCustomer = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000C2CD4 File Offset: 0x000C10D4
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x000C2D00 File Offset: 0x000C1100
		public bool IsPincode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isPincode;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isPincode = value;
				this.lblInfo.Text = (this.isPincode ? "Your old Pincode is wrong." : "Your old Password is wrong.");
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000C2D40 File Offset: 0x000C1140
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PasswordEntryUC() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.INITIAL_NEWPASSWORD_TEXT_COLOR = SystemColors.GrayText;
			this.isInPasswordChoosing = false;
			this.originalPassword = string.Empty;
			this.isAutoEncrypt = true;
			this.isUseDefalutPattern = true;
			this.minimumPasswordLength = 6;
			this.maximumPasswordLength = 0;
			this.minimumPincodeLength = 4;
			this.passwordSetted = string.Empty;
			this.isCustomer = true;
			this.validate = PasswordEntryUC.ValidatePasswordResults.None;
			this.isPasswordModified = false;
			
			this.InitializeComponent();
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000C2DD8 File Offset: 0x000C11D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangePasswordUC_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.InitialControls();
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000C2DF0 File Offset: 0x000C11F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtOldPassword_Validated(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.originalPassword = this.txtOldPassword.Text.Trim();
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000C2E18 File Offset: 0x000C1218
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.pictureBoxPasswordOK.Visible = false;
			if (this.isInPasswordChoosing)
			{
				this.validate = this.ValidatePassword(this.txtPassword.Text);
				if (this.validate != PasswordEntryUC.ValidatePasswordResults.IsValid)
				{
					DescriptionAttribute[] array = (DescriptionAttribute[])typeof(PasswordEntryUC.ValidatePasswordResults).GetField(this.validate.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
					if (array != null && array.Length > 0)
					{
						this.errpValidatePassword.SetError(this.txtPassword, array[0].Description);
					}
					else
					{
						this.errpValidatePassword.SetError(this.txtPassword, this.validate.ToString());
					}
				}
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000C2F10 File Offset: 0x000C1310
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_Validated(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.isInPasswordChoosing && this.validate == PasswordEntryUC.ValidatePasswordResults.IsValid)
			{
				this.pictureBoxPasswordOK.Visible = true;
				if (this.txtConfirmPassword.Text == "Choose password and confirm, press ESC for cancel.")
				{
					this.txtConfirmPassword.Text = string.Empty;
				}
				this.txtConfirmPassword.Font = new Font(this.txtConfirmPassword.Font.FontFamily, this.txtConfirmPassword.Font.Size, FontStyle.Regular);
				this.txtConfirmPassword.PasswordChar = '*';
				this.txtConfirmPassword.ReadOnly = false;
				this.txtConfirmPassword.Focus();
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000C2FEC File Offset: 0x000C13EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.errpValidatePassword.Clear();
			this.pictureBoxPasswordOK.Visible = false;
			this.InitialConfirmPasswordControl();
			if (Convert.ToInt32(e.KeyChar) == 27)
			{
				this.InitialControls();
			}
			else if (Convert.ToInt32(e.KeyChar) == 13)
			{
				if (this.isInPasswordChoosing)
				{
					this.txtConfirmPassword.Focus();
				}
			}
			else if (this.txtPassword.Text == "Choose password and confirm, press ESC for cancel.")
			{
				this.passwordSetted = string.Empty;
				this.StartChooseNewPassword();
			}
			this.lblInfo.Visible = false;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000C30D0 File Offset: 0x000C14D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.pictureBoxConfirmPasswordOK.Visible = false;
			if (this.isInPasswordChoosing)
			{
				this.validate = this.ValidatePassword(this.txtPassword.Text, this.txtConfirmPassword.Text);
				if (this.validate != PasswordEntryUC.ValidatePasswordResults.IsValid)
				{
					DescriptionAttribute[] array = (DescriptionAttribute[])typeof(PasswordEntryUC.ValidatePasswordResults).GetField(this.validate.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
					if (array != null && array.Length > 0)
					{
						this.errpValidatePassword.SetError(this.txtConfirmPassword, array[0].Description);
					}
					else
					{
						this.errpValidatePassword.SetError(this.txtConfirmPassword, this.validate.ToString());
					}
				}
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000C31D4 File Offset: 0x000C15D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtConfirmPassword_Validated(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.isInPasswordChoosing && this.validate == PasswordEntryUC.ValidatePasswordResults.IsValid)
			{
				this.pictureBoxConfirmPasswordOK.Visible = true;
				this.passwordSetted = this.txtPassword.Text;
				this.isPasswordModified = true;
				this.btnSave.Enabled = true;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000C324C File Offset: 0x000C164C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.errpValidatePassword.Clear();
			this.pictureBoxConfirmPasswordOK.Visible = false;
			if (Convert.ToInt32(e.KeyChar) == 27)
			{
				this.InitialControls();
				this.txtPassword.Focus();
			}
			else if (Convert.ToInt32(e.KeyChar) == 13)
			{
				if (this.isInPasswordChoosing)
				{
					this.lblConfirmPasswordText.Focus();
				}
			}
			this.lblInfo.Visible = false;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000C32F8 File Offset: 0x000C16F8
		[Browsable(false)]
		public bool IsPasswordModified
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isPasswordModified;
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000C3324 File Offset: 0x000C1724
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitialControls()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.originalPassword = string.Empty;
			this.passwordSetted = string.Empty;
			this.isInPasswordChoosing = false;
			this.isPasswordModified = false;
			this.InitialPasswordControl();
			this.InitialConfirmPasswordControl();
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.SelectionLength = 0;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000C338C File Offset: 0x000C178C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitialPasswordControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtOldPassword.PasswordChar = (this.txtPassword.PasswordChar = '\0');
			this.txtOldPassword.Text = "Enter your old password, press ESC for cancel.";
			this.txtPassword.Text = "Choose password and confirm, press ESC for cancel.";
			this.txtOldPassword.ForeColor = (this.txtPassword.ForeColor = this.INITIAL_NEWPASSWORD_TEXT_COLOR);
			this.txtOldPassword.Font = (this.txtPassword.Font = new Font(this.txtPassword.Font.FontFamily, this.txtPassword.Font.Size, FontStyle.Italic));
			this.pictureBoxOldPassword.Visible = (this.pictureBoxPasswordOK.Visible = false);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000C3464 File Offset: 0x000C1864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitialConfirmPasswordControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtConfirmPassword.PasswordChar = '\0';
			this.txtConfirmPassword.Text = "Choose password and confirm, press ESC for cancel.";
			this.txtConfirmPassword.Font = new Font(this.txtConfirmPassword.Font.FontFamily, this.txtConfirmPassword.Font.Size, FontStyle.Italic);
			this.txtConfirmPassword.ReadOnly = true;
			this.pictureBoxConfirmPasswordOK.Visible = false;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000C34EC File Offset: 0x000C18EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartEnterOldPassword()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtOldPassword.PasswordChar = '*';
			this.txtOldPassword.Text = string.Empty;
			this.txtOldPassword.ForeColor = SystemColors.WindowText;
			this.txtOldPassword.Font = new Font(this.txtPassword.Font.FontFamily, this.txtPassword.Font.Size, FontStyle.Regular);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000C356C File Offset: 0x000C196C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartChooseNewPassword()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Text = string.Empty;
			this.txtPassword.ForeColor = SystemColors.WindowText;
			this.txtPassword.Font = new Font(this.txtPassword.Font.FontFamily, this.txtPassword.Font.Size, FontStyle.Regular);
			this.isInPasswordChoosing = true;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000C35F4 File Offset: 0x000C19F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PasswordEntryUC.ValidatePasswordResults ValidatePassword(string password)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			PasswordEntryUC.ValidatePasswordResults result;
			if (this.isPincode)
			{
				if (this.MinimumPincodeLength > 0 && string.IsNullOrEmpty(password))
				{
					result = PasswordEntryUC.ValidatePasswordResults.EmptyPassword;
				}
				else if (this.MinimumPincodeLength > 0 && password.Length < this.MinimumPincodeLength)
				{
					result = PasswordEntryUC.ValidatePasswordResults.ShorterThenMinLength;
				}
				else
				{
					result = PasswordEntryUC.ValidatePasswordResults.IsValid;
				}
			}
			else if (this.minimumPasswordLength > 0 && string.IsNullOrEmpty(password))
			{
				result = PasswordEntryUC.ValidatePasswordResults.EmptyPassword;
			}
			else if (this.minimumPasswordLength > 0 && password.Length < this.minimumPasswordLength)
			{
				result = PasswordEntryUC.ValidatePasswordResults.ShorterThenMinLength;
			}
			else if (this.maximumPasswordLength > 0 && password.Length > this.maximumPasswordLength)
			{
				result = PasswordEntryUC.ValidatePasswordResults.LongerThenMaxLength;
			}
			else if (this.minimumPasswordLength > 0 && this.isUseDefalutPattern)
			{
				if (this.isCustomer)
				{
					if (!Regex.IsMatch(password, "[a-zA-Z]"))
					{
						result = PasswordEntryUC.ValidatePasswordResults.NotContentAlphabat;
					}
					else if (!Regex.IsMatch(password, "[0-9]"))
					{
						result = PasswordEntryUC.ValidatePasswordResults.NotContentNumeric;
					}
					else if (!Regex.IsMatch(password, "!|#|\\*|@|\\|"))
					{
						result = PasswordEntryUC.ValidatePasswordResults.NotContentSpecialChar;
					}
					else
					{
						result = PasswordEntryUC.ValidatePasswordResults.IsValid;
					}
				}
				else
				{
					result = PasswordEntryUC.ValidatePasswordResults.IsValid;
				}
			}
			else
			{
				result = PasswordEntryUC.ValidatePasswordResults.IsValid;
			}
			return result;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000C37B4 File Offset: 0x000C1BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PasswordEntryUC.ValidatePasswordResults ValidatePassword(string password, string confirmPassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.ValidatePassword(password, confirmPassword, false);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000C37E0 File Offset: 0x000C1BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PasswordEntryUC.ValidatePasswordResults ValidatePassword(string password, string confirmPassword, bool isValidatePassword)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			PasswordEntryUC.ValidatePasswordResults result;
			if (isValidatePassword)
			{
				result = this.ValidatePassword(password);
			}
			if (this.minimumPasswordLength > 0 && string.IsNullOrEmpty(confirmPassword))
			{
				result = PasswordEntryUC.ValidatePasswordResults.EmptyConfirmPassword;
			}
			else if (password != confirmPassword)
			{
				result = PasswordEntryUC.ValidatePasswordResults.ConfirmPasswordNotMatched;
			}
			else
			{
				result = PasswordEntryUC.ValidatePasswordResults.IsValid;
			}
			return result;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000C3860 File Offset: 0x000C1C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowPasswordChangedInfo(bool canChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (canChanged)
			{
				this.lblInfo.Text = "Password changed.";
				this.lblInfo.ForeColor = Color.Lime;
			}
			else
			{
				this.lblInfo.Text = "Your old password is wrong.";
				this.lblInfo.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000C38D4 File Offset: 0x000C1CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangePasswordCustomer(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			if (!string.IsNullOrEmpty(this.originalPassword) && !string.IsNullOrEmpty(this.passwordSetted))
			{
				try
				{
					flag = ApplicationInfo.WebService.ChangeCustomerPassword(custAccID, this.originalPassword, this.passwordSetted);
					this.isPasswordModified = !flag;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			this.lblInfo.Visible = true;
			this.ShowPasswordChangedInfo(flag);
			return flag;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000C3978 File Offset: 0x000C1D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangePasswordTrader(string traderID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			if (!string.IsNullOrEmpty(this.originalPassword) && !string.IsNullOrEmpty(this.passwordSetted))
			{
				try
				{
					flag = ApplicationInfo.WebService.ChangeTraderPassword(traderID, this.originalPassword, this.passwordSetted);
					this.isPasswordModified = !flag;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			this.lblInfo.Visible = true;
			if (flag)
			{
				this.lblInfo.Text = "บันทึก Password สำเร็จ.";
			}
			return flag;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000C3A30 File Offset: 0x000C1E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangePINCODECustomer(string custAccID)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000C3A58 File Offset: 0x000C1E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtOldPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (Convert.ToInt32(e.KeyChar) == 27)
			{
				this.InitialControls();
			}
			else if (Convert.ToInt32(e.KeyChar) == 13)
			{
				this.txtPassword.Focus();
			}
			else if (this.txtOldPassword.Text == "Enter your old password, press ESC for cancel.")
			{
				this.originalPassword = string.Empty;
				this.StartEnterOldPassword();
			}
			this.lblInfo.Visible = false;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000C3B0C File Offset: 0x000C1F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSizeChanged(EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.OnSizeChanged(e);
			this.txtOldPassword.Width = (this.txtPassword.Width = (this.txtConfirmPassword.Width = base.Width - 150));
			this.pictureBoxOldPassword.Left = (this.pictureBoxPasswordOK.Left = (this.pictureBoxConfirmPasswordOK.Left = this.txtOldPassword.Left + this.txtOldPassword.Width));
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000C3BA8 File Offset: 0x000C1FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSave_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			if (ApplicationInfo.UserLoginMode == "C")
			{
				if (this.IsPasswordModified)
				{
					flag = this.ChangePasswordCustomer(ApplicationInfo.UserLoginID);
				}
				flag = (!this.IsPasswordModified || this.ChangePINCODECustomer(ApplicationInfo.UserLoginID));
			}
			else if (ApplicationInfo.UserLoginMode == "T")
			{
				flag = (!this.IsPasswordModified || this.ChangePasswordTrader(ApplicationInfo.UserLoginID));
			}
			if (flag)
			{
				this.btnSave.Enabled = false;
			}
		}

		// Token: 0x040006D2 RID: 1746
		private IContainer components;

		// Token: 0x040006D3 RID: 1747
		private Label lblPasswordText;

		// Token: 0x040006D4 RID: 1748
		private Label lblConfirmPasswordText;

		// Token: 0x040006D5 RID: 1749
		private TextBox txtPassword;

		// Token: 0x040006D6 RID: 1750
		private TextBox txtConfirmPassword;

		// Token: 0x040006D7 RID: 1751
		private ErrorProvider errpValidatePassword;

		// Token: 0x040006D8 RID: 1752
		private PictureBox pictureBoxConfirmPasswordOK;

		// Token: 0x040006D9 RID: 1753
		private PictureBox pictureBoxPasswordOK;

		// Token: 0x040006DA RID: 1754
		private TextBox txtOldPassword;

		// Token: 0x040006DB RID: 1755
		private Label lblOldPassword;

		// Token: 0x040006DC RID: 1756
		private PictureBox pictureBoxOldPassword;

		// Token: 0x040006DD RID: 1757
		private Label lblInfo;

		// Token: 0x040006DE RID: 1758
		private Button btnSave;

		// Token: 0x040006DF RID: 1759
		private readonly Color INITIAL_NEWPASSWORD_TEXT_COLOR;

		// Token: 0x040006E0 RID: 1760
		private bool isInPasswordChoosing;

		// Token: 0x040006E1 RID: 1761
		private string originalPassword;

		// Token: 0x040006E2 RID: 1762
		private bool isAutoEncrypt;

		// Token: 0x040006E3 RID: 1763
		private bool isUseDefalutPattern;

		// Token: 0x040006E4 RID: 1764
		private int minimumPasswordLength;

		// Token: 0x040006E5 RID: 1765
		private int maximumPasswordLength;

		// Token: 0x040006E6 RID: 1766
		private int minimumPincodeLength;

		// Token: 0x040006E7 RID: 1767
		private string passwordSetted;

		// Token: 0x040006E8 RID: 1768
		private bool isCustomer;

		// Token: 0x040006E9 RID: 1769
		private bool isPincode;

		// Token: 0x040006EA RID: 1770
		private PasswordEntryUC.ValidatePasswordResults validate;

		// Token: 0x040006EB RID: 1771
		private bool isPasswordModified;

		// Token: 0x020000DC RID: 220
		public enum ValidatePasswordResults
		{
			// Token: 0x040006ED RID: 1773
			[Description("Not is a result it's null state for set starting value.")]
			None,
			// Token: 0x040006EE RID: 1774
			[Description("Password is empty.")]
			EmptyPassword,
			// Token: 0x040006EF RID: 1775
			[Description("Confirm password is empty.")]
			EmptyConfirmPassword,
			// Token: 0x040006F0 RID: 1776
			[Description("Password is shorter than minimum length defined.")]
			ShorterThenMinLength,
			// Token: 0x040006F1 RID: 1777
			[Description("Password is longer than maximum length defined.")]
			LongerThenMaxLength,
			// Token: 0x040006F2 RID: 1778
			[Description("Password not have alphabat 'a-z' or 'A-Z' contented.")]
			NotContentAlphabat,
			// Token: 0x040006F3 RID: 1779
			[Description("Password not have numeric '0-9' contented.")]
			NotContentNumeric,
			// Token: 0x040006F4 RID: 1780
			[Description("Password not have special charactor '!','#','*','@','|' contented.")]
			NotContentSpecialChar,
			// Token: 0x040006F5 RID: 1781
			[Description("Confirm password is not match with password.")]
			ConfirmPasswordNotMatched,
			// Token: 0x040006F6 RID: 1782
			[Description("Validate password result it's 'OK'.")]
			IsValid,
			// Token: 0x040006F7 RID: 1783
			[Description("User dose not authorize to change password.")]
			UserNotAuthorize
		}
	}
}
