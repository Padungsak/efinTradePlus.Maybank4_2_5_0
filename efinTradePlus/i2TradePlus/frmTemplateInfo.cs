using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus
{
	// Token: 0x020000C6 RID: 198
	public class frmTemplateInfo : Form
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x000B0C88 File Offset: 0x000AF088
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

		// Token: 0x060008F8 RID: 2296 RVA: 0x000B0CD8 File Offset: 0x000AF0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTemplateInfo));
			this.label1 = new Label();
			this.txtTemplateName = new TextBox();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.imageListTemplateInfo = new ImageList(this.components);
			this.chkIsUseDefault = new CheckBox();
			this.lblplus = new Label();
			this.cmbModifierKey = new ComboBox();
			this.cmbFunctionKey = new ComboBox();
			this.lblHotkey = new Label();
			this.lbMessage = new Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(23, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(85, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Template Name:";
			this.txtTemplateName.Location = new Point(114, 9);
			this.txtTemplateName.Name = "txtTemplateName";
			this.txtTemplateName.Size = new Size(239, 20);
			this.txtTemplateName.TabIndex = 0;
			this.btnOK.Location = new Point(150, 69);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new EventHandler(this.btnOK_Click);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(243, 69);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.imageListTemplateInfo.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListTemplateInfo.ImageStream");
			this.imageListTemplateInfo.TransparentColor = Color.Transparent;
			this.imageListTemplateInfo.Images.SetKeyName(0, "scrolldown");
			this.imageListTemplateInfo.Images.SetKeyName(1, "scrollup");
			this.chkIsUseDefault.AutoSize = true;
			this.chkIsUseDefault.Location = new Point(62, 73);
			this.chkIsUseDefault.Name = "chkIsUseDefault";
			this.chkIsUseDefault.Size = new Size(82, 17);
			this.chkIsUseDefault.TabIndex = 3;
			this.chkIsUseDefault.Text = "Use Default";
			this.chkIsUseDefault.UseVisualStyleBackColor = true;
			this.lblplus.AutoSize = true;
			this.lblplus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
			this.lblplus.Location = new Point(190, 41);
			this.lblplus.Name = "lblplus";
			this.lblplus.Size = new Size(16, 16);
			this.lblplus.TabIndex = 11;
			this.lblplus.Text = "+";
			this.cmbModifierKey.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbModifierKey.FormattingEnabled = true;
			this.cmbModifierKey.Location = new Point(111, 37);
			this.cmbModifierKey.Name = "cmbModifierKey";
			this.cmbModifierKey.Size = new Size(77, 21);
			this.cmbModifierKey.TabIndex = 1;
			this.cmbFunctionKey.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbFunctionKey.FormattingEnabled = true;
			this.cmbFunctionKey.Location = new Point(207, 37);
			this.cmbFunctionKey.Name = "cmbFunctionKey";
			this.cmbFunctionKey.Size = new Size(74, 21);
			this.cmbFunctionKey.TabIndex = 2;
			this.lblHotkey.AutoSize = true;
			this.lblHotkey.Location = new Point(59, 40);
			this.lblHotkey.Name = "lblHotkey";
			this.lblHotkey.Size = new Size(48, 13);
			this.lblHotkey.TabIndex = 8;
			this.lblHotkey.Text = "Hot Key:";
			this.lbMessage.BorderStyle = BorderStyle.FixedSingle;
			this.lbMessage.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbMessage.Location = new Point(1, 107);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new Size(373, 23);
			this.lbMessage.TabIndex = 13;
			this.lbMessage.Text = "-";
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(376, 131);
			base.ControlBox = false;
			base.Controls.Add(this.lbMessage);
			base.Controls.Add(this.lblplus);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.cmbModifierKey);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.cmbFunctionKey);
			base.Controls.Add(this.chkIsUseDefault);
			base.Controls.Add(this.lblHotkey);
			base.Controls.Add(this.txtTemplateName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "frmTemplateInfo";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Template Setup";
			base.Load += new EventHandler(this.frmTemplateInfo_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000B13BC File Offset: 0x000AF7BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmTemplateInfo(frmTemplateInfo.ShowMode showMode, string templateName, bool isSetToDefaultTemplate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.showMode = frmTemplateInfo.ShowMode.Open;
			this.templateName = string.Empty;
			this.isSetToDefaultTemplate = false;
			this.isDatasChanged = false;
			base..ctor();
			this.InitializeComponent();
			this.showMode = showMode;
			this.templateName = templateName;
			this.isSetToDefaultTemplate = isSetToDefaultTemplate;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000B1428 File Offset: 0x000AF828
		public string TemplateName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.templateName;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000B1454 File Offset: 0x000AF854
		public int TempalteHotkey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.templateHotkey;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000B1480 File Offset: 0x000AF880
		public bool IsSetToDefaultTemplate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isSetToDefaultTemplate;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x000B14AC File Offset: 0x000AF8AC
		public bool IsDatasChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isDatasChanged;
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000B14D8 File Offset: 0x000AF8D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTemplateInfo_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.FillKeys();
			this.lbMessage.Text = "-";
			this.SetDisplayStyle();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000B1508 File Offset: 0x000AF908
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnOK_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (File.Exists(ApplicationInfo.GetTemplatePathByUser() + "\\" + this.txtTemplateName.Text + ".xml"))
			{
				if (this.showMode == frmTemplateInfo.ShowMode.Save || this.showMode == frmTemplateInfo.ShowMode.SaveAs)
				{
					if (MessageBox.Show("\"" + this.txtTemplateName.Text + "\" template already exists,would you like to replace it?", "Save template", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						return;
					}
				}
			}
			else if (this.showMode == frmTemplateInfo.ShowMode.Open)
			{
				this.lbMessage.Text = "\"" + this.txtTemplateName.Text + "\" template file not found.";
			}
			if (this.showMode == frmTemplateInfo.ShowMode.Save || this.showMode == frmTemplateInfo.ShowMode.SaveAs || this.showMode == frmTemplateInfo.ShowMode.Hotkeys)
			{
				try
				{
					if (!string.IsNullOrEmpty(this.txtTemplateName.Text))
					{
						Keys keyData = this.GetKeyData();
						bool flag = false;
						string str = string.Empty;
						try
						{
							flag = HotKeyManager.CheckHotkey(keyData);
						}
						catch (Exception ex)
						{
							str = ex.Message;
						}
						if (!flag && (this.showMode == frmTemplateInfo.ShowMode.SaveAs || this.showMode == frmTemplateInfo.ShowMode.Hotkeys))
						{
							this.lbMessage.Text = this.DisplayKeyFormat(keyData) + ":" + str;
							this.lbMessage.ForeColor = Color.Red;
							return;
						}
						this.templateHotkey = (int)keyData;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("btnOK_Click", ex);
					return;
				}
			}
			this.templateName = this.txtTemplateName.Text;
			this.isSetToDefaultTemplate = this.chkIsUseDefault.Checked;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000B1754 File Offset: 0x000AFB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.templateName = string.Empty;
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000B1780 File Offset: 0x000AFB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDisplayStyle()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtTemplateName.Text = this.templateName;
			this.chkIsUseDefault.Checked = this.isSetToDefaultTemplate;
			if (!string.IsNullOrEmpty(this.templateName))
			{
				Keys keyFromTemplateHotKey = HotKeyManager.GetKeyFromTemplateHotKey(this.templateName);
				if (keyFromTemplateHotKey != Keys.None)
				{
					this.DisplayKeysToCombobox(keyFromTemplateHotKey);
				}
			}
			switch (this.showMode)
			{
			case frmTemplateInfo.ShowMode.Save:
				this.chkIsUseDefault.Enabled = true;
				this.txtTemplateName.Enabled = true;
				break;
			case frmTemplateInfo.ShowMode.SaveAs:
				this.chkIsUseDefault.Enabled = true;
				break;
			case frmTemplateInfo.ShowMode.Option:
				this.btnCancel.Text = "Close";
				this.btnOK.Visible = false;
				this.txtTemplateName.ReadOnly = true;
				this.txtTemplateName.BackColor = SystemColors.Info;
				this.chkIsUseDefault.Enabled = false;
				break;
			case frmTemplateInfo.ShowMode.Hotkeys:
				this.chkIsUseDefault.Enabled = false;
				this.txtTemplateName.Enabled = false;
				this.cmbFunctionKey.Focus();
				break;
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000B18CC File Offset: 0x000AFCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FillKeys()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cmbFunctionKey.Items.Clear();
			this.cmbModifierKey.Items.Clear();
			Keys[] array = HotKeyManager.ModifierKeys;
			for (int i = 0; i < array.Length; i++)
			{
				Keys keys = array[i];
				this.cmbModifierKey.Items.Add(keys.ToString().Replace(".None", string.Empty));
			}
			array = HotKeyManager.FunctionKeys;
			for (int i = 0; i < array.Length; i++)
			{
				Keys keys = array[i];
				this.cmbFunctionKey.Items.Add(keys);
			}
			this.cmbModifierKey.SelectedIndex = 0;
			this.cmbFunctionKey.SelectedIndex = 0;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000B19B0 File Offset: 0x000AFDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string DisplayKeyFormat(Keys key)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string[] array = key.ToString().Split(new char[]
			{
				','
			});
			string text = (array.Length > 1) ? string.Format("{0}+{1}", array[1], array[0]) : array[0];
			return text.Trim();
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000B1A1C File Offset: 0x000AFE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisplayKeysToCombobox(Keys keysCode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = this.DisplayKeyFormat(keysCode);
				int num = text.IndexOf("+");
				if (num > 0)
				{
					this.cmbModifierKey.Text = text.Substring(0, num);
					this.cmbFunctionKey.Text = text.Substring(num + 1);
				}
				else
				{
					this.cmbFunctionKey.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DisplayKeysToCombobox", ex);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000B1AC4 File Offset: 0x000AFEC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Keys GetKeyData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keys = HotKeyManager.ModifierKeys[this.cmbModifierKey.SelectedIndex];
			if (this.cmbFunctionKey.SelectedIndex > -1)
			{
				keys |= HotKeyManager.FunctionKeys[this.cmbFunctionKey.SelectedIndex];
			}
			return keys;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000B1B28 File Offset: 0x000AFF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x040005D4 RID: 1492
		private IContainer components;

		// Token: 0x040005D5 RID: 1493
		private Label label1;

		// Token: 0x040005D6 RID: 1494
		private TextBox txtTemplateName;

		// Token: 0x040005D7 RID: 1495
		private Button btnOK;

		// Token: 0x040005D8 RID: 1496
		private Button btnCancel;

		// Token: 0x040005D9 RID: 1497
		private ImageList imageListTemplateInfo;

		// Token: 0x040005DA RID: 1498
		private CheckBox chkIsUseDefault;

		// Token: 0x040005DB RID: 1499
		private Label lblplus;

		// Token: 0x040005DC RID: 1500
		private ComboBox cmbModifierKey;

		// Token: 0x040005DD RID: 1501
		private ComboBox cmbFunctionKey;

		// Token: 0x040005DE RID: 1502
		private Label lblHotkey;

		// Token: 0x040005DF RID: 1503
		private Label lbMessage;

		// Token: 0x040005E0 RID: 1504
		private frmTemplateInfo.ShowMode showMode;

		// Token: 0x040005E1 RID: 1505
		private string templateName;

		// Token: 0x040005E2 RID: 1506
		private int templateHotkey;

		// Token: 0x040005E3 RID: 1507
		private bool isSetToDefaultTemplate;

		// Token: 0x040005E4 RID: 1508
		private bool isDatasChanged;

		// Token: 0x020000C7 RID: 199
		public enum ShowMode
		{
			// Token: 0x040005E6 RID: 1510
			Save,
			// Token: 0x040005E7 RID: 1511
			SaveAs,
			// Token: 0x040005E8 RID: 1512
			Open,
			// Token: 0x040005E9 RID: 1513
			Delete,
			// Token: 0x040005EA RID: 1514
			Option,
			// Token: 0x040005EB RID: 1515
			Hotkeys
		}
	}
}
