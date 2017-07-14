using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.BrokerAPI;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ.WebClient;
using Microsoft.Win32;

namespace i2TradePlus
{
	// Token: 0x020000BF RID: 191
	public class frmLogIn : Form
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x000AC9EC File Offset: 0x000AADEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmLogIn() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.bgwLoading = null;
			this.bgwCheckProxy = null;
			this._userId = string.Empty;
			this._userPassword = string.Empty;
			this.splashForm = null;
			this._isValidCustomerGrade = true;
			this._isRequireProxy = false;
			this._isRetryProxey = false;
			this._loginResult = frmLogIn.LoginResult.Fail;
			this._loginResultMessage = string.Empty;
			this.frm = null;
			this.components = null;
			
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			this.InitializeComponent();
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000ACA94 File Offset: 0x000AAE94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Seti2InfoURL(int BrokerId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string host = string.Empty;
			string custGrade = "0";
			this._isValidCustomerGrade = true;
			try
			{
				if (BrokerId == 4)
				{
					host = "https://tradings.maybank-ke.co.th/i2trade/i2info_MBKET_PLUS_4_2_5_0.ashx";
				}
				else if (BrokerId == 1)
				{
					host = "http://58.137.144.76/i2trade/i2info_CNS_Efin_PLUS.ashx";
				}
				else if (BrokerId == 9)
				{
					host = "http://d1.ktbst.co.th/i2trade/efininfo/i2info_KTBST_PLUS_4_2_5_0.ashx";
				}
				else if (BrokerId == 3)
				{
					host = "https://sso.osk188.co.th/i2trade/i2info_RHBS_PLUS_4_2_5_0.ashx";
				}
				else if (BrokerId == 2)
				{
					host = "https://www.ktzmico.com/ktzmico_service/i2Trade/i2info_KTZMICO_AD_4_1_2.ashx";
				}
				else if (BrokerId == 8)
				{
					host = "https://www.asiaplus.co.th/aspapp/i2trade/i2info_ASP_PLUS_4_2_5_0_INTRANET_2.php";
				}
				else if (BrokerId == 7)
				{
					host = "https://www.aira.co.th/i2trade/i2info_AIRA_PLUS_4_2_5_0.ashx";
				}
				else if (BrokerId == 10)
				{
					host = "https://trading.aws.co.th/i2trade/i2info_AWS_PLUS_4_2_5_0.ashx";
				}
				else if (BrokerId != 89)
				{
					if (BrokerId == 11)
					{
						host = "https://itrade.cimbsecurities.co.th/i2trade/i2info_CIMBS_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 12)
					{
						host = "https://sso.yuantathai.com/i2trade/i2info_YUANTA_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 13)
					{
						host = "http://www.lhsec.co.th/i2trade/i2info_LHSec_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 14)
					{
						host = "http://www.aecs.com/i2trade/i2info_AECS_PLUS_4_2_2_0.ashx";
					}
					else if (BrokerId == 15)
					{
						host = "http://27.254.98.5/efininfo/i2info_TNS_Efin_PLUS.ashx";
					}
					else if (BrokerId == 16)
					{
						host = "http://202.183.193.151/efintrade/i2info_GLOBLEX_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 17)
					{
						host = "http://61.91.13.141/efininfo/i2info_FNSYRUS_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 18)
					{
						host = "http://27.254.70.201/efininfo/i2info_UOBKayHian_Efin_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 88)
					{
						host = "http://www.efintradeplus.com/i2trade/i2info_DEMO_Efin_MOU_PLUS_4_2_5_0.ashx";
					}
					else if (BrokerId == 90)
					{
						host = "http://www.efintradeplus.com/i2trade/i2info_DEMO_Efin_MOU_PLUS_4_2_3.ashx";
					}
				}
				i2WSResult i2WSResult = default(i2WSResult);
				if (BrokerId == 4)
				{
					i2WSResult = i2InfoWS.GetConnectionInfoWithGrade(host, "S", "");
					KimengService kimengService = new KimengService();
					KimengWSResult customerGrade = kimengService.GetCustomerGrade(this.txtUserID.Text.Trim(), "", "STI_S");
					if (customerGrade.Code == "0")
					{
						if (!string.IsNullOrEmpty(customerGrade.CustomerGrade))
						{
							custGrade = customerGrade.CustomerGrade;
						}
						i2WSResult = i2InfoWS.GetConnectionInfoWithGrade(host, "S", custGrade);
					}
					else
					{
						this._isValidCustomerGrade = false;
						MessageBox.Show(customerGrade.Description);
					}
				}
				else
				{
					i2WSResult = i2InfoWS.GetConnectionInfoMulti(host, "S");
				}
				ApplicationInfo.WebUrl = i2WSResult.WsURL;
				ApplicationInfo.WebTfexUrl = i2WSResult.WsDURL;
				if (i2WSResult.WsOrderURL == null)
				{
					ApplicationInfo.WebOrderUrl = i2WSResult.WsURL;
				}
				else
				{
					ApplicationInfo.WebOrderUrl = i2WSResult.WsOrderURL;
				}
				if (i2WSResult.WsMainURL == null)
				{
					ApplicationInfo.WebMainUrl = i2WSResult.WsURL;
				}
				else
				{
					ApplicationInfo.WebMainUrl = i2WSResult.WsMainURL;
				}
				if (i2WSResult.WsAlertURL == null)
				{
					ApplicationInfo.WebAlertUrl = i2WSResult.WsURL;
				}
				else
				{
					ApplicationInfo.WebAlertUrl = i2WSResult.WsAlertURL;
				}
				ApplicationInfo.WebMainTfexUrl = i2WSResult.WsMainTfexURL;
				if (ApplicationInfo.IsSupportTfex)
				{
					if (string.IsNullOrEmpty(ApplicationInfo.WebTfexUrl))
					{
						ApplicationInfo.IsSupportTfex = false;
					}
				}
				else
				{
					ApplicationInfo.WebTfexUrl = string.Empty;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000ACEDC File Offset: 0x000AB2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmLogIn_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Text = "efin Trade+ V." + Application.ProductVersion;
				this.OpenProxySetting();
				this.bgwLoading = new BackgroundWorker();
				this.bgwLoading.WorkerReportsProgress = true;
				this.bgwLoading.DoWork += new DoWorkEventHandler(this.bgwLoading_DoWork);
				this.bgwLoading.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoading_RunWorkerCompleted);
				int brokerId = ApplicationInfo.BrokerId;
				if (brokerId <= 4)
				{
					if (brokerId != 1 && brokerId != 4)
					{
						goto IL_DF;
					}
				}
				else
				{
					switch (brokerId)
					{
					case 11:
					case 13:
						break;
					case 12:
						goto IL_DF;
					default:
						if (brokerId != 88)
						{
							goto IL_DF;
						}
						break;
					}
				}
				this.chbSupportTfex.Checked = Settings.Default.RequestTfex;
				this.chbSupportTfex.Visible = true;
				goto IL_F1;
				IL_DF:
				this.chbSupportTfex.Visible = false;
				IL_F1:;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000ACFF8 File Offset: 0x000AB3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtUserID_KeyDown(object sender, KeyEventArgs e)
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
				case Keys.Up:
					e.SuppressKeyPress = true;
					break;
				case Keys.Down:
					this.txtPassword.Focus();
					break;
				}
			}
			else
			{
				this.txtPassword.Focus();
				this.txtPassword.SelectAll();
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000AD078 File Offset: 0x000AB478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				if (keyCode == Keys.Up)
				{
					this.txtUserID.Focus();
					this.txtUserID.SelectAll();
				}
			}
			else
			{
				e.SuppressKeyPress = true;
				if (this.CheckValidateRequireField())
				{
					this.LoginProcessing();
				}
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000AD0F4 File Offset: 0x000AB4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000AD10C File Offset: 0x000AB50C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnOk_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.CheckValidateRequireField())
			{
				this.LoginProcessing();
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000AD140 File Offset: 0x000AB540
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbLoginMode_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return)
			{
				this.txtUserID.Focus();
				this.txtUserID.SelectAll();
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000AD18C File Offset: 0x000AB58C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckValidateRequireField()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			if (string.IsNullOrEmpty(this.txtUserID.Text))
			{
				MessageBox.Show("Invalid User Id!", "LogIn!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.txtUserID.Focus();
			}
			else if (string.IsNullOrEmpty(this.txtPassword.Text) && !ApplicationInfo.IsOpenFromWeb)
			{
				MessageBox.Show("Invalid Password!", "LogIn!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.txtPassword.Focus();
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000AD244 File Offset: 0x000AB644
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoginProcessing()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.txtPassword.Enabled = false;
				this.btnLogin.Enabled = false;
				this.splashForm = new frmSplash();
				this.splashForm.StartPosition = FormStartPosition.Manual;
				ApplicationInfo.IsSupportTfex = this.chbSupportTfex.Checked;
				this._userId = this.txtUserID.Text.Trim();
				Settings.Default.LastLoginId = this._userId;
				Settings.Default.RequestTfex = this.chbSupportTfex.Checked;
				if (ApplicationInfo.IsOpenFromWeb)
				{
					this._userPassword = ApplicationInfo.AuthenKey;
				}
				else
				{
					this._userPassword = this.txtPassword.Text.Trim();
				}
				if (this.chkSettingProxy.Checked)
				{
					this.SaveProxySetting();
				}
				if (this.bgwCheckProxy == null)
				{
					this.bgwCheckProxy = new BackgroundWorker();
					this.bgwCheckProxy.WorkerReportsProgress = true;
					this.bgwCheckProxy.DoWork += new DoWorkEventHandler(this.bgwCheckProxy_DoWork);
					this.bgwCheckProxy.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwCheckProxy_RunWorkerCompleted);
				}
				if (!this.bgwCheckProxy.IsBusy)
				{
					this.bgwCheckProxy.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoginProcessing", ex);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000AD3E4 File Offset: 0x000AB7E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwCheckProxy_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			while (true)
			{
				try
				{
					this.Seti2InfoURL(ApplicationInfo.BrokerId);
					this._isRequireProxy = false;
					break;
				}
				catch (Exception ex)
				{
					this.CloseSplashMessage();
					if (ex.ToString().IndexOf("407") <= -1)
					{
						MessageBox.Show(ex.Message);
						this.ReEnableInputPassword(true);
						this._isRequireProxy = true;
						break;
					}
					this._isRequireProxy = true;
					if (this._isRetryProxey || !(Settings.Default.ProxyHost != string.Empty) || Settings.Default.ProxyPort <= 0 || !(Settings.Default.ProxyUsername != string.Empty) || !(Settings.Default.ProxyPassword != string.Empty))
					{
						if (this._isRetryProxey)
						{
							MessageBox.Show("Invalid proxy config, please check your account or password. ");
						}
						this.CheckSettingProxy(true);
						this.OpenProxySetting();
						this.ReEnableInputPassword(true);
						break;
					}
					this._isRetryProxey = true;
					ApplicationInfo.IsUseProxy = true;
					ApplicationInfo.ProxyPassword = Settings.Default.ProxyPassword;
				}
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000AD56C File Offset: 0x000AB96C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwCheckProxy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isRequireProxy)
				{
					Settings.Default.LastLoginId = this.txtUserID.Text.Trim();
					Settings.Default.Save();
					if (this._isValidCustomerGrade)
					{
						this.bgwLoading.RunWorkerAsync();
					}
					else
					{
						this.ReEnableInputPassword(true);
					}
				}
				else
				{
					this.txtPassword.Enabled = true;
					this.btnLogin.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000AD628 File Offset: 0x000ABA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckSettingProxy(bool isCheck)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.chkSettingProxy.InvokeRequired)
			{
				this.chkSettingProxy.Invoke(new frmLogIn.CheckSettingProxyCallBack(this.CheckSettingProxy), new object[]
				{
					isCheck
				});
			}
			else
			{
				this.chkSettingProxy.Checked = isCheck;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000AD694 File Offset: 0x000ABA94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReEnableInputPassword(bool isEnable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmLogIn.ReEnableInputPasswordCallback(this.ReEnableInputPassword), new object[]
				{
					isEnable
				});
			}
			else
			{
				this.txtPassword.Enabled = isEnable;
				this.btnLogin.Enabled = isEnable;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000AD708 File Offset: 0x000ABB08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseSplashMessage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.splashForm.InvokeRequired)
			{
				this.splashForm.Invoke(new MethodInvoker(this.CloseSplashMessage));
			}
			else if (this.splashForm != null)
			{
				this.splashForm.Close();
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000AD774 File Offset: 0x000ABB74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplashMessage(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmLogIn.ShowSplashMessageCallback(this.ShowSplashMessage), new object[]
				{
					message
				});
			}
			else
			{
				this.splashForm.TopLevel = false;
				this.splashForm.Parent = this;
				this.splashForm.TopMost = true;
				this.splashForm.Left = (base.Width - this.splashForm.Width) / 2;
				this.splashForm.Top = this.txtPassword.Top;
				this.splashForm.SetCurrentTask(message);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000AD834 File Offset: 0x000ABC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoading_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string data = string.Empty;
			try
			{
				this.ShowSplashMessage("Authentication...");
				string text = string.Empty;
				foreach (KeyValuePair<string, AccountInfo.ItemInfo> current in ApplicationInfo.AccInfo.Items)
				{
					text = text + "/" + current.Key;
				}
				if (text != string.Empty)
				{
					text = text.Substring(1);
				}
				string message = UserAuthenMessage.Pack(ApplicationInfo.AuthenKey, this._userId, this._userPassword, ApplicationInfo.IP, ApplicationInfo.GetTermicalId(), Application.ProductVersion, true, ApplicationInfo.UserEfin, text, "EFIN");
				data = ApplicationInfo.WebMainService.UserAuthen(message);
				DataSet dataSet = new DataSet();
				MyDataHelper.StringToDataSet(data, dataSet);
				if (dataSet == null || !dataSet.Tables.Contains("Results") || dataSet.Tables["Results"].Rows.Count <= 0)
				{
					this._loginResult = frmLogIn.LoginResult.Fail;
					this._loginResultMessage = "Result not found!!!";
				}
				else
				{
					dataSet.CaseSensitive = false;
					int num;
					int.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out num);
					string loginResultMessage = dataSet.Tables["Results"].Rows[0]["message"].ToString();
					if (num < 0)
					{
						if (num == -7)
						{
							this._loginResult = frmLogIn.LoginResult.InvalidVersion;
						}
						else
						{
							this._loginResult = frmLogIn.LoginResult.Fail;
						}
						this._loginResultMessage = loginResultMessage;
					}
					else
					{
						string empty = string.Empty;
						if (dataSet.Tables.Contains("AUTHEN"))
						{
							foreach (DataRow dataRow in dataSet.Tables["AUTHEN"].Rows)
							{
								string text2 = dataRow["control_name"].ToString();
								switch (text2)
								{
								case "session":
									ApplicationInfo.UserSessionID = dataRow["control_value"].ToString();
									break;
								case "account":
									if (!ApplicationInfo.IsOpenFromWeb)
									{
										ApplicationInfo.AccInfo.UserLists = dataRow["Control_value"].ToString().Trim();
									}
									break;
								case "ke_session":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.KE_Session = dataRow["Control_value"].ToString();
									}
									break;
								case "ke_sbl":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.SuuportSBL = dataRow["Control_value"].ToString();
									}
									break;
								case "ktzmico_session":
									ApplicationInfo.KTZ_Session = dataRow["Control_value"].ToString();
									break;
								case "ktz_cust_map_key":
									ApplicationInfo.KTZ_custMapKey = dataRow["Control_value"].ToString();
									break;
								case "aspticket":
									ApplicationInfo.ASP_Ticket = dataRow["Control_value"].ToString();
									break;
								case "fss_session":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.FSS_Session = dataRow["Control_value"].ToString();
									}
									break;
								case "yt_session":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.YUANTA_Session = dataRow["Control_value"].ToString();
									}
									break;
								case "yt_sbl":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.SuuportSBL = dataRow["Control_value"].ToString();
									}
									break;
								case "authenkey":
									ApplicationInfo.AuthenKey = dataRow["Control_value"].ToString();
									break;
								case "user_efin":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.UserEfin = dataRow["Control_value"].ToString();
									}
									break;
								case "eservice_server":
									ApplicationInfo.EserviceServer = dataRow["control_value"].ToString();
									break;
								case "efin_finance_url":
									ApplicationInfo.UrlEfinFinance = dataRow["control_value"].ToString();
									break;
								case "efin_news_url":
									ApplicationInfo.UrlEfinNews = dataRow["control_value"].ToString();
									break;
								case "efin_websession":
									ApplicationInfo.UrlEfinSession = dataRow["control_value"].ToString();
									break;
								case "tns_session":
									if (dataRow["Control_value"].ToString() != string.Empty)
									{
										ApplicationInfo.TNS_Session = dataRow["control_value"].ToString();
									}
									break;
								}
							}
						}
						if (dataSet.Tables.Contains("BrokerControl"))
						{
							foreach (DataRow dataRow in dataSet.Tables["BrokerControl"].Rows)
							{
								string text2 = dataRow["control_name"].ToString().ToLower().Trim();
								switch (text2)
								{
								case "internetuser":
									ApplicationInfo.AccInfo.InternetUser = dataRow["control_value"].ToString();
									break;
								case "internetmutualuser":
									ApplicationInfo.AccInfo.InternetMutualUser = dataRow["control_value"].ToString();
									break;
								case "internetusertfex":
									ApplicationInfo.AccInfo.InternetUserTFEX = dataRow["control_value"].ToString();
									break;
								case "marginrate":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.UserMarginRate);
									break;
								case "pincodetimeout":
								{
									int num3;
									int.TryParse(dataRow["control_value"].ToString(), out num3);
									if (num3 > -1)
									{
										ApplicationInfo.UserMaxPincodeTimeout = num3;
									}
									break;
								}
								case "mincustomerpasswordlength":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.MinPasswordLength);
									break;
								case "mincustomerpincodelength":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.MinPincodeLength);
									break;
								case "customerretrypincode":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.UserMaxRetryPincode);
									break;
								case "newslink":
									ApplicationInfo.NewsHomeLink = dataRow["control_value"].ToString();
									break;
								case "newssymbollink":
									ApplicationInfo.NewsSymbolLink = dataRow["control_value"].ToString();
									break;
								case "stockinfolink":
									ApplicationInfo.StockFocusHomeLink = dataRow["control_value"].ToString();
									break;
								case "stockfocussymbollink":
									ApplicationInfo.StockFocusSymbolLink = dataRow["control_value"].ToString();
									break;
								case "clientautogetorder":
									if (dataRow["control_value"].ToString() == "Y")
									{
										ApplicationInfo.IsAutoGetOrderInfo = true;
									}
									else
									{
										ApplicationInfo.IsAutoGetOrderInfo = false;
									}
									break;
								case "clientautogetorderinterval":
								{
									int num3;
									int.TryParse(dataRow["control_value"].ToString(), out num3);
									ApplicationInfo.AutoGetOrderInfoInterval = num3;
									break;
								}
								case "client_sbl":
									if (ApplicationInfo.BrokerId != 4)
									{
										ApplicationInfo.SuuportSBL = dataRow["control_value"].ToString();
									}
									break;
								case "client_showsplash":
									ApplicationInfo.SuuportSplash = dataRow["control_value"].ToString();
									break;
								case "ifis":
									ApplicationInfo.SupportFreewill = true;
									break;
								case "frontsystemtfex":
									ApplicationInfo.FrontSystemTFEX = dataRow["control_value"].ToString();
									break;
								case "frontsystem":
									ApplicationInfo.FrontSystem = dataRow["control_value"].ToString();
									break;
								case "supportnav":
									ApplicationInfo.SupportNAV = (dataRow["control_value"].ToString() == "Y");
									break;
								case "supportalert":
									ApplicationInfo.SupportNod = (dataRow["control_value"].ToString() == "Y");
									break;
								case "pullintervalpc":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.PullInterval);
									break;
								case "supportcollateral":
									ApplicationInfo.SupportCollateral = dataRow["control_value"].ToString();
									break;
								case "pccaneditorder":
									ApplicationInfo.PCCanEditorder = dataRow["control_value"].ToString();
									break;
								case "pccaneditordertfex":
									ApplicationInfo.PCCanEditorderTFEX = dataRow["control_value"].ToString();
									break;
								case "batchorder":
									ApplicationInfo.SupportBatchOrder = dataRow["control_value"].ToString();
									break;
								case "supporteservicepc":
									ApplicationInfo.IsSupportEservice = (dataRow["control_value"].ToString() == "Y");
									break;
								case "hbinterval":
									int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.HBInterval);
									break;
								case "urlefinchart":
									ApplicationInfo.UrlEfinChart = dataRow["control_value"].ToString();
									ApplicationInfo.IsSupportEfinChart = (ApplicationInfo.UrlEfinChart != string.Empty);
									break;
								case "svat":
								{
									decimal num4;
									decimal.TryParse(dataRow["control_value"].ToString(), out num4);
									if (num4 > 0m)
									{
										ApplicationInfo.UserVAT = num4;
									}
									break;
								}
								case "internetcommrate":
								{
									decimal num4;
									decimal.TryParse(dataRow["control_value"].ToString(), out num4);
									if (num4 > 0m)
									{
										ApplicationInfo.UserCommRate = num4;
									}
									break;
								}
								case "supportautotrade":
									if (!ApplicationInfo.IsOpenFromWeb || (ApplicationInfo.IsOpenFromWeb && ApplicationInfo.AutoTradeFromWeb))
									{
										int.TryParse(dataRow["control_value"].ToString(), out ApplicationInfo.AutoTradeType);
									}
									break;
								case "supportpm":
									ApplicationInfo.SupportPM = (dataRow["control_value"].ToString() == "Y");
									break;
								}
							}
						}
						if (dataSet.Tables.Contains("CONFIG"))
						{
							string[] array = new string[]
							{
								"",
								"",
								"",
								"",
								""
							};
							string text3 = string.Empty;
							foreach (DataRow dataRow in dataSet.Tables["CONFIG"].Rows)
							{
								if (!ApplicationInfo.IsSupportTfex)
								{
									if (dataRow["key"].ToString() == "FAV1")
									{
										array[0] = dataRow["value"].ToString().Trim();
									}
									else if (dataRow["key"].ToString() == "FAV2")
									{
										array[1] = dataRow["value"].ToString().Trim();
									}
									else if (dataRow["key"].ToString() == "FAV3")
									{
										array[2] = dataRow["value"].ToString().Trim();
									}
									else if (dataRow["key"].ToString() == "FAV4")
									{
										array[3] = dataRow["value"].ToString().Trim();
									}
									else if (dataRow["key"].ToString() == "FAV5")
									{
										array[4] = dataRow["value"].ToString().Trim();
									}
									else if (dataRow["key"].ToString() == "TICKER_FIL")
									{
										text3 = dataRow["value"].ToString().Trim();
									}
								}
								else if (dataRow["key"].ToString() == "FAV1T")
								{
									array[0] = dataRow["value"].ToString().Trim();
								}
								else if (dataRow["key"].ToString() == "FAV2T")
								{
									array[1] = dataRow["value"].ToString().Trim();
								}
								else if (dataRow["key"].ToString() == "FAV3T")
								{
									array[2] = dataRow["value"].ToString().Trim();
								}
								else if (dataRow["key"].ToString() == "FAV4T")
								{
									array[3] = dataRow["value"].ToString().Trim();
								}
								else if (dataRow["key"].ToString() == "FAV5T")
								{
									array[4] = dataRow["value"].ToString().Trim();
								}
								else if (dataRow["key"].ToString() == "TICKER_FILT")
								{
									text3 = dataRow["value"].ToString().Trim();
								}
								if (dataRow["key"].ToString() == "FONT_SOFT")
								{
									ApplicationInfo.IsFrontSoftStyle = (dataRow["value"].ToString().Trim() == "Y");
								}
							}
							ApplicationInfo.InitFavStock(array);
							array = null;
							if (text3 != string.Empty)
							{
								string[] array2 = text3.Split(new char[]
								{
									';'
								});
								string[] array3 = array2;
								for (int i = 0; i < array3.Length; i++)
								{
									string item = array3[i];
									ApplicationInfo.TickerStockList.Add(item);
								}
							}
						}
						else
						{
							ApplicationInfo.InitFavStock(null);
						}
						if (string.IsNullOrEmpty(ApplicationInfo.UserSessionID))
						{
							this._loginResult = frmLogIn.LoginResult.Fail;
							this._loginResultMessage = "User Session is empty!!!";
						}
						if (num > 0)
						{
							if (!string.IsNullOrEmpty(ApplicationInfo.AccInfo.UserLists))
							{
								ApplicationInfo.SetupUsers(ApplicationInfo.AccInfo.UserLists, '/');
								ApplicationInfo.UserLoginID = this.txtUserID.Text.Trim();
							}
							this._loginResult = frmLogIn.LoginResult.Success;
						}
					}
				}
				dataSet.Clear();
				dataSet = null;
			}
			catch (Exception ex)
			{
				this._loginResult = frmLogIn.LoginResult.Fail;
				this._loginResultMessage = ex.Message;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000AED64 File Offset: 0x000AD164
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._loginResult == frmLogIn.LoginResult.InvalidVersion)
				{
					DialogResult dialogResult = MessageBox.Show(this._loginResultMessage, "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
					if (dialogResult == DialogResult.Yes)
					{
						Process.Start(ApplicationInfo.WebService.GetUrlClient());
					}
					if (this.splashForm != null)
					{
						this.splashForm.Close();
					}
					this.txtPassword.Enabled = true;
					this.btnLogin.Enabled = true;
					return;
				}
				if (this._loginResult == frmLogIn.LoginResult.Fail)
				{
					if (this.splashForm != null)
					{
						this.splashForm.Close();
					}
					if (this._loginResultMessage != string.Empty)
					{
						MessageBox.Show(this._loginResultMessage);
					}
					else
					{
						MessageBox.Show("Unknow error!!!");
					}
					this.txtPassword.Enabled = true;
					this.btnLogin.Enabled = true;
					this.txtUserID.Focus();
					this.txtUserID.SelectAll();
					return;
				}
				if (this.splashForm != null)
				{
					this.splashForm.Close();
				}
				this.txtUserID.Text = string.Empty;
				this.txtPassword.Text = string.Empty;
				this.txtPassword.Enabled = true;
				this.btnLogin.Enabled = true;
				this.txtUserID.Focus();
				this.txtUserID.SelectAll();
				this.chkSettingProxy.Checked = false;
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoading_RunWorkerCompleted", ex);
			}
			base.Hide();
			try
			{
				if (this.frm == null)
				{
					this.frm = new frmMain();
				}
				this.frm.FormClosed -= new FormClosedEventHandler(this.frmMain_FormClosed);
				this.frm.FormClosed += new FormClosedEventHandler(this.frmMain_FormClosed);
				this.frm.Show();
				if (this.splashForm != null)
				{
					this.splashForm.Close();
					this.splashForm.Dispose();
				}
				this.splashForm = null;
			}
			catch (Exception ex)
			{
				EventLog.WriteEntry("i2Trade", ex.Message, EventLogEntryType.Error);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000AF028 File Offset: 0x000AD428
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Thread.Sleep(500);
			if (this.frm != null)
			{
				if (!this.frm.IsDisposed)
				{
					this.frm.Dispose();
				}
				this.frm = null;
			}
			GC.Collect();
			Application.Exit();
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000AF094 File Offset: 0x000AD494
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtUserID_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtUserID.BackColor = Color.LightYellow;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000AF0B8 File Offset: 0x000AD4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtPassword.BackColor = Color.LightYellow;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000AF0DC File Offset: 0x000AD4DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtPassword_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtPassword.BackColor = Color.White;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000AF100 File Offset: 0x000AD500
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtUserID_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.txtUserID.BackColor = Color.White;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000AF124 File Offset: 0x000AD524
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000AF158 File Offset: 0x000AD558
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenProxySetting()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.OpenProxySetting));
			}
			else
			{
				try
				{
					base.Height = (this.chkSettingProxy.Checked ? (this.pnLogin.Height + this.gbProxy.Height + 5) : this.pnLogin.Height);
					this.chkRememberPwd.Checked = Settings.Default.RememberProxyPassword;
					if (!string.IsNullOrEmpty(Settings.Default.ProxyHost))
					{
						this.txtProxyHost.Text = Settings.Default.ProxyHost;
						this.txtProxyPort.Text = Settings.Default.ProxyPort.ToString();
					}
					else
					{
						string registryStringValue = BusinessServiceFactory.GetRegistryStringValue(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyServer");
						if (!string.IsNullOrEmpty(registryStringValue))
						{
							string[] array = registryStringValue.Split(new char[]
							{
								':'
							});
							if (array != null && array.Length > 1)
							{
								this.txtProxyHost.Text = array[0];
								this.txtProxyPort.Text = array[1];
							}
						}
					}
					this.txtProxyUserName.Text = Settings.Default.ProxyUsername;
					this.txtProxyPassword.Text = Settings.Default.ProxyPassword;
					this.txtProxyUserName.Focus();
				}
				catch (Exception ex)
				{
					this.ShowError("OpenProxySetting", ex);
				}
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000AF334 File Offset: 0x000AD734
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveProxySetting()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.IsUseProxy = true;
				Settings.Default.ProxyHost = this.txtProxyHost.Text;
				Settings.Default.ProxyPort = (string.IsNullOrEmpty(this.txtProxyPort.Text) ? 80 : Convert.ToInt32(this.txtProxyPort.Text));
				Settings.Default.RememberProxyPassword = this.chkRememberPwd.Checked;
				Settings.Default.ProxyUsername = this.txtProxyUserName.Text;
				ApplicationInfo.ProxyPassword = this.txtProxyPassword.Text;
				if (this.chkRememberPwd.Checked)
				{
					Settings.Default.ProxyPassword = this.txtProxyPassword.Text;
				}
				else
				{
					Settings.Default.ProxyPassword = string.Empty;
				}
				Settings.Default.Save();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000AF45C File Offset: 0x000AD85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chkSetingProxy_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.gbProxy.Top = 253;
			this.gbProxy.Visible = this.chkSettingProxy.Checked;
			base.Height = (this.chkSettingProxy.Checked ? (this.pnLogin.Height + this.gbProxy.Height + 10) : (this.pnLogin.Top * 2 + this.pnLogin.Height));
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000AF4F0 File Offset: 0x000AD8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void txtProxyPassword_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return)
			{
				this.btnLogin.PerformClick();
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000AF52C File Offset: 0x000AD92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmLogIn_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ApplicationInfo.IsOpenFromWeb)
			{
				this.txtUserID.Text = ApplicationInfo.UserLoginID;
				if (this.txtUserID.Text != string.Empty)
				{
					this.txtPassword.Focus();
				}
				else
				{
					this.txtUserID.Focus();
				}
				this.txtUserID.Enabled = !ApplicationInfo.IsOpenFromWeb;
				this.lbPassword.Hide();
				this.txtPassword.Hide();
				if (this.CheckValidateRequireField())
				{
					this.LoginProcessing();
				}
			}
			else if (!string.IsNullOrEmpty(Settings.Default.LastLoginId))
			{
				this.txtUserID.Text = Settings.Default.LastLoginId;
				this.txtPassword.Focus();
			}
			else
			{
				this.txtUserID.Focus();
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000AF63C File Offset: 0x000ADA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pnLogin_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.ClipRectangle.Width == this.pnLogin.ClientSize.Width)
			{
				e.Graphics.DrawRectangle(Pens.Gainsboro, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000AF6D4 File Offset: 0x000ADAD4
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

		// Token: 0x060008DD RID: 2269 RVA: 0x000AF724 File Offset: 0x000ADB24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogIn));
			this.lbCopyRight = new Label();
			this.txtPassword = new TextBox();
			this.txtUserID = new TextBox();
			this.btnCancel = new Button();
			this.btnLogin = new Button();
			this.lbUserID = new Label();
			this.lbPassword = new Label();
			this.pnLogin = new Panel();
			this.chbSupportTfex = new CheckBox();
			this.pictureBox1 = new PictureBox();
			this.chkSettingProxy = new CheckBox();
			this.label1 = new Label();
			this.chkRememberPwd = new CheckBox();
			this.txtProxyPort = new TextBox();
			this.txtProxyHost = new TextBox();
			this.txtProxyPassword = new TextBox();
			this.txtProxyUserName = new TextBox();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.gbProxy = new GroupBox();
			this.lblNote = new Label();
			this.pnLogin.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.gbProxy.SuspendLayout();
			base.SuspendLayout();
			this.lbCopyRight.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lbCopyRight.BackColor = Color.Transparent;
			this.lbCopyRight.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbCopyRight.ForeColor = Color.LightGray;
			this.lbCopyRight.Location = new Point(3, 218);
			this.lbCopyRight.Name = "lbCopyRight";
			this.lbCopyRight.Size = new Size(449, 22);
			this.lbCopyRight.TabIndex = 15;
			this.lbCopyRight.Text = "Copyright 2015 Online Asset Co.,Ltd  All rights reserved";
			this.lbCopyRight.TextAlign = ContentAlignment.BottomCenter;
			this.lbCopyRight.UseCompatibleTextRendering = true;
			this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
			this.txtPassword.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtPassword.Location = new Point(182, 109);
			this.txtPassword.MaxLength = 16;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new Size(170, 23);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.KeyDown += new KeyEventHandler(this.txtPassword_KeyDown);
			this.txtPassword.Leave += new EventHandler(this.txtPassword_Leave);
			this.txtPassword.Enter += new EventHandler(this.txtPassword_Enter);
			this.txtUserID.BackColor = Color.White;
			this.txtUserID.BorderStyle = BorderStyle.FixedSingle;
			this.txtUserID.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtUserID.Location = new Point(182, 79);
			this.txtUserID.MaxLength = 50;
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new Size(170, 23);
			this.txtUserID.TabIndex = 1;
			this.txtUserID.KeyDown += new KeyEventHandler(this.txtUserID_KeyDown);
			this.txtUserID.Leave += new EventHandler(this.txtUserID_Leave);
			this.txtUserID.Enter += new EventHandler(this.txtUserID_Enter);
			this.btnCancel.AutoSize = true;
			this.btnCancel.BackColor = SystemColors.Info;
			this.btnCancel.Cursor = Cursors.Arrow;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnCancel.Location = new Point(245, 174);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(81, 31);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnLogin.AutoSize = true;
			this.btnLogin.BackColor = SystemColors.Info;
			this.btnLogin.Cursor = Cursors.Arrow;
			this.btnLogin.FlatStyle = FlatStyle.Flat;
			this.btnLogin.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnLogin.Location = new Point(141, 174);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new Size(81, 31);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Ok";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new EventHandler(this.btnOk_Click);
			this.lbUserID.AutoSize = true;
			this.lbUserID.BackColor = Color.Transparent;
			this.lbUserID.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbUserID.ForeColor = Color.LightGray;
			this.lbUserID.Location = new Point(92, 82);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new Size(75, 16);
			this.lbUserID.TabIndex = 9;
			this.lbUserID.Text = "Username :";
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = Color.Transparent;
			this.lbPassword.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbPassword.ForeColor = Color.LightGray;
			this.lbPassword.Location = new Point(95, 113);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new Size(73, 16);
			this.lbPassword.TabIndex = 10;
			this.lbPassword.Text = "Password :";
			this.pnLogin.BackColor = Color.Transparent;
			this.pnLogin.BorderStyle = BorderStyle.FixedSingle;
			this.pnLogin.Controls.Add(this.chbSupportTfex);
			this.pnLogin.Controls.Add(this.pictureBox1);
			this.pnLogin.Controls.Add(this.chkSettingProxy);
			this.pnLogin.Controls.Add(this.label1);
			this.pnLogin.Controls.Add(this.lbCopyRight);
			this.pnLogin.Controls.Add(this.txtPassword);
			this.pnLogin.Controls.Add(this.txtUserID);
			this.pnLogin.Controls.Add(this.lbUserID);
			this.pnLogin.Controls.Add(this.btnCancel);
			this.pnLogin.Controls.Add(this.lbPassword);
			this.pnLogin.Controls.Add(this.btnLogin);
			this.pnLogin.Cursor = Cursors.Default;
			this.pnLogin.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.pnLogin.Location = new Point(0, 0);
			this.pnLogin.Name = "pnLogin";
			this.pnLogin.Size = new Size(457, 249);
			this.pnLogin.TabIndex = 20;
			this.pnLogin.Paint += new PaintEventHandler(this.pnLogin_Paint);
			this.chbSupportTfex.AutoSize = true;
			this.chbSupportTfex.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbSupportTfex.ForeColor = Color.FromArgb(255, 128, 0);
			this.chbSupportTfex.Location = new Point(139, 145);
			this.chbSupportTfex.Name = "chbSupportTfex";
			this.chbSupportTfex.Size = new Size(101, 19);
			this.chbSupportTfex.TabIndex = 25;
			this.chbSupportTfex.Text = "Support TFEX";
			this.chbSupportTfex.UseVisualStyleBackColor = true;
			this.pictureBox1.Image = Resources.LOGO;
			this.pictureBox1.Location = new Point(160, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(146, 40);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.chkSettingProxy.AutoSize = true;
			this.chkSettingProxy.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chkSettingProxy.ForeColor = Color.LightGray;
			this.chkSettingProxy.Location = new Point(262, 145);
			this.chkSettingProxy.Name = "chkSettingProxy";
			this.chkSettingProxy.Size = new Size(96, 19);
			this.chkSettingProxy.TabIndex = 23;
			this.chkSettingProxy.Text = "Setting Proxy";
			this.chkSettingProxy.UseVisualStyleBackColor = true;
			this.chkSettingProxy.CheckedChanged += new EventHandler(this.chkSetingProxy_CheckedChanged);
			this.label1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.LightGray;
			this.label1.Location = new Point(11, 54);
			this.label1.Name = "label1";
			this.label1.Size = new Size(437, 21);
			this.label1.TabIndex = 22;
			this.label1.Text = "Internet Trading Workstation";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label1.UseCompatibleTextRendering = true;
			this.chkRememberPwd.AutoSize = true;
			this.chkRememberPwd.Location = new Point(260, 140);
			this.chkRememberPwd.Name = "chkRememberPwd";
			this.chkRememberPwd.Size = new Size(158, 20);
			this.chkRememberPwd.TabIndex = 8;
			this.chkRememberPwd.Text = "Remember Password";
			this.chkRememberPwd.UseVisualStyleBackColor = true;
			this.txtProxyPort.BorderStyle = BorderStyle.FixedSingle;
			this.txtProxyPort.Location = new Point(260, 52);
			this.txtProxyPort.Name = "txtProxyPort";
			this.txtProxyPort.Size = new Size(125, 22);
			this.txtProxyPort.TabIndex = 7;
			this.txtProxyHost.BorderStyle = BorderStyle.FixedSingle;
			this.txtProxyHost.Location = new Point(260, 24);
			this.txtProxyHost.Name = "txtProxyHost";
			this.txtProxyHost.Size = new Size(125, 22);
			this.txtProxyHost.TabIndex = 6;
			this.txtProxyPassword.BorderStyle = BorderStyle.FixedSingle;
			this.txtProxyPassword.Location = new Point(261, 106);
			this.txtProxyPassword.Name = "txtProxyPassword";
			this.txtProxyPassword.PasswordChar = '*';
			this.txtProxyPassword.Size = new Size(125, 22);
			this.txtProxyPassword.TabIndex = 9;
			this.txtProxyPassword.KeyUp += new KeyEventHandler(this.txtProxyPassword_KeyUp);
			this.txtProxyUserName.BorderStyle = BorderStyle.FixedSingle;
			this.txtProxyUserName.Location = new Point(261, 78);
			this.txtProxyUserName.Name = "txtProxyUserName";
			this.txtProxyUserName.Size = new Size(125, 22);
			this.txtProxyUserName.TabIndex = 8;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(179, 108);
			this.label4.Name = "label4";
			this.label4.Size = new Size(68, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(170, 81);
			this.label5.Name = "label5";
			this.label5.Size = new Size(77, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "User Name";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(215, 54);
			this.label3.Name = "label3";
			this.label3.Size = new Size(32, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Port";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(188, 27);
			this.label2.Name = "label2";
			this.label2.Size = new Size(59, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Address";
			this.gbProxy.BackColor = SystemColors.Control;
			this.gbProxy.Controls.Add(this.txtProxyPassword);
			this.gbProxy.Controls.Add(this.lblNote);
			this.gbProxy.Controls.Add(this.label4);
			this.gbProxy.Controls.Add(this.txtProxyUserName);
			this.gbProxy.Controls.Add(this.chkRememberPwd);
			this.gbProxy.Controls.Add(this.label2);
			this.gbProxy.Controls.Add(this.label5);
			this.gbProxy.Controls.Add(this.txtProxyPort);
			this.gbProxy.Controls.Add(this.label3);
			this.gbProxy.Controls.Add(this.txtProxyHost);
			this.gbProxy.Cursor = Cursors.Default;
			this.gbProxy.Location = new Point(7, 0);
			this.gbProxy.Name = "gbProxy";
			this.gbProxy.Size = new Size(442, 173);
			this.gbProxy.TabIndex = 21;
			this.gbProxy.TabStop = false;
			this.gbProxy.Text = "Proxy Setting";
			this.gbProxy.Visible = false;
			this.lblNote.BackColor = Color.FromArgb(255, 255, 192);
			this.lblNote.Location = new Point(6, 22);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new Size(146, 147);
			this.lblNote.TabIndex = 10;
			this.lblNote.Text = "\r\nคำแนะนำ\r\n   ในกรณีที่ต้องมีการเชื่อมต่อ \r\n Internet ผ่าน Proxy\r\n ท่านสามารถสอบถามข้อมูล\r\n เกี่ยวกับการใช้งาน Proxy \r\n ได้จาก ผู้ดูแลระบบของท่าน";
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new Size(457, 249);
			base.ControlBox = false;
			base.Controls.Add(this.pnLogin);
			base.Controls.Add(this.gbProxy);
			this.Cursor = Cursors.NoMove2D;
			this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmLogIn";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "efin Trade+";
			base.Load += new EventHandler(this.frmLogIn_Load);
			base.Shown += new EventHandler(this.frmLogIn_Shown);
			this.pnLogin.ResumeLayout(false);
			this.pnLogin.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.gbProxy.ResumeLayout(false);
			this.gbProxy.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040005A4 RID: 1444
		private BackgroundWorker bgwLoading;

		// Token: 0x040005A5 RID: 1445
		private BackgroundWorker bgwCheckProxy;

		// Token: 0x040005A6 RID: 1446
		private string _userId;

		// Token: 0x040005A7 RID: 1447
		private string _userPassword;

		// Token: 0x040005A8 RID: 1448
		private frmSplash splashForm;

		// Token: 0x040005A9 RID: 1449
		private bool _isValidCustomerGrade;

		// Token: 0x040005AA RID: 1450
		private bool _isRequireProxy;

		// Token: 0x040005AB RID: 1451
		private bool _isRetryProxey;

		// Token: 0x040005AC RID: 1452
		private frmLogIn.LoginResult _loginResult;

		// Token: 0x040005AD RID: 1453
		private string _loginResultMessage;

		// Token: 0x040005AE RID: 1454
		private frmMain frm;

		// Token: 0x040005AF RID: 1455
		private IContainer components;

		// Token: 0x040005B0 RID: 1456
		private Label lbCopyRight;

		// Token: 0x040005B1 RID: 1457
		private TextBox txtPassword;

		// Token: 0x040005B2 RID: 1458
		private TextBox txtUserID;

		// Token: 0x040005B3 RID: 1459
		private Button btnCancel;

		// Token: 0x040005B4 RID: 1460
		private Button btnLogin;

		// Token: 0x040005B5 RID: 1461
		private Label lbUserID;

		// Token: 0x040005B6 RID: 1462
		private Label lbPassword;

		// Token: 0x040005B7 RID: 1463
		private Panel pnLogin;

		// Token: 0x040005B8 RID: 1464
		private Label label1;

		// Token: 0x040005B9 RID: 1465
		private CheckBox chkRememberPwd;

		// Token: 0x040005BA RID: 1466
		private TextBox txtProxyPort;

		// Token: 0x040005BB RID: 1467
		private TextBox txtProxyHost;

		// Token: 0x040005BC RID: 1468
		private TextBox txtProxyPassword;

		// Token: 0x040005BD RID: 1469
		private TextBox txtProxyUserName;

		// Token: 0x040005BE RID: 1470
		private Label label4;

		// Token: 0x040005BF RID: 1471
		private Label label5;

		// Token: 0x040005C0 RID: 1472
		private Label label3;

		// Token: 0x040005C1 RID: 1473
		private Label label2;

		// Token: 0x040005C2 RID: 1474
		private GroupBox gbProxy;

		// Token: 0x040005C3 RID: 1475
		private CheckBox chkSettingProxy;

		// Token: 0x040005C4 RID: 1476
		private Label lblNote;

		// Token: 0x040005C5 RID: 1477
		private PictureBox pictureBox1;

		// Token: 0x040005C6 RID: 1478
		private CheckBox chbSupportTfex;

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x060008DF RID: 2271
		private delegate void CheckSettingProxyCallBack(bool isCheck);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x060008E3 RID: 2275
		private delegate void ReEnableInputPasswordCallback(bool isEnable);

		// Token: 0x020000C2 RID: 194
		private enum LoginResult
		{
			// Token: 0x040005C8 RID: 1480
			Success,
			// Token: 0x040005C9 RID: 1481
			Fail,
			// Token: 0x040005CA RID: 1482
			InvalidVersion
		}

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x060008E7 RID: 2279
		private delegate void ShowSplashMessageCallback(string message);
	}
}
